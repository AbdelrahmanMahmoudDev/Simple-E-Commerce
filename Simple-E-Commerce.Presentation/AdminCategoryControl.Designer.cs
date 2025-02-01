namespace Simple_E_Commerce.Presentation
{
    partial class frm_AdminCategoryControl
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
            btn_AdminCatViewRegSubmit = new Button();
            btn_AdminCatViewRegRemove = new Button();
            btn_AdminCatViewRegUpdate = new Button();
            btn_AdminCatViewRegAdd = new Button();
            lbl_AdminCatViewRegRequireHint = new Label();
            lbl_AdminCatViewCategoryName = new Label();
            tb_AdminUserViewRegUsername = new TextBox();
            dgv_AdminUserTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminUserTable).BeginInit();
            SuspendLayout();
            // 
            // btn_AdminCatViewRegSubmit
            // 
            btn_AdminCatViewRegSubmit.Location = new Point(1034, 415);
            btn_AdminCatViewRegSubmit.Name = "btn_AdminCatViewRegSubmit";
            btn_AdminCatViewRegSubmit.Size = new Size(192, 88);
            btn_AdminCatViewRegSubmit.TabIndex = 52;
            btn_AdminCatViewRegSubmit.Text = "Upload";
            btn_AdminCatViewRegSubmit.UseVisualStyleBackColor = true;
            // 
            // btn_AdminCatViewRegRemove
            // 
            btn_AdminCatViewRegRemove.Location = new Point(1034, 281);
            btn_AdminCatViewRegRemove.Name = "btn_AdminCatViewRegRemove";
            btn_AdminCatViewRegRemove.Size = new Size(192, 88);
            btn_AdminCatViewRegRemove.TabIndex = 51;
            btn_AdminCatViewRegRemove.Text = "Remove";
            btn_AdminCatViewRegRemove.UseVisualStyleBackColor = true;
            // 
            // btn_AdminCatViewRegUpdate
            // 
            btn_AdminCatViewRegUpdate.Location = new Point(769, 415);
            btn_AdminCatViewRegUpdate.Name = "btn_AdminCatViewRegUpdate";
            btn_AdminCatViewRegUpdate.Size = new Size(186, 88);
            btn_AdminCatViewRegUpdate.TabIndex = 50;
            btn_AdminCatViewRegUpdate.Text = "Update";
            btn_AdminCatViewRegUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_AdminCatViewRegAdd
            // 
            btn_AdminCatViewRegAdd.Location = new Point(769, 281);
            btn_AdminCatViewRegAdd.Name = "btn_AdminCatViewRegAdd";
            btn_AdminCatViewRegAdd.Size = new Size(186, 88);
            btn_AdminCatViewRegAdd.TabIndex = 49;
            btn_AdminCatViewRegAdd.Text = "Add";
            btn_AdminCatViewRegAdd.UseVisualStyleBackColor = true;
            // 
            // lbl_AdminCatViewRegRequireHint
            // 
            lbl_AdminCatViewRegRequireHint.AutoSize = true;
            lbl_AdminCatViewRegRequireHint.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminCatViewRegRequireHint.Location = new Point(768, 538);
            lbl_AdminCatViewRegRequireHint.Name = "lbl_AdminCatViewRegRequireHint";
            lbl_AdminCatViewRegRequireHint.Size = new Size(91, 22);
            lbl_AdminCatViewRegRequireHint.TabIndex = 48;
            lbl_AdminCatViewRegRequireHint.Text = "* Required";
            // 
            // lbl_AdminCatViewCategoryName
            // 
            lbl_AdminCatViewCategoryName.AutoSize = true;
            lbl_AdminCatViewCategoryName.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminCatViewCategoryName.Location = new Point(768, 176);
            lbl_AdminCatViewCategoryName.Name = "lbl_AdminCatViewCategoryName";
            lbl_AdminCatViewCategoryName.Size = new Size(151, 23);
            lbl_AdminCatViewCategoryName.TabIndex = 54;
            lbl_AdminCatViewCategoryName.Text = "Category Name*";
            // 
            // tb_AdminUserViewRegUsername
            // 
            tb_AdminUserViewRegUsername.Location = new Point(769, 202);
            tb_AdminUserViewRegUsername.Name = "tb_AdminUserViewRegUsername";
            tb_AdminUserViewRegUsername.Size = new Size(457, 24);
            tb_AdminUserViewRegUsername.TabIndex = 53;
            // 
            // dgv_AdminUserTable
            // 
            dgv_AdminUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminUserTable.Location = new Point(12, 12);
            dgv_AdminUserTable.Name = "dgv_AdminUserTable";
            dgv_AdminUserTable.RowHeadersWidth = 51;
            dgv_AdminUserTable.Size = new Size(750, 649);
            dgv_AdminUserTable.TabIndex = 55;
            // 
            // frm_AdminCategoryControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgv_AdminUserTable);
            Controls.Add(lbl_AdminCatViewCategoryName);
            Controls.Add(tb_AdminUserViewRegUsername);
            Controls.Add(btn_AdminCatViewRegSubmit);
            Controls.Add(btn_AdminCatViewRegRemove);
            Controls.Add(btn_AdminCatViewRegUpdate);
            Controls.Add(btn_AdminCatViewRegAdd);
            Controls.Add(lbl_AdminCatViewRegRequireHint);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_AdminCategoryControl";
            Text = "Simple E-Commerce";
            FormClosed += frm_AdminCategoryControl_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminUserTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AdminCatViewRegSubmit;
        private Button btn_AdminCatViewRegRemove;
        private Button btn_AdminCatViewRegUpdate;
        private Button btn_AdminCatViewRegAdd;
        private Label lbl_AdminCatViewRegRequireHint;
        private Label lbl_AdminCatViewCategoryName;
        private TextBox tb_AdminUserViewRegUsername;
        private DataGridView dgv_AdminUserTable;
    }
}