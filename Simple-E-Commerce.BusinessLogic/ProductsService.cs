using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.BusinessLogic
{
    public struct ProductRow
    {
        public string ProductName;
        public decimal Price;
        public int CateogryId;
    }
    public class ProductsService
    {
        #region Private_Properties
        private static DataTable _AllProductsTable;
        public static DataTable AllProductsTable { get => _AllProductsTable; }
        private static DataTable _AllProductsWithCategoryNames;
        public static DataTable AllProductsWithCategoryNames { get => _AllProductsWithCategoryNames; }
        private IDBContext _DBContext;
        #endregion

        #region Constructors
        public ProductsService(IDBContext Context)
        {
            _DBContext = Context;

            const string UpdateQuery = """
                UPDATE Products
                SET
                ProductName = @ProductName,
                Price = @Price,
                CategoryId = @CategoryId
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
                INSERT INTO Products (ProductName, Price, CategoryId)
                VALUES (@ProductName, @Price, @CategoryId);
                """;

            List<SqlParameter> InsertParams = new List<SqlParameter>()
            {
                new SqlParameter("ProductName", SqlDbType.VarChar, 255 * sizeof(char), "ProductName"),
                new SqlParameter("Price", SqlDbType.Decimal, sizeof(decimal), "Price"),
                new SqlParameter("CategoryId", SqlDbType.Decimal, sizeof(int), "CategoryId"),
            };

            _DBContext.ExecuteNonSelect(DMLType.Insert, InsertQuery.Trim(), InsertParams);

            const string DeleteQuery = """
                DELETE FROM Products
                WHERE ProductId = @ProductId;
                """;
            _DBContext.ExecuteNonSelect(DMLType.Delete, DeleteQuery.Trim(), new List<SqlParameter>() { new SqlParameter("ProductId", SqlDbType.Int, 4, "ProductId") });

            _AllProductsTable = GetProducts();
            _AllProductsTable.Columns["ProductId"].AutoIncrement = true;

            _AllProductsWithCategoryNames = GetProductWithCategoryName();
            _AllProductsWithCategoryNames.Columns["ProductId"].AutoIncrement = true;

        }
        #endregion

        #region Methods
        public DataTable GetProductWithCategoryName()
        {
            DataTable Result = _DBContext.ExecuteSelect("""
                SELECT Products.ProductId, Products.ProductName, Products.Price, Categories.CategoryId, Categories.CategoryName
                FROM Products
                INNER JOIN Categories ON Products.CategoryId = Categories.CategoryId
                """);
            return Result;
        }
        public DataTable GetProducts()
        {
            DataTable Result = _DBContext.ExecuteSelect("SELECT * FROM Products");
            return Result;
        }

        public void InsertProduct(ProductRow NewRowData)
        {
            DataRow Row = _AllProductsTable.NewRow();

            try
            {
                Row["ProductName"] = String.Copy(NewRowData.ProductName);
                Row["Price"] = NewRowData.Price;
                Row["CategoryId"] = NewRowData.CateogryId;
                _AllProductsTable.Rows.Add(Row);
            }
            catch (Exception ex)
            {
                // TODO: Logging
                Console.WriteLine(ex.Message);
            }
            DataRow DispTableRow = _AllProductsWithCategoryNames.NewRow();
            try
            {
                DispTableRow["ProductName"] = String.Copy(NewRowData.ProductName);
                DispTableRow["Price"] = NewRowData.Price;
                DispTableRow["CategoryId"] = NewRowData.CateogryId;
                DataRow categoryRow = _DBContext.ExecuteSelect("SELECT CategoryName FROM Categories WHERE CategoryId = @CategoryId",
                     new SqlParameter()
                     {
                         ParameterName = "@CategoryId",
                         SqlDbType = System.Data.SqlDbType.Int,
                         Direction = System.Data.ParameterDirection.Input,
                         Value = NewRowData.CateogryId,
                     }).Rows[0];
                DispTableRow["CategoryName"] = categoryRow["CategoryName"];
                _AllProductsWithCategoryNames.Rows.Add(DispTableRow);
            }
            catch (Exception ex)
            {
            }
        }

        public void UpdateProduct(int PrimaryKey, ProductRow NewRowData)
        {
            int TargetTableIndex = -1;
            Debug.Assert(_AllProductsTable.Rows.Count > 0);
            for (int i = 0; i < _AllProductsTable.Rows.Count; i++)
            {
                if ((int)_AllProductsTable.Rows[i]["ProductId"] == PrimaryKey && _AllProductsTable.Rows[i].RowState != DataRowState.Deleted)
                {
                    TargetTableIndex = i;
                    break;
                }
            }
            Debug.Assert(TargetTableIndex != -1, "Primary Key not found in the table");
            DataRow SelectedRow = _AllProductsTable.Rows[TargetTableIndex];

            SelectedRow["ProductName"] = String.Copy(NewRowData.ProductName);
            SelectedRow["Price"] = NewRowData.Price;
            SelectedRow["CategoryId"] = NewRowData.CateogryId;
            _AllProductsWithCategoryNames.Columns["CategoryId"].ReadOnly = false;
            DataRow DispTableRow = _AllProductsWithCategoryNames.Rows[TargetTableIndex];

            DispTableRow["ProductName"] = String.Copy(NewRowData.ProductName);
            DispTableRow["Price"] = NewRowData.Price;
            DispTableRow["CategoryId"] = NewRowData.CateogryId;
            DataRow categoryRow = _DBContext.ExecuteSelect("SELECT CategoryName FROM Categories WHERE CategoryId = @CategoryId",
            new SqlParameter()
            {
                ParameterName = "@CategoryId",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
                Value = NewRowData.CateogryId,
            }).Rows[0];
                   DispTableRow["CategoryName"] = categoryRow["CategoryName"];
            _AllProductsWithCategoryNames.Columns["CategoryId"].ReadOnly = true;

        }

        public void DeleteProduct(int PrimaryKey)
        {
            for(int i = 0; i < _AllProductsTable.Rows.Count; i++)
            {
                if ((int)_AllProductsTable.Rows[i]["ProductId"] == PrimaryKey)
                {
                    _AllProductsTable.Rows[i].Delete();
                    _AllProductsWithCategoryNames.Rows[i].Delete();
                    break;
                }
            }
        }

        public void SubmitProductChanges()
        {
            _DBContext.UploadToServer(_AllProductsTable);
        }
        #endregion
    }
}
