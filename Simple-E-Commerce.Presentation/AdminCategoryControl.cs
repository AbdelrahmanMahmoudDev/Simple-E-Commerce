using System.Data;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminCategoryControl : Form
    {
        IDBContext _Context;
        CategoriesService _CategoriesService;
        DataTable _ViewTable;
        int _SelectedRow;
        public frm_AdminCategoryControl(IDBContext Context)
        {
            InitializeComponent();
            _Context = Context;
            _CategoriesService = new CategoriesService(_Context);
            _ViewTable = CategoriesService.AllCategoriesTable.Copy();
            dgv_AdminCatTable.DataSource = _ViewTable;
        }

        private void frm_AdminCategoryControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.AdminScreen.Show();
        }

        private void btn_AdminCatViewRegAdd_Click(object sender, EventArgs e)
        {
            _CategoriesService.InsertCategory(new CategoryRow { CategoryName = tb_AdminCatViewCatNane.Text });
            _ViewTable = CategoriesService.AllCategoriesTable.Copy();
            dgv_AdminCatTable.DataSource = _ViewTable;
        }

        private void btn_AdminCatViewRegRemove_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminCatTable.Rows[_SelectedRow].Cells["CategoryId"].Value;
            _CategoriesService.DeleteCategory(PrimaryKey);
            _ViewTable = CategoriesService.AllCategoriesTable.Copy();
            dgv_AdminCatTable.DataSource = _ViewTable;
        }

        private void btn_AdminCatViewRegUpdate_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminCatTable.Rows[_SelectedRow].Cells["CategoryId"].Value;
            _CategoriesService.UpdateCategory(new CategoryRow() { CategoryName = tb_AdminCatViewCatNane.Text }, PrimaryKey);
            _ViewTable = CategoriesService.AllCategoriesTable.Copy();
            dgv_AdminCatTable.DataSource = _ViewTable;
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
                if (_SelectedRow >= 0 && _SelectedRow < CategoriesService.AllCategoriesTable.Rows.Count)
                {
                    DataRow SelectedRow = CategoriesService.AllCategoriesTable.Rows[e.RowIndex];
                    tb_AdminCatViewCatNane.Text = SelectedRow["CategoryName"].ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
