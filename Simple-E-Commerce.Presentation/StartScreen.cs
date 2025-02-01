using System.Data;
using System.Runtime.CompilerServices;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_StartScreen : Form
    {
        UsersService _UsersService;
        IDBContext _IDBContext;
        public frm_StartScreen(IDBContext Context)
        {
            InitializeComponent();
            _IDBContext = Context;
            _UsersService = new UsersService(_IDBContext);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Result = _UsersService.VerifyUser(tb_Username.Text, tb_Password.Text);
            if(Result != string.Empty)
            {
                MessageBox.Show($"{Result}");
                tb_Username.Text = string.Empty;
                tb_Password.Text = string.Empty;
            }
            else
            {
                if(_UsersService.IsUserAdmin(tb_Username.Text))
                {
                    PresentationHelper.AdminScreen.Show();
                    Hide();
                }
                else
                {
                    PresentationHelper.CustomerScreen.Show();
                    Hide();
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            PresentationHelper.RegisterScreen.ShowDialog();

        }
    }
}
