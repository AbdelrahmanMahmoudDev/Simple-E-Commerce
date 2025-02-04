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
    public partial class frm_UserScreen : Form
    {
        FavoritesService _FavoriteService;
        ProductsService _ProductsService;
        int SelectedProductId = -1;
        int SelectedFavoriteId = -1;
        public frm_UserScreen(IDBContext DBContext)
        {
            InitializeComponent();
            _FavoriteService = new FavoritesService(DBContext);
        }

        public frm_UserScreen(IDBContext DBContext, int TargetUserId)
        {
            InitializeComponent();
            _FavoriteService = new FavoritesService(DBContext, TargetUserId);
            _ProductsService = new ProductsService(DBContext);

            dgv_UserFavView.DataSource = FavoritesService.AllFavoritesWithProductNames;
            dgv_UserProductView.DataSource = ProductsService.AllProductsTable;
        }

        private void dgv_UserProductView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectedProductId = (int)dgv_UserProductView.Rows[e.RowIndex].Cells["ProductId"].Value;
        }

        private void dgv_UserFavView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            SelectedFavoriteId = (int)dgv_UserFavView.Rows[e.RowIndex].Cells["ProductId"].Value;
        }

        private void btn_AddtoFav_Click(object sender, EventArgs e)
        {
            if (SelectedProductId != -1)
            {
                _FavoriteService.InsertFavorite(SelectedProductId);
                dgv_UserFavView.DataSource = FavoritesService.AllFavoritesWithProductNames;

            }
        }

        private void btn_RemovefromFav_Click(object sender, EventArgs e)
        {
            if (SelectedFavoriteId != -1)
            {
                _FavoriteService.DeleteFavorite(SelectedFavoriteId);
                dgv_UserFavView.DataSource = FavoritesService.AllFavoritesWithProductNames;
            }
        }

        private void frm_UserScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            PresentationHelper.StartScreen.Show();
        }
    }
}
