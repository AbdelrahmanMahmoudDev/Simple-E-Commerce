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

    public class SqlServerContext : IDBContext<DataTable, int>
    {
        private SqlDataAdapter _DisconnectedDataAdapter;
        public SqlServerContext()
        {
            DBContextHelper.Init();
            _DisconnectedDataAdapter = new SqlDataAdapter();
        }
        public DataTable ExecuteSelect(string Query)
        {
            DataTable Result = new DataTable();
            using (SqlConnection Connection = new   SqlConnection(DBContextHelper.ConnectionString))
            {

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    _DisconnectedDataAdapter.SelectCommand = Command;
                    try
                    {
                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            Result.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // TODO: Logger
                        Debug.WriteLine(ex);
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
            }
            return Result;
        }
        public DataTable ExecuteSelect<SqlParameter>(string Query, params List<SqlParameter> ParamList)
        {
            DataTable Result = new DataTable();
            using (SqlConnection Connection = new SqlConnection(DBContextHelper.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    foreach (SqlParameter Param in ParamList)
                    {
                        Command.Parameters.Add(Param);
                    }
                    _DisconnectedDataAdapter.SelectCommand = Command;
                    try
                    {
                        Connection.Open();

                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            Result.Load(Reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        // TODO: Logger
                        Debug.WriteLine(ex);
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
            }
            return Result;
        }
        public void ExecuteNonSelect(DMLType Type, string Query)
        {
            using (SqlConnection Connection = new SqlConnection(DBContextHelper.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    switch(Type)
                    {
                        case DMLType.Insert:
                            {
                                _DisconnectedDataAdapter.InsertCommand = Command;
                            } break;
                        case DMLType.Update:
                            {
                                _DisconnectedDataAdapter.UpdateCommand = Command;
                            } break;
                        case DMLType.Delete:
                            {
                                _DisconnectedDataAdapter.DeleteCommand = Command;
                            } break;
                    }
                }
            }
        }
        public void ExecuteNonSelect<SqlParameter>(DMLType Type, string Query, params List<SqlParameter> ParamList)
        {
            using (SqlConnection Connection = new SqlConnection(DBContextHelper.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.CommandType = CommandType.Text;
                    foreach (SqlParameter Param in ParamList)
                    {
                        Command.Parameters.Add(Param);
                    }
                    switch (Type)
                    {
                        case DMLType.Insert:
                            {
                                _DisconnectedDataAdapter.InsertCommand = Command;
                            }
                            break;
                        case DMLType.Update:
                            {
                                _DisconnectedDataAdapter.UpdateCommand = Command;
                            }
                            break;
                        case DMLType.Delete:
                            {
                                _DisconnectedDataAdapter.DeleteCommand = Command;
                            }
                            break;
                    }
                }
            }
        }
        public void UploadToServer(DataTable DataContainer)
        {
            try
            {
                int r = _DisconnectedDataAdapter.Update(DataContainer);
                if (r == 0) throw new Exception("No rows were updated!");
            }
            catch (Exception ex)
            {
                // TODO: Logger
                Debug.WriteLine(ex);
            }
        }
    }
}
