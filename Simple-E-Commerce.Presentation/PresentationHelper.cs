using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    internal class PresentationHelper
    {
        public static frm_StartScreen StartScreen;
        public static frm_AdminScreen AdminScreen;
        public static frm_RegisterScreen RegisterScreen;
        public static frm_CustomerScreen CustomerScreen;

        public static void Init(IDBContext Context)
        {
            StartScreen = new frm_StartScreen(Context);
            AdminScreen = new frm_AdminScreen(Context);
            RegisterScreen = new frm_RegisterScreen(Context);
            CustomerScreen = new frm_CustomerScreen(Context);
        }
    }
}
