using System.Data;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct CategoryRow
    {
        public int CategoryId;
        public string CategoryName;
    }
    public class CategoriesService
    {
        #region Private_Properties
        private SqlServerContext _DBContext;
        private DataTable _AllCategoriesTable;
        // All primary keys are identity, so this should work for what it is
        private int _CategoryCount = 0;
        #endregion

        #region Constructors
        public CategoriesService()
        {
            _DBContext = new SqlServerContext();

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
                INSERT INTO Categories (CategoryId, CategoryName)
                VALUES (@CategoryId, @CategoryName);
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), UpdateParams);

            const string DeleteQuery = """
                DELETE FROM Categories
                WHERE CategoryId = @CategoryId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), new List<SqlParameter>() { new SqlParameter("CategoryId", SqlDbType.Int, 4, "@CategoryId") });

            _AllCategoriesTable = new DataTable();
        }
        #endregion

        #region Methods
        public void GetCategories()
        {
            _AllCategoriesTable = _DBContext.ExecuteSelect("SELECT * FROM CategoryS");
            _CategoryCount = _AllCategoriesTable.Rows.Count;
        }

        public void InsertCategory(CategoryRow NewRowData)
        {
            DataRow Row = _AllCategoriesTable.NewRow();

            try
            {
                Row["CategoryId"] = ++_CategoryCount;
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

            SelectedRow["Categoryname"] = String.Copy(NewRowData.CategoryName);
        }

        public void DeleteCategory(int RowIndex)
        {
            DataRow SelectedRow = _AllCategoriesTable.Rows[RowIndex];
            SelectedRow.Delete();
        }
        #endregion
    }
}
