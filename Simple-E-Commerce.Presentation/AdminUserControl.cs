using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminUserControl : Form
    {
        IDBContext _Context;
        UsersService _UsersService;
        int _SelectedRow; // needed to grab selected data
        public frm_AdminUserControl(IDBContext Context)
        {
            _Context = Context;
            _UsersService = new UsersService(_Context);

            InitializeComponent();

            dgv_AdminUserTable.DataSource = _UsersService.GetAllUsers();
        }

        private void btn_AdminUserViewRegAdd_Click(object sender, EventArgs e)
        {
            UserRow NewRow = new UserRow()
            {
                Username = tb_AdminUserViewRegUsername.Text,
                Password = tb_AdminUserViewRegPassword.Text,
                Email = tb_AdminUserViewRegEmail.Text,
                Age = (int)nud_AdminUserViewRegAge.Value,
                Address = tb_AdminUserViewRegAddress.Text,
                IsAdmin = rb_AdminUserViewRegOptAdmin.Checked
            };
            _UsersService.InsertUser(NewRow);
            dgv_AdminUserTable.DataSource = UsersService.AllUsersTable;
        }

        private void btn_AdminUserViewRegRemove_Click(object sender, EventArgs e)
        {
            _UsersService.DeleteUser(_SelectedRow);
            dgv_AdminUserTable.DataSource = UsersService.AllUsersTable;
        }

        private void btn_AdminUserViewRegUpdate_Click(object sender, EventArgs e)
        {
            UserRow NewRow = new UserRow()
            {
                Username = tb_AdminUserViewRegUsername.Text,
                Password = tb_AdminUserViewRegPassword.Text == "" ? "1234" : tb_AdminUserViewRegPassword.Text,
                Email = tb_AdminUserViewRegEmail.Text,
                Age = (int)nud_AdminUserViewRegAge.Value,
                Address = tb_AdminUserViewRegAddress.Text,
                IsAdmin = rb_AdminUserViewRegOptAdmin.Checked
            };
            _UsersService.UpdateUser(_SelectedRow, NewRow);
            dgv_AdminUserTable.DataSource = UsersService.AllUsersTable;
        }

        private void frm_AdminUserControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.AdminScreen.Show();
        }

        private void dgv_AdminUserTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _SelectedRow = e.RowIndex;
                DataRow SelectedRow = UsersService.AllUsersTable.Rows[e.RowIndex];
                tb_AdminUserViewRegUsername.Text = SelectedRow["Username"].ToString();
                tb_AdminUserViewRegPassword.Text = "";
                tb_AdminUserViewRegEmail.Text = SelectedRow["Email"].ToString();
                nud_AdminUserViewRegAge.Value = SelectedRow["Age"] == DBNull.Value ? 0 : (int)SelectedRow["Age"];
                tb_AdminUserViewRegAddress.Text = SelectedRow["Address"] == DBNull.Value ? string.Empty : SelectedRow["Address"].ToString();

                if ((bool)SelectedRow["IsAdmin"])
                {
                    rb_AdminUserViewRegOptAdmin.Checked = true;
                }
                else
                {
                    rb_AdminUserViewRegOptCustomer.Checked = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_AdminUserViewRegSubmit_Click(object sender, EventArgs e)
        {
            _UsersService.SubmitUserUpdates();
        }
    }
}
