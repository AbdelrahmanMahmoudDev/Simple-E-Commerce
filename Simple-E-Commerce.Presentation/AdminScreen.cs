using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminScreen : Form
    {
        IDBContext _Context;
        UsersService _UsersService;
        public frm_AdminScreen(IDBContext Context)
        {
            _Context = Context;
            _UsersService = new UsersService(_Context);
            InitializeComponent();
        }
        private void frm_AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            PresentationHelper.StartScreen = new frm_StartScreen(_Context);
            PresentationHelper.StartScreen.Show();
            Hide();
        }

        private void btn_AdminUserView_Click(object sender, EventArgs e)
        {
            PresentationHelper.AdminUserControl = new frm_AdminUserControl(_Context);
            PresentationHelper.AdminUserControl.Show();
            Hide();
        }

        private void btn_AdminCategoryView_Click(object sender, EventArgs e)
        {
            PresentationHelper.AdminCategoryControl = new frm_AdminCategoryControl(_Context);
            PresentationHelper.AdminCategoryControl.Show();
            Hide();
        }

        private void btn_AdminProductView_Click(object sender, EventArgs e)
        {
            PresentationHelper.AdminProductControl = new frm_AdminProductControl(_Context);
            PresentationHelper.AdminProductControl.Show();
            Hide();
        }
    }
}
