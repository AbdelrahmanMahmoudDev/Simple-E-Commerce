using System.Data;
using System.Data.Common;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Simple_E_Commerce.DataAccess;

namespace Simple_E_Commerce.DataAccess.DBContext
{
    public enum DMLType
    {
        Insert, Update, Delete
    }
    public interface IDBContext
    {
        // Selects Execute in Connected Mode
        public DataTable ExecuteSelect(string Query);
        public DataTable ExecuteSelect(string Query, params List<SqlParameter> ParamList);
        // DML Queries execute in Disconnected Mode
        public void ExecuteNonSelect(DMLType Type, string Query, params List<SqlParameter> ParamList);
        public void UploadToServer(DataTable DataContainer);

        // DML Queries execute in Connected Mode
        public void ExecuteNonSelect(string Query, params List<SqlParameter> ParamList);
    }
}
