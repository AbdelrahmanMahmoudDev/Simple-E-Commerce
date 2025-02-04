using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess.DBContext;
using System.Data;
using System.Diagnostics;

namespace Simple_E_Commerce.BusinessLogic
{
    public class FavoritesService
    {
        #region Private_Properties
        private int TargetUserd = -1;
        private static DataTable _AllFavoritesTable;
        public static DataTable AllFavoritesTable { get => _AllFavoritesTable; }
        private static DataTable _AllFavoritesWithProductNames;
        public static DataTable AllFavoritesWithProductNames { get => _AllFavoritesWithProductNames; }
        private IDBContext _DBContext;
        #endregion
        #region Constructors
        public FavoritesService(IDBContext Context)
        {
            _DBContext = Context;
            _AllFavoritesTable = GetFavorites();
            _AllFavoritesWithProductNames = GetFavoritesWithProductNames();
        }
        public FavoritesService(IDBContext Context, int TargetUserId)
        {
            _DBContext = Context;
            TargetUserd = TargetUserId;
            _AllFavoritesTable = GetFavorites();
            _AllFavoritesWithProductNames = GetFavoritesWithProductNames();
        }
        #endregion
        #region Methods
        public DataTable GetFavorites()
        {
            return _DBContext.ExecuteSelect("SELECT * FROM FAVORITES;");
        }
        public DataTable GetFavoritesWithProductNames()
        {
            const string Query = """
                   select Products.ProductId, Products.ProductName, Products.Price, Categories.CategoryId ,Categories.CategoryName 
                    from Favorites
                    join Products on Products.ProductId = Favorites.ProductId
                    join Categories on Categories.CategoryId = Products.CategoryId
                    where Favorites.UserId = @UserId;
                """;
            return _DBContext.ExecuteSelect(Query, new List<SqlParameter> { new SqlParameter() { ParameterName = "@UserId", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Input, Value = TargetUserd } });
        }
        public void InsertFavorite(int ProductId)
        {
            const string InsertQuery = """
                INSERT INTO FAVORITES (UserId, ProductId)
                VALUES (@UserId, @ProductId);
                """;
            List<SqlParameter> InsertParams = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@UserId",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = TargetUserd,
                },
                new SqlParameter()
                {
                    ParameterName = "@ProductId",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = ProductId,
                },
            };

            try
            {
                _DBContext.ExecuteNonSelect(InsertQuery.Trim(), InsertParams);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
            try
            {

                _AllFavoritesWithProductNames = GetFavoritesWithProductNames();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }
        public void DeleteFavorite(int ProductId)
        {
            const string DeleteQuery = """
                DELETE FROM FAVORITES
                WHERE UserId = @UserId AND ProductId = @ProductId;
                """;
            List<SqlParameter> DeleteParams = new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@UserId",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = TargetUserd,
                },
                new SqlParameter()
                {
                    ParameterName = "@ProductId",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = ProductId,
                },
            };
            try
            {
                _DBContext.ExecuteNonSelect(DeleteQuery.Trim(), DeleteParams);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
            try
            {
                _AllFavoritesWithProductNames = GetFavoritesWithProductNames();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, ex.StackTrace);
            }
        }
        #endregion
    }
}
