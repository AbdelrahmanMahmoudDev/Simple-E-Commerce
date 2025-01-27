using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Simple_E_Commerce.DataAccess
{
    internal static class DBContextHelper
    {
        static private IConfigurationRoot _Configuration;
        static public string ConnectionString;
        static public void Init()
        {
            string SolutionDirectory = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,"appsettings.json");

            _Configuration = new ConfigurationBuilder()
            .AddJsonFile(SolutionDirectory)
            .Build();

            ConnectionString = _Configuration.GetSection("constr").Value;
        }
    }
}
