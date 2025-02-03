namespace Simple_E_Commerce.Presentation
{
    partial class frm_AdminProductControl
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
            dgv_AdminProdTable = new DataGridView();
            lbl_AdminProdViewProductName = new Label();
            tb_AdminProdViewProdNane = new TextBox();
            btn_AdminProdViewRegSubmit = new Button();
            btn_AdminProdViewRegRemove = new Button();
            btn_AdminProdViewRegUpdate = new Button();
            btn_AdminProdViewRegAdd = new Button();
            lbl_AdminProdViewRegRequireHint = new Label();
            lbl_AdminProdViewPrice = new Label();
            nud_AdminProdViewPrice = new NumericUpDown();
            cb_AdminProdViewCategory = new ComboBox();
            lbl_AdminProdViewCat = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminProdTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_AdminProdViewPrice).BeginInit();
            SuspendLayout();
            // 
            // dgv_AdminProdTable
            // 
            dgv_AdminProdTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminProdTable.Location = new Point(12, 12);
            dgv_AdminProdTable.Name = "dgv_AdminProdTable";
            dgv_AdminProdTable.RowHeadersWidth = 51;
            dgv_AdminProdTable.Size = new Size(693, 649);
            dgv_AdminProdTable.TabIndex = 63;
            dgv_AdminProdTable.RowEnter += dgv_AdminProdTable_RowEnter;
            // 
            // lbl_AdminProdViewProductName
            // 
            lbl_AdminProdViewProductName.AutoSize = true;
            lbl_AdminProdViewProductName.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminProdViewProductName.Location = new Point(725, 66);
            lbl_AdminProdViewProductName.Name = "lbl_AdminProdViewProductName";
            lbl_AdminProdViewProductName.Size = new Size(139, 23);
            lbl_AdminProdViewProductName.TabIndex = 62;
            lbl_AdminProdViewProductName.Text = "Product Name*";
            // 
            // tb_AdminProdViewProdNane
            // 
            tb_AdminProdViewProdNane.Location = new Point(726, 92);
            tb_AdminProdViewProdNane.Name = "tb_AdminProdViewProdNane";
            tb_AdminProdViewProdNane.Size = new Size(514, 24);
            tb_AdminProdViewProdNane.TabIndex = 61;
            // 
            // btn_AdminProdViewRegSubmit
            // 
            btn_AdminProdViewRegSubmit.Location = new Point(1024, 422);
            btn_AdminProdViewRegSubmit.Name = "btn_AdminProdViewRegSubmit";
            btn_AdminProdViewRegSubmit.Size = new Size(216, 84);
            btn_AdminProdViewRegSubmit.TabIndex = 60;
            btn_AdminProdViewRegSubmit.Text = "Upload";
            btn_AdminProdViewRegSubmit.UseVisualStyleBackColor = true;
            btn_AdminProdViewRegSubmit.Click += btn_AdminProdViewRegSubmit_Click;
            // 
            // btn_AdminProdViewRegRemove
            // 
            btn_AdminProdViewRegRemove.Location = new Point(1024, 295);
            btn_AdminProdViewRegRemove.Name = "btn_AdminProdViewRegRemove";
            btn_AdminProdViewRegRemove.Size = new Size(216, 84);
            btn_AdminProdViewRegRemove.TabIndex = 59;
            btn_AdminProdViewRegRemove.Text = "Remove";
            btn_AdminProdViewRegRemove.UseVisualStyleBackColor = true;
            btn_AdminProdViewRegRemove.Click += btn_AdminProdViewRegRemove_Click;
            // 
            // btn_AdminProdViewRegUpdate
            // 
            btn_AdminProdViewRegUpdate.Location = new Point(726, 422);
            btn_AdminProdViewRegUpdate.Name = "btn_AdminProdViewRegUpdate";
            btn_AdminProdViewRegUpdate.Size = new Size(209, 84);
            btn_AdminProdViewRegUpdate.TabIndex = 58;
            btn_AdminProdViewRegUpdate.Text = "Update";
            btn_AdminProdViewRegUpdate.UseVisualStyleBackColor = true;
            btn_AdminProdViewRegUpdate.Click += btn_AdminProdViewRegUpdate_Click;
            // 
            // btn_AdminProdViewRegAdd
            // 
            btn_AdminProdViewRegAdd.Location = new Point(726, 295);
            btn_AdminProdViewRegAdd.Name = "btn_AdminProdViewRegAdd";
            btn_AdminProdViewRegAdd.Size = new Size(209, 84);
            btn_AdminProdViewRegAdd.TabIndex = 57;
            btn_AdminProdViewRegAdd.Text = "Add";
            btn_AdminProdViewRegAdd.UseVisualStyleBackColor = true;
            btn_AdminProdViewRegAdd.Click += btn_AdminProdViewRegAdd_Click;
            // 
            // lbl_AdminProdViewRegRequireHint
            // 
            lbl_AdminProdViewRegRequireHint.AutoSize = true;
            lbl_AdminProdViewRegRequireHint.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminProdViewRegRequireHint.Location = new Point(725, 539);
            lbl_AdminProdViewRegRequireHint.Name = "lbl_AdminProdViewRegRequireHint";
            lbl_AdminProdViewRegRequireHint.Size = new Size(91, 22);
            lbl_AdminProdViewRegRequireHint.TabIndex = 56;
            lbl_AdminProdViewRegRequireHint.Text = "* Required";
            // 
            // lbl_AdminProdViewPrice
            // 
            lbl_AdminProdViewPrice.AutoSize = true;
            lbl_AdminProdViewPrice.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminProdViewPrice.Location = new Point(725, 136);
            lbl_AdminProdViewPrice.Name = "lbl_AdminProdViewPrice";
            lbl_AdminProdViewPrice.Size = new Size(63, 23);
            lbl_AdminProdViewPrice.TabIndex = 64;
            lbl_AdminProdViewPrice.Text = "Price*";
            // 
            // nud_AdminProdViewPrice
            // 
            nud_AdminProdViewPrice.DecimalPlaces = 2;
            nud_AdminProdViewPrice.Location = new Point(725, 162);
            nud_AdminProdViewPrice.Name = "nud_AdminProdViewPrice";
            nud_AdminProdViewPrice.Size = new Size(514, 24);
            nud_AdminProdViewPrice.TabIndex = 65;
            // 
            // cb_AdminProdViewCategory
            // 
            cb_AdminProdViewCategory.FormattingEnabled = true;
            cb_AdminProdViewCategory.Location = new Point(725, 242);
            cb_AdminProdViewCategory.Name = "cb_AdminProdViewCategory";
            cb_AdminProdViewCategory.Size = new Size(515, 27);
            cb_AdminProdViewCategory.TabIndex = 66;
            // 
            // lbl_AdminProdViewCat
            // 
            lbl_AdminProdViewCat.AutoSize = true;
            lbl_AdminProdViewCat.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminProdViewCat.Location = new Point(725, 216);
            lbl_AdminProdViewCat.Name = "lbl_AdminProdViewCat";
            lbl_AdminProdViewCat.Size = new Size(97, 23);
            lbl_AdminProdViewCat.TabIndex = 67;
            lbl_AdminProdViewCat.Text = "Category*";
            // 
            // frm_AdminProductControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(lbl_AdminProdViewCat);
            Controls.Add(cb_AdminProdViewCategory);
            Controls.Add(nud_AdminProdViewPrice);
            Controls.Add(lbl_AdminProdViewPrice);
            Controls.Add(dgv_AdminProdTable);
            Controls.Add(lbl_AdminProdViewProductName);
            Controls.Add(tb_AdminProdViewProdNane);
            Controls.Add(btn_AdminProdViewRegSubmit);
            Controls.Add(btn_AdminProdViewRegRemove);
            Controls.Add(btn_AdminProdViewRegUpdate);
            Controls.Add(btn_AdminProdViewRegAdd);
            Controls.Add(lbl_AdminProdViewRegRequireHint);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_AdminProductControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_AdminProductControl_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminProdTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_AdminProdViewPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_AdminProdTable;
        private Label lbl_AdminProdViewProductName;
        private TextBox tb_AdminProdViewProdNane;
        private Button btn_AdminProdViewRegSubmit;
        private Button btn_AdminProdViewRegRemove;
        private Button btn_AdminProdViewRegUpdate;
        private Button btn_AdminProdViewRegAdd;
        private Label lbl_AdminProdViewRegRequireHint;
        private Label lbl_AdminProdViewPrice;
        private NumericUpDown nud_AdminProdViewPrice;
        private ComboBox cb_AdminProdViewCategory;
        private Label lbl_AdminProdViewCat;
    }
}