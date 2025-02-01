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
    public partial class frm_RegisterScreen : Form
    {
        UsersService _UsersService;
        public frm_RegisterScreen(IDBContext Context)
        {
            InitializeComponent();
            _UsersService = new UsersService(Context);
        }

        private bool ValidateInput()
        {
            return (tb_RegUsername.Text.Trim() != String.Empty &&
                tb_RegPassword.Text.Trim() != String.Empty &&
                tb_RegEmail.Text.Trim() != String.Empty);
        }

        private void btn_RegRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Please enter all required Fields!");
            }

            UserRow NewDataRow = new UserRow()
            {
                Username = tb_RegUsername.Text,
                Password = tb_RegPassword.Text,
                Email = tb_RegEmail.Text,
                Age = (int)nud_RegAge.Value,
                Address = tb_RegAddress.Text,
                IsAdmin = rb_RegOptAdmin.Checked
            };

            _UsersService.InsertUser(NewDataRow);
            _UsersService.SubmitUserUpdates();
            this.Close();
        }
    }
}
