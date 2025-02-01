using System.Data;
using System.Diagnostics;
using System.Formats.Tar;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct UserRow
    {
        public string Username;
        public string Password;
        public string Email;
        public int? Age;
        public string? Address;
        public bool IsAdmin;
    }
    public class UsersService
    {
        #region Private_Properties
        private static DataTable _AllUsersTable;
        public static DataTable AllUsersTable { get => _AllUsersTable; }
        private IDBContext _DBContext;
        // All primary keys are identity, so this should work for what it is
        #endregion

        #region Constructors
        public UsersService(IDBContext DBContext)
        {
            _DBContext = DBContext;

            const string UpdateQuery = """
                UPDATE USERS
                SET
                Username = @Username,
                PasswordHash = @PasswordHash,
                Salt = @Salt,
                Email = @Email,
                Age = @Age, 
                Address = @Address,
                IsAdmin = @IsAdmin
                WHERE UserId = @UserId;
                """;

            List<SqlParameter> UpdateParams = new List<SqlParameter>()
            {
                new SqlParameter("UserId", SqlDbType.Int, 4, "UserId"),
                new SqlParameter("Username", SqlDbType.NVarChar, 50, "Username"),
                new SqlParameter("PasswordHash", SqlDbType.VarChar, 255, "PasswordHash"),
                new SqlParameter("Salt", SqlDbType.VarChar, 255, "Salt"),
                new SqlParameter("Email", SqlDbType.NVarChar, 100, "Email"),
                new SqlParameter("Age", SqlDbType.Int, 4, "Age"),
                new SqlParameter("Address", SqlDbType.NVarChar, 255, "Address"),
                new SqlParameter("IsAdmin", SqlDbType.Bit, 1, "IsAdmin"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Update, UpdateQuery.Trim(), UpdateParams);

            const string InsertQuery = """
                INSERT INTO USERS (Username, PasswordHash, Salt, Email, Age, Address, IsAdmin)
                VALUES (@Username, @PasswordHash, @Salt, @Email, @Age, @Address, @IsAdmin);
                """;

            List<SqlParameter> InsertParams = new List<SqlParameter>()
            {
                new SqlParameter("UserId", SqlDbType.Int, 4, "UserId"),
                new SqlParameter("Username", SqlDbType.NVarChar, 50, "Username"),
                new SqlParameter("PasswordHash", SqlDbType.VarChar, 255, "PasswordHash"),
                new SqlParameter("Salt", SqlDbType.VarChar, 255, "Salt"),
                new SqlParameter("Email", SqlDbType.NVarChar, 100, "Email"),
                new SqlParameter("Age", SqlDbType.Int, 4, "Age"),
                new SqlParameter("Address", SqlDbType.NVarChar, 255, "Address"),
                new SqlParameter("IsAdmin", SqlDbType.Bit, 1, "IsAdmin"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), InsertParams);

            const string DeleteQuery = """
                DELETE FROM USERS
                WHERE UserId = @UserId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Delete, DeleteQuery.Trim(), new List<SqlParameter>() { new SqlParameter("UserId", SqlDbType.Int, 4, "UserId") });

            _AllUsersTable = GetAllUsers();
            _AllUsersTable.Columns["UserId"].AutoIncrement = true;
        }
        #endregion

        #region Methods
        public DataTable GetAllUsers()
        {
            DataTable Result = _DBContext.ExecuteSelect("SELECT * FROM USERS");
            return Result;
        }

        public DataTable GetUserBasedOnName(string InputUsername, out string ErrorMessage)
        {
            DataTable Result = null;
            ErrorMessage = "";
            const string Query = """
                SELECT * FROM USERS
                WHERE Username = @Username;
                """;

            try
            {
                Result = _DBContext.ExecuteSelect(Query,
                new SqlParameter("Username", InputUsername));

            }
            catch (Exception ex)
            {
                ErrorMessage = $"Error: {ex.Message}";
            }
            return Result;
        }

        public bool SearchUsernames(string InputUsername, out string ResultString)
        {
            DataTable AllUsers = GetAllUsers();

            foreach (DataRow UserRow in AllUsers.Rows)
            {
                if (UserRow["Username"].ToString() == InputUsername)
                {
                    ResultString = "User Found!";
                    return true;
                }
            }
            ResultString = "User doesn't exist!";
            return false;
        }

        public bool VerifyUser(string InputUsername, string InputPassword, out string ErrorResult)
        {
            ErrorResult = string.Empty;
            if (!SearchUsernames(InputUsername, out string Result))
            {
                ErrorResult = Result;
            }
            DataTable TargetUser = GetUserBasedOnName(InputUsername, out string ErrorMessage);
            if (TargetUser.Rows.Count < 1)
            {
                ErrorResult = "User doesn't exist in database!";
                return false;
            }
            DataRow Row = TargetUser.Rows[0];
            string StoredHash = Row["PasswordHash"].ToString();
            string StoredSalt = Row["Salt"].ToString();

            if (!PasswordHasher.VerifyPassword(InputPassword, StoredHash, StoredSalt))
            {
                ErrorResult = "The username or password you've entered is incorrect!";
            }

            return true;
        }

        public bool IsUserAdmin(string InputUsername)
        {
            DataTable TargetUser = GetUserBasedOnName(InputUsername, out string ErrorMessage);
            Debug.Assert(TargetUser != null, "The InputUsername passed here shouldn't be invalid!");
            DataRow Row = TargetUser.Rows[0];
            return (bool)Row["IsAdmin"];
        }

        public void InsertUser(UserRow NewRowData)
        {
            (string Hash, string Salt) = PasswordHasher.HashPassword(NewRowData.Password);
            DataRow Row = _AllUsersTable.NewRow();

            try
            {
                Row["Username"] = String.Copy(NewRowData.Username);
                Row["PasswordHash"] = String.Copy(Hash);
                Row["Salt"] = String.Copy(Salt);
                Row["Email"] = String.Copy(NewRowData.Email);
                Row["IsAdmin"] = NewRowData.IsAdmin;
                Row["Age"] = NewRowData.Age == 0 ? null : NewRowData.Age;
                Row["Address"] = NewRowData.Address == string.Empty ? null : NewRowData.Address;
                _AllUsersTable.Rows.Add(Row);
            }
            catch (Exception ex)
            {
                // TODO: Logging
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateUser(int RowIndex, UserRow NewRowData)
        {
            if (!(RowIndex >= 0 && RowIndex <= _AllUsersTable.Rows.Count))
            {
                // TODO: Logging
                throw new IndexOutOfRangeException("Row Index out of range!!");
            }
            (string Hash, string Salt) = PasswordHasher.HashPassword(NewRowData.Password);

            DataRow SelectedRow = _AllUsersTable.Rows[RowIndex];

            SelectedRow["Username"] = String.Copy(NewRowData.Username);
            SelectedRow["PasswordHash"] = String.Copy(Hash);
            SelectedRow["Salt"] = String.Copy(Salt);
            SelectedRow["Email"] = String.Copy(NewRowData.Email);
            SelectedRow["IsAdmin"] = NewRowData.IsAdmin;
            SelectedRow["Age"] = NewRowData.Age == 0 ? null : NewRowData.Age;
            SelectedRow["Address"] = NewRowData.Address == string.Empty ? null : NewRowData.Address;
        }

        public void DeleteUser(int RowIndex)
        {
            DataRow SelectedRow = _AllUsersTable.Rows[RowIndex];
            SelectedRow.Delete();
        }

        public void SubmitUserUpdates()
        {
            _DBContext.UploadToServer(_AllUsersTable);
        }
        #endregion
    }
}
