using System.Data;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct ProductRow
    {
        public int ProductId;
        public string ProductName;
        public decimal Price;
        public int CateogryId;
    }
    public class ProductsService
    {
        #region Private_Properties
        private SqlServerContext _DBContext;
        private DataTable _AllProductsTable;
        // All primary keys are identity, so this should work for what it is
        private int _ProductCount = 0;
        #endregion

        #region Constructors
        public ProductsService()
        {
            _DBContext = new SqlServerContext();

            const string UpdateQuery = """
                UPDATE Products
                SET
                ProductName = @ProductName,
                Price = @Price,
                Category = @CategoryId,
                WHERE ProductId = @ProductId;
                """;

            List<SqlParameter> UpdateParams = new List<SqlParameter>()
            {
                new SqlParameter("ProductId", SqlDbType.Int, sizeof(int), "ProductId"),
                new SqlParameter("ProductName", SqlDbType.VarChar, 255 * sizeof(char), "ProductName"),
                new SqlParameter("Price", SqlDbType.Decimal, sizeof(decimal), "Price"),
                new SqlParameter("CategoryId", SqlDbType.Decimal, sizeof(int), "CategoryId"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Update, UpdateQuery.Trim(), UpdateParams);

            const string InsertQuery = """
                INSERT INTO Products (ProductId, ProductName, Price, CategoryId)
                VALUES (@ProductId, @ProductName, @Price, CategoryId);
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), UpdateParams);

            const string DeleteQuery = """
                DELETE FROM Products
                WHERE ProductId = @ProductId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), new List<SqlParameter>() { new SqlParameter("ProductId", SqlDbType.Int, 4, "@ProductId") });

            _AllProductsTable = new DataTable();
        }
        #endregion

        #region Methods
        public void GetProducts()
        {
            _AllProductsTable = _DBContext.ExecuteSelect("SELECT * FROM Products");
            _ProductCount = _AllProductsTable.Rows.Count;
        }

        public void InsertProduct(ProductRow NewRowData)
        {
            DataRow Row = _AllProductsTable.NewRow();

            try
            {
                Row["ProductId"] = ++_ProductCount;
                Row["ProductName"] = String.Copy(NewRowData.ProductName);
                _AllProductsTable.Rows.Add(Row);
            }
            catch (Exception ex)
            {
                // TODO: Logging
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateProduct(int RowIndex, ProductRow NewRowData)
        {
            if (!(RowIndex >= 0 && RowIndex <= _AllProductsTable.Rows.Count))
            {
                // TODO: Logging
                throw new IndexOutOfRangeException("Row Index out of range!!");
            }
            DataRow SelectedRow = _AllProductsTable.Rows[RowIndex];

            SelectedRow["ProductName"] = String.Copy(NewRowData.ProductName);
        }

        public void DeleteProduct(int RowIndex)
        {
            DataRow SelectedRow = _AllProductsTable.Rows[RowIndex];
            SelectedRow.Delete();
        }
        #endregion
    }
}
