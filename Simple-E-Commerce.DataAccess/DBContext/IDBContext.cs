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
    internal interface IDBContext<T, K>
    {
        // Selects Execute in Connected Mode
        public T ExecuteSelect(string Query);
        public T ExecuteSelect<U>(string Query, params List<U> ParamList);

        // DML Queries execute in Disconnected Mode
        public void ExecuteNonSelect(DMLType Type, string Query);
        public void ExecuteNonSelect<U>(DMLType Type, string Query, params List<U> ParamList);
        public void UploadToServer(T DataContainer);
    }
}
