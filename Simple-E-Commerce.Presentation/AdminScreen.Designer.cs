namespace Simple_E_Commerce.Presentation
{
    partial class frm_AdminScreen
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
            btn_AdminProductView = new Button();
            btn_AdminCategoryView = new Button();
            btn_AdminUserView = new Button();
            SuspendLayout();
            // 
            // btn_AdminProductView
            // 
            btn_AdminProductView.Location = new Point(963, 304);
            btn_AdminProductView.Name = "btn_AdminProductView";
            btn_AdminProductView.Size = new Size(287, 76);
            btn_AdminProductView.TabIndex = 2;
            btn_AdminProductView.Text = "Products";
            btn_AdminProductView.UseVisualStyleBackColor = true;
            // 
            // btn_AdminCategoryView
            // 
            btn_AdminCategoryView.Location = new Point(489, 306);
            btn_AdminCategoryView.Name = "btn_AdminCategoryView";
            btn_AdminCategoryView.Size = new Size(287, 76);
            btn_AdminCategoryView.TabIndex = 1;
            btn_AdminCategoryView.Text = "Categories";
            btn_AdminCategoryView.UseVisualStyleBackColor = true;
            btn_AdminCategoryView.Click += btn_AdminCategoryView_Click;
            // 
            // btn_AdminUserView
            // 
            btn_AdminUserView.Location = new Point(12, 306);
            btn_AdminUserView.Name = "btn_AdminUserView";
            btn_AdminUserView.Size = new Size(287, 76);
            btn_AdminUserView.TabIndex = 0;
            btn_AdminUserView.Text = "Users";
            btn_AdminUserView.UseVisualStyleBackColor = true;
            btn_AdminUserView.Click += btn_AdminUserView_Click;
            // 
            // frm_AdminScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btn_AdminProductView);
            Controls.Add(btn_AdminCategoryView);
            Controls.Add(btn_AdminUserView);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_AdminScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_AdminScreen_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_AdminProductView;
        private Button btn_AdminCategoryView;
        private Button btn_AdminUserView;
    }
}