using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.DataAccess
{
    public static class DBContextHelper
    {
        static private IConfigurationRoot _Configuration;
        static public string ConnectionString;
        static public IDBContext Init()
        {
            string SolutionDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "appsettings.json");
            
            _Configuration = new ConfigurationBuilder()
            .AddJsonFile(SolutionDirectory)
            .Build();

            ConnectionString = _Configuration.GetSection("constr").Value;

            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new InvalidOperationException("Connection string is not set in appsettings.json.");
            }

            return new SqlServerContext();
        }
    }
}
