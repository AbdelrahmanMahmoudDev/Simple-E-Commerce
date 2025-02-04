using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_StartScreen : Form
    {
        UsersService _UsersService;
        int TargetUserId = -1;
        IDBContext _IDBContext;
        public frm_StartScreen(IDBContext Context)
        {
            InitializeComponent();
            _IDBContext = Context;
            _UsersService = new UsersService(_IDBContext);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            (bool isVerified, DataTable ThisUserTable) = _UsersService.VerifyUser(tb_Username.Text, tb_Password.Text, out string ErrorResult);
            if (!isVerified)
            {
                MessageBox.Show($"{ErrorResult}");
                tb_Username.Text = string.Empty;
                tb_Password.Text = string.Empty;
            }
            else
            {
                TargetUserId = (int)ThisUserTable.Rows[0]["UserId"];
                if (_UsersService.IsUserAdmin(tb_Username.Text))
                {
                    PresentationHelper.AdminScreen = new frm_AdminScreen(_IDBContext);
                    PresentationHelper.AdminScreen.Show();
                    Hide();
                }
                else
                {
                    PresentationHelper.UserScreen = new frm_UserScreen(_IDBContext, TargetUserId);
                    PresentationHelper.UserScreen.Show();
                    Hide();
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            PresentationHelper.RegisterScreen = new frm_RegisterScreen(_IDBContext);
            PresentationHelper.RegisterScreen.ShowDialog();
        }

        private void frm_StartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
