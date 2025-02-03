using System.Data;
using System.Diagnostics;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminProductControl : Form
    {
        IDBContext _Context;
        CategoriesService _CategoriesService;
        ProductsService _ProductsService;
        DataTable _ViewTable;
        int _SelectedRow; // needed to grab selected data
        public frm_AdminProductControl(IDBContext Context)
        {
            InitializeComponent();
            _Context = Context;
            _CategoriesService = new CategoriesService(_Context);
            _ProductsService = new ProductsService(_Context);

            _ViewTable = ProductsService.AllProductsWithCategoryNames.Copy();
            dgv_AdminProdTable.DataSource = _ViewTable;
            dgv_AdminProdTable.Columns["ProductId"].Visible = false;
            dgv_AdminProdTable.Columns["CategoryId"].Visible = false;

            cb_AdminProdViewCategory.DataSource = _CategoriesService.GetCategories();
            cb_AdminProdViewCategory.DisplayMember = "CategoryName";
            cb_AdminProdViewCategory.ValueMember = "CategoryId";
        }

        private void btn_AdminProdViewRegAdd_Click(object sender, EventArgs e)
        {
            ProductRow NewRow = new ProductRow()
            {
                ProductName = tb_AdminProdViewProdNane.Text,
                Price = nud_AdminProdViewPrice.Value,
                CateogryId = Convert.ToInt32(cb_AdminProdViewCategory.SelectedValue),
            };
            _ProductsService.InsertProduct(NewRow);
            _ViewTable = ProductsService.AllProductsWithCategoryNames.Copy();
            dgv_AdminProdTable.DataSource = _ViewTable;
        }

        private void btn_AdminProdViewRegRemove_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminProdTable.Rows[_SelectedRow].Cells["ProductId"].Value;
            _ProductsService.DeleteProduct(PrimaryKey);
            _ViewTable = ProductsService.AllProductsWithCategoryNames.Copy();
            _ViewTable.Rows.RemoveAt(_SelectedRow);
            dgv_AdminProdTable.DataSource = _ViewTable;
        }

        private void btn_AdminProdViewRegUpdate_Click(object sender, EventArgs e)
        {
            int PrimaryKey = (int)dgv_AdminProdTable.Rows[_SelectedRow].Cells["ProductId"].Value;

            ProductRow NewRow = new ProductRow()
            {
                ProductName = tb_AdminProdViewProdNane.Text,
                Price = nud_AdminProdViewPrice.Value,
                CateogryId = Convert.ToInt32(cb_AdminProdViewCategory.SelectedValue),
            };
            _ProductsService.UpdateProduct(PrimaryKey, NewRow);
            _ViewTable = ProductsService.AllProductsWithCategoryNames.Copy();
            dgv_AdminProdTable.DataSource = _ViewTable;
        }

        private void btn_AdminProdViewRegSubmit_Click(object sender, EventArgs e)
        {
            _ProductsService.SubmitProductChanges();
        }

        private void dgv_AdminProdTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _SelectedRow = e.RowIndex;
                if(_SelectedRow >= 0 && _SelectedRow < dgv_AdminProdTable.Rows.Count - 1)
                {
                    tb_AdminProdViewProdNane.Text = (string)dgv_AdminProdTable.Rows[_SelectedRow].Cells["ProductName"].Value;
                    nud_AdminProdViewPrice.Value = (decimal)dgv_AdminProdTable.Rows[_SelectedRow].Cells["Price"].Value;
                    cb_AdminProdViewCategory.SelectedValue = (int)dgv_AdminProdTable.Rows[_SelectedRow].Cells["CategoryId"].Value;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void frm_AdminProductControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            PresentationHelper.AdminScreen.Show();
            Hide();
        }
    }
}
