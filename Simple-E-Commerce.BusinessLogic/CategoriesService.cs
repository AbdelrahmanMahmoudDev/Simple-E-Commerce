using System.Data;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct CategoryRow
    {
        public string CategoryName;
    }
    public class CategoriesService
    {
        #region Private_Properties
        private static DataTable _AllCategoriesTable;
        public static DataTable AllCategoriesTable { get => _AllCategoriesTable} 
        private IDBContext _DBContext;
        // All primary keys are identity, so this should work for what it is
        #endregion

        #region Constructors
        public CategoriesService(IDBContext DBContext)
        {
            _DBContext = DBContext;

            const string UpdateQuery = """
                UPDATE Categories
                SET
                CategoryName = @CategoryName,
                WHERE CategoryId = @CategoryId;
                """;

            List<SqlParameter> UpdateParams = new List<SqlParameter>()
            {
                new SqlParameter("CategoryName", SqlDbType.VarChar, 255, "CategoryName"),
                new SqlParameter("CategoryId", SqlDbType.Int, 4, "CategoryId"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Update, UpdateQuery.Trim(), UpdateParams);

            const string InsertQuery = """
                INSERT INTO Categories (CategoryName)
                VALUES (@CategoryName);
                """;

            List<SqlParameter> InsertParams = new List<SqlParameter>()
            {
                new SqlParameter("CategoryName", SqlDbType.VarChar, 255, "CategoryName"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), InsertParams);

            const string DeleteQuery = """
                DELETE FROM Categories
                WHERE CategoryId = @CategoryId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Delete, DeleteQuery.Trim(), new List<SqlParameter>() { new SqlParameter("CategoryId", SqlDbType.Int, 4, "@CategoryId") });

            _AllCategoriesTable = GetCategories();
            _AllCategoriesTable.Columns["CategoryId"].AutoIncrement = true;
        }
        #endregion

        #region Methods
        public DataTable GetCategories()
        {
            DataTable Result = _DBContext.ExecuteSelect("SELECT * FROM Categories");
            return Result;
        }

        public void InsertCategory(CategoryRow NewRowData)
        {
            DataRow Row = _AllCategoriesTable.NewRow();

            try
            {
                Row["CategoryName"] = String.Copy(NewRowData.CategoryName);
                _AllCategoriesTable.Rows.Add(Row);
            }
            catch (Exception ex)
            {
                // TODO: Logging
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateCategory(int RowIndex, CategoryRow NewRowData)
        {
            if (!(RowIndex >= 0 && RowIndex <= _AllCategoriesTable.Rows.Count))
            {
                // TODO: Logging
                throw new IndexOutOfRangeException("Row Index out of range!!");
            }
            DataRow SelectedRow = _AllCategoriesTable.Rows[RowIndex];

            SelectedRow["CategoryName"] = String.Copy(NewRowData.CategoryName);
        }

        public void DeleteCategory(int RowIndex)
        {
            DataRow SelectedRow = _AllCategoriesTable.Rows[RowIndex];
            SelectedRow.Delete();
        }

        public void SubmitCategoryChanges()
        {
            _DBContext.UploadToServer(_AllCategoriesTable);
        }
        #endregion
    }
}
