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
    public partial class frm_AdminCategoryControl : Form
    {
        IDBContext _Context;
        public frm_AdminCategoryControl(IDBContext Context)
        {
            _Context = Context;
            InitializeComponent();
        }

        private void frm_AdminCategoryControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.AdminScreen.Show();
        }
    }
}
