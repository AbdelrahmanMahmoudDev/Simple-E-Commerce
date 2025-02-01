using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminScreen : Form
    {
        IDBContext _Context;
        public frm_AdminScreen(IDBContext Context)
        {
            _Context = Context;
            InitializeComponent();
        }

        private void btn_AdminUserViewRegAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminUserViewRegRemove_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminUserViewRegUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btn_AdminUserViewRegSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frm_AdminScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.StartScreen.Show();
        }
    }
}
