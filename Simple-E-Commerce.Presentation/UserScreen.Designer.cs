namespace Simple_E_Commerce.Presentation
{
    partial class frm_UserScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_UserProductView = new DataGridView();
            dgv_UserFavView = new DataGridView();
            lbl_UserProductView = new Label();
            lbl_UserFavView = new Label();
            btn_AddtoFav = new Button();
            btn_RemovefromFav = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_UserProductView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_UserFavView).BeginInit();
            SuspendLayout();
            // 
            // dgv_UserProductView
            // 
            dgv_UserProductView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UserProductView.Location = new Point(12, 50);
            dgv_UserProductView.Name = "dgv_UserProductView";
            dgv_UserProductView.RowHeadersWidth = 51;
            dgv_UserProductView.Size = new Size(609, 472);
            dgv_UserProductView.TabIndex = 0;
            dgv_UserProductView.RowEnter += dgv_UserProductView_RowEnter;
            // 
            // dgv_UserFavView
            // 
            dgv_UserFavView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UserFavView.Location = new Point(641, 50);
            dgv_UserFavView.Name = "dgv_UserFavView";
            dgv_UserFavView.RowHeadersWidth = 51;
            dgv_UserFavView.Size = new Size(609, 472);
            dgv_UserFavView.TabIndex = 1;
            dgv_UserFavView.RowEnter += dgv_UserFavView_RowEnter;
            // 
            // lbl_UserProductView
            // 
            lbl_UserProductView.AutoSize = true;
            lbl_UserProductView.Font = new Font("Bell MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserProductView.Location = new Point(12, 9);
            lbl_UserProductView.Name = "lbl_UserProductView";
            lbl_UserProductView.Size = new Size(117, 31);
            lbl_UserProductView.TabIndex = 2;
            lbl_UserProductView.Text = "Products";
            // 
            // lbl_UserFavView
            // 
            lbl_UserFavView.AutoSize = true;
            lbl_UserFavView.Font = new Font("Bell MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_UserFavView.Location = new Point(641, 9);
            lbl_UserFavView.Name = "lbl_UserFavView";
            lbl_UserFavView.Size = new Size(123, 31);
            lbl_UserFavView.TabIndex = 3;
            lbl_UserFavView.Text = "Favorites";
            // 
            // btn_AddtoFav
            // 
            btn_AddtoFav.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_AddtoFav.Location = new Point(211, 528);
            btn_AddtoFav.Name = "btn_AddtoFav";
            btn_AddtoFav.Size = new Size(226, 67);
            btn_AddtoFav.TabIndex = 4;
            btn_AddtoFav.Text = "Add to Favorites";
            btn_AddtoFav.UseVisualStyleBackColor = true;
            btn_AddtoFav.Click += btn_AddtoFav_Click;
            // 
            // btn_RemovefromFav
            // 
            btn_RemovefromFav.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_RemovefromFav.Location = new Point(846, 528);
            btn_RemovefromFav.Name = "btn_RemovefromFav";
            btn_RemovefromFav.Size = new Size(226, 67);
            btn_RemovefromFav.TabIndex = 5;
            btn_RemovefromFav.Text = "Remove from Favorites";
            btn_RemovefromFav.UseVisualStyleBackColor = true;
            btn_RemovefromFav.Click += btn_RemovefromFav_Click;
            // 
            // frm_UserScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_RemovefromFav);
            Controls.Add(btn_AddtoFav);
            Controls.Add(lbl_UserFavView);
            Controls.Add(lbl_UserProductView);
            Controls.Add(dgv_UserFavView);
            Controls.Add(dgv_UserProductView);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_UserScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_UserScreen_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgv_UserProductView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_UserFavView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_UserProductView;
        private DataGridView dgv_UserFavView;
        private Label lbl_UserProductView;
        private Label lbl_UserFavView;
        private Button btn_AddtoFav;
        private Button btn_RemovefromFav;
    }
}