using System.Data;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct UserRow
    {
        public int UserId;
        public string Username;
        public string PasswordHash;
        public string Salt;
        public string Email;
        public int? Age;
        public string? Address;
        public bool IsAdmin;
    }
    public class UsersService
    {
        #region Private_Properties
        private SqlServerContext _DBContext;
        private DataTable _AllUsersTable;
        // All primary keys are identity, so this should work for what it is
        private int _UserCount = 0;
        #endregion

        #region Constructors
        public UsersService()
        {
            _DBContext = new SqlServerContext();

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
                INSERT INTO USERS (UserId, Username, PasswordHash, Salt, Email, Age, Address, IsAdmin)
                VALUES (@UserId, @Username, @PasswordHash, @Salt, @Email, @Age, @Address, @IsAdmin);
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), UpdateParams);

            const string DeleteQuery = """
                DELETE FROM USERS
                WHERE UserId = @UserId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), new List<SqlParameter>() { new SqlParameter("UserId", SqlDbType.Int, 4, "UserId") });

            _AllUsersTable = new DataTable();
        }
        #endregion

        #region Methods
        public void GetAllUsers()
        {
            _AllUsersTable = _DBContext.ExecuteSelect("SELECT * FROM USERS");
            _UserCount = _AllUsersTable.Rows.Count;
        }

        public void InsertUser(UserRow NewRowData)
        {
            DataRow Row = _AllUsersTable.NewRow();

            try
            {
                Row["UserId"] = ++_UserCount;
                Row["Username"] = String.Copy(NewRowData.Username);
                Row["PasswordHash"] = String.Copy(NewRowData.PasswordHash);
                Row["Salt"] = String.Copy(NewRowData.Salt);
                Row["Email"] = String.Copy(NewRowData.Email);
                Row["IsAdmin"] = NewRowData.IsAdmin;
                Row["Age"] = NewRowData.Age;
                Row["Address"] = NewRowData.Address ?? String.Copy(NewRowData.Address);
                _AllUsersTable.Rows.Add(Row);
            }
            catch(Exception ex)
            {
                // TODO: Logging
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateUser(int RowIndex, UserRow NewRowData)
        {
            if(!(RowIndex >= 0 && RowIndex <=  _AllUsersTable.Rows.Count))
            {
                // TODO: Logging
                throw new IndexOutOfRangeException("Row Index out of range!!");
            }
            DataRow SelectedRow = _AllUsersTable.Rows[RowIndex];

            SelectedRow["Username"] = String.Copy(NewRowData.Username);
            SelectedRow["PasswordHash"] = String.Copy(NewRowData.PasswordHash);
            SelectedRow["Salt"] = String.Copy(NewRowData.Salt);
            SelectedRow["Email"] = String.Copy(NewRowData.Email);
            SelectedRow["IsAdmin"] = NewRowData.IsAdmin;
            SelectedRow["Age"] = NewRowData.Age;
            SelectedRow["Address"] = NewRowData.Address == null ? String.Copy(NewRowData.Address) : null;
        }

        public void DeleteUser(int RowIndex)
        {
            DataRow SelectedRow = _AllUsersTable.Rows[RowIndex];
            SelectedRow.Delete();
        }
        #endregion
    }
}
