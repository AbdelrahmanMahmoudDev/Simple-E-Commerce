using System.Data;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminUserControl : Form
    {
        IDBContext _Context;
        UsersService _UsersService;
        DataTable _ViewTable;
        int _SelectedRow; // needed to grab selected data
        public frm_AdminUserControl(IDBContext Context)
        {
            InitializeComponent();
            _Context = Context;
            _UsersService = new UsersService(_Context);
            _ViewTable = UsersService.AllUsersTable.Copy();

            dgv_AdminUserTable.DataSource = _ViewTable;
            dgv_AdminUserTable.Columns["UserId"].Visible = false;
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
            _ViewTable = UsersService.AllUsersTable.Copy();
            dgv_AdminUserTable.DataSource = _ViewTable;
        }

        private void btn_AdminUserViewRegRemove_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminUserTable.Rows[_SelectedRow].Cells["UserId"].Value;
            _UsersService.DeleteUser(PrimaryKey);
            _ViewTable = UsersService.AllUsersTable.Copy();
            _ViewTable.Rows.RemoveAt(_SelectedRow);
            dgv_AdminUserTable.DataSource = _ViewTable;
        }

        private void btn_AdminUserViewRegUpdate_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminUserTable.Rows[_SelectedRow].Cells["UserId"].Value;
            UserRow NewRow = new UserRow()
            {
                Username = tb_AdminUserViewRegUsername.Text,
                Password = tb_AdminUserViewRegPassword.Text == "" ? "1234" : tb_AdminUserViewRegPassword.Text,
                Email = tb_AdminUserViewRegEmail.Text,
                Age = (int)nud_AdminUserViewRegAge.Value,
                Address = tb_AdminUserViewRegAddress.Text,
                IsAdmin = rb_AdminUserViewRegOptAdmin.Checked
            };
            _UsersService.UpdateUser(NewRow, PrimaryKey);
            _ViewTable = UsersService.AllUsersTable.Copy();
            dgv_AdminUserTable.DataSource = _ViewTable;
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
                if (_SelectedRow >= 0 && _SelectedRow < dgv_AdminUserTable.Rows.Count - 1)
                {
                    tb_AdminUserViewRegUsername.Text = (string)dgv_AdminUserTable.Rows[_SelectedRow].Cells["Username"].Value;
                    tb_AdminUserViewRegPassword.Text = "";
                    tb_AdminUserViewRegEmail.Text = (string)dgv_AdminUserTable.Rows[_SelectedRow].Cells["Email"].Value;
                    nud_AdminUserViewRegAge.Value = (int)dgv_AdminUserTable.Rows[_SelectedRow].Cells["Age"].Value;
                    tb_AdminUserViewRegAddress.Text = (string)dgv_AdminUserTable.Rows[_SelectedRow].Cells["Address"].Value;
                    if ((bool)dgv_AdminUserTable.Rows[_SelectedRow].Cells["IsAdmin"].Value)
                    {
                        rb_AdminUserViewRegOptAdmin.Checked = true;
                    }
                    else
                    {
                        rb_AdminUserViewRegOptCustomer.Checked = true;
                    }
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
