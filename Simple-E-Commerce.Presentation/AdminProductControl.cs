using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simple_E_Commerce.BusinessLogic;
using Simple_E_Commerce.DataAccess.DBContext;

namespace Simple_E_Commerce.Presentation
{
    public partial class frm_AdminProductControl : Form
    {
        IDBContext _Context;
        CategoriesService _CategoriesService;
        ProductsService _ProductsService;
        int _SelectedRow; // needed to grab selected data
        public frm_AdminProductControl(IDBContext Context)
        {
            InitializeComponent();
            _Context = Context;
            _CategoriesService = new CategoriesService(_Context);
            _ProductsService = new ProductsService(_Context);

            dgv_AdminProdTable.DataSource = _ProductsService.GetProductWithCategoryName();
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
            dgv_AdminProdTable.DataSource = ProductsService.AllProductsWithCategoryNames;
        }

        private void btn_AdminProdViewRegRemove_Click(object sender, EventArgs e)
        {
            ProductRow NewRow = new ProductRow()
            {
                ProductName = tb_AdminProdViewProdNane.Text,
                Price = nud_AdminProdViewPrice.Value,
                CateogryId = Convert.ToInt32(cb_AdminProdViewCategory.SelectedValue),
            };
            _ProductsService.DeleteProduct(_SelectedRow);
            dgv_AdminProdTable.DataSource = ProductsService.AllProductsWithCategoryNames;

        }

        private void btn_AdminProdViewRegUpdate_Click(object sender, EventArgs e)
        {
            ProductRow NewRow = new ProductRow()
            {
                ProductName = tb_AdminProdViewProdNane.Text,
                Price = nud_AdminProdViewPrice.Value,
                CateogryId = Convert.ToInt32(cb_AdminProdViewCategory.SelectedValue),
            };
            _ProductsService.UpdateProduct(_SelectedRow, NewRow);
            dgv_AdminProdTable.DataSource = ProductsService.AllProductsWithCategoryNames;

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
                Debug.WriteLine(_SelectedRow);
                DataRow SelectedRow = ProductsService.AllProductsTable.Rows[_SelectedRow];
                if ((SelectedRow.RowState == DataRowState.Deleted))
                {
                    SelectedRow = ProductsService.AllProductsTable.Rows[_SelectedRow - 1];
                }
                tb_AdminProdViewProdNane.Text = SelectedRow["ProductName"].ToString();
                nud_AdminProdViewPrice.Value = (decimal)SelectedRow["Price"];
                cb_AdminProdViewCategory.SelectedValue = (int)SelectedRow["CategoryId"];
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
