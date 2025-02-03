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
    public partial class frm_AdminCategoryControl : Form
    {
        IDBContext _Context;
        CategoriesService _CategoriesService;
        int _SelectedRow;
        public frm_AdminCategoryControl(IDBContext Context)
        {
            _Context = Context;
            _CategoriesService = new CategoriesService(_Context);
            InitializeComponent();
            dgv_AdminCatTable.DataSource = _CategoriesService.GetCategories();
        }

        private void frm_AdminCategoryControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.AdminScreen.Show();
        }

        private void btn_AdminCatViewRegAdd_Click(object sender, EventArgs e)
        {
            _CategoriesService.InsertCategory(new CategoryRow { CategoryName = tb_AdminCatViewCatNane.Text });
            dgv_AdminCatTable.DataSource = CategoriesService.AllCategoriesTable;
        }

        private void btn_AdminCatViewRegRemove_Click(object sender, EventArgs e)
        {
            _CategoriesService.DeleteCategory(_SelectedRow);
            dgv_AdminCatTable.DataSource = CategoriesService.AllCategoriesTable;
        }

        private void btn_AdminCatViewRegUpdate_Click(object sender, EventArgs e)
        {
            _CategoriesService.UpdateCategory(_SelectedRow, new CategoryRow() { CategoryName = tb_AdminCatViewCatNane.Text});
            dgv_AdminCatTable.DataSource = CategoriesService.AllCategoriesTable;
        }

        private void btn_AdminCatViewRegSubmit_Click(object sender, EventArgs e)
        {
            _CategoriesService.SubmitCategoryChanges();
        }

        private void dgv_AdminCatTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _SelectedRow = e.RowIndex;
                DataRow SelectedRow = CategoriesService.AllCategoriesTable.Rows[e.RowIndex];
                tb_AdminCatViewCatNane.Text = SelectedRow["CategoryName"].ToString();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
