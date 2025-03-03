using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess;
using Simple_E_Commerce.DataAccess.DBContext;
using Simple_E_Commerce.BusinessLogic;
using System.Diagnostics;

namespace Simple_E_Commerce.Presentation
{
   
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlServerContext CurrentDBContext = (SqlServerContext)DBContextHelper.Init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            PresentationHelper.Init(CurrentDBContext);
            Application.Run(PresentationHelper.StartScreen);
        }
    }
}