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
            string PasswordInput = tb_Password.Text;

            if(!_UsersService.SearchUsernames(tb_Username.Text, out string Result))
            {
                MessageBox.Show($"{Result}");
                tb_Username.Text = string.Empty;
                tb_Password.Text = string.Empty;
            }

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_RegisterScreen RegisterScreen = new frm_RegisterScreen(_IDBContext);
            RegisterScreen.ShowDialog();

        }
    }
}
