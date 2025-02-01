namespace Simple_E_Commerce.Presentation
{
    partial class frm_AdminUserControl
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
            btn_AdminUserViewRegSubmit = new Button();
            btn_AdminUserViewRegRemove = new Button();
            btn_AdminUserViewRegUpdate = new Button();
            gb_AdminUserViewTypeOpts = new GroupBox();
            rb_AdminUserViewRegOptCustomer = new RadioButton();
            rb_AdminUserViewRegOptAdmin = new RadioButton();
            btn_AdminUserViewRegAdd = new Button();
            lbl_AdminUserViewRegRequireHint = new Label();
            lbl_AdminUserViewAddress = new Label();
            lbl_AdminUserViewAge = new Label();
            lbl_AdminUserViewEmail = new Label();
            lbl_AdminUserViewPassword = new Label();
            lbl_AdminUserViewUsername = new Label();
            nud_AdminUserViewRegAge = new NumericUpDown();
            tb_AdminUserViewRegAddress = new TextBox();
            tb_AdminUserViewRegEmail = new TextBox();
            tb_AdminUserViewRegPassword = new TextBox();
            tb_AdminUserViewRegUsername = new TextBox();
            dgv_AdminUserTable = new DataGridView();
            gb_AdminUserViewTypeOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_AdminUserViewRegAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminUserTable).BeginInit();
            SuspendLayout();
            // 
            // btn_AdminUserViewRegSubmit
            // 
            btn_AdminUserViewRegSubmit.Location = new Point(1104, 616);
            btn_AdminUserViewRegSubmit.Name = "btn_AdminUserViewRegSubmit";
            btn_AdminUserViewRegSubmit.Size = new Size(129, 45);
            btn_AdminUserViewRegSubmit.TabIndex = 47;
            btn_AdminUserViewRegSubmit.Text = "Upload";
            btn_AdminUserViewRegSubmit.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegSubmit.Click += btn_AdminUserViewRegSubmit_Click;
            // 
            // btn_AdminUserViewRegRemove
            // 
            btn_AdminUserViewRegRemove.Location = new Point(1104, 522);
            btn_AdminUserViewRegRemove.Name = "btn_AdminUserViewRegRemove";
            btn_AdminUserViewRegRemove.Size = new Size(129, 45);
            btn_AdminUserViewRegRemove.TabIndex = 46;
            btn_AdminUserViewRegRemove.Text = "Remove";
            btn_AdminUserViewRegRemove.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegRemove.Click += btn_AdminUserViewRegRemove_Click;
            // 
            // btn_AdminUserViewRegUpdate
            // 
            btn_AdminUserViewRegUpdate.Location = new Point(876, 616);
            btn_AdminUserViewRegUpdate.Name = "btn_AdminUserViewRegUpdate";
            btn_AdminUserViewRegUpdate.Size = new Size(123, 45);
            btn_AdminUserViewRegUpdate.TabIndex = 45;
            btn_AdminUserViewRegUpdate.Text = "Update";
            btn_AdminUserViewRegUpdate.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegUpdate.Click += btn_AdminUserViewRegUpdate_Click;
            // 
            // gb_AdminUserViewTypeOpts
            // 
            gb_AdminUserViewTypeOpts.Controls.Add(rb_AdminUserViewRegOptCustomer);
            gb_AdminUserViewTypeOpts.Controls.Add(rb_AdminUserViewRegOptAdmin);
            gb_AdminUserViewTypeOpts.Location = new Point(813, 403);
            gb_AdminUserViewTypeOpts.Name = "gb_AdminUserViewTypeOpts";
            gb_AdminUserViewTypeOpts.Size = new Size(433, 70);
            gb_AdminUserViewTypeOpts.TabIndex = 44;
            gb_AdminUserViewTypeOpts.TabStop = false;
            gb_AdminUserViewTypeOpts.Text = "User Type*";
            // 
            // rb_AdminUserViewRegOptCustomer
            // 
            rb_AdminUserViewRegOptCustomer.AutoSize = true;
            rb_AdminUserViewRegOptCustomer.Checked = true;
            rb_AdminUserViewRegOptCustomer.Location = new Point(15, 23);
            rb_AdminUserViewRegOptCustomer.Name = "rb_AdminUserViewRegOptCustomer";
            rb_AdminUserViewRegOptCustomer.Size = new Size(90, 23);
            rb_AdminUserViewRegOptCustomer.TabIndex = 13;
            rb_AdminUserViewRegOptCustomer.TabStop = true;
            rb_AdminUserViewRegOptCustomer.Text = "Customer";
            rb_AdminUserViewRegOptCustomer.UseVisualStyleBackColor = false;
            // 
            // rb_AdminUserViewRegOptAdmin
            // 
            rb_AdminUserViewRegOptAdmin.AutoSize = true;
            rb_AdminUserViewRegOptAdmin.Location = new Point(129, 23);
            rb_AdminUserViewRegOptAdmin.Name = "rb_AdminUserViewRegOptAdmin";
            rb_AdminUserViewRegOptAdmin.Size = new Size(72, 23);
            rb_AdminUserViewRegOptAdmin.TabIndex = 14;
            rb_AdminUserViewRegOptAdmin.Text = "Admin";
            rb_AdminUserViewRegOptAdmin.UseVisualStyleBackColor = false;
            // 
            // btn_AdminUserViewRegAdd
            // 
            btn_AdminUserViewRegAdd.Location = new Point(876, 522);
            btn_AdminUserViewRegAdd.Name = "btn_AdminUserViewRegAdd";
            btn_AdminUserViewRegAdd.Size = new Size(123, 45);
            btn_AdminUserViewRegAdd.TabIndex = 43;
            btn_AdminUserViewRegAdd.Text = "Add";
            btn_AdminUserViewRegAdd.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegAdd.Click += btn_AdminUserViewRegAdd_Click;
            // 
            // lbl_AdminUserViewRegRequireHint
            // 
            lbl_AdminUserViewRegRequireHint.AutoSize = true;
            lbl_AdminUserViewRegRequireHint.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewRegRequireHint.Location = new Point(813, 497);
            lbl_AdminUserViewRegRequireHint.Name = "lbl_AdminUserViewRegRequireHint";
            lbl_AdminUserViewRegRequireHint.Size = new Size(91, 22);
            lbl_AdminUserViewRegRequireHint.TabIndex = 42;
            lbl_AdminUserViewRegRequireHint.Text = "* Required";
            // 
            // lbl_AdminUserViewAddress
            // 
            lbl_AdminUserViewAddress.AutoSize = true;
            lbl_AdminUserViewAddress.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewAddress.Location = new Point(813, 313);
            lbl_AdminUserViewAddress.Name = "lbl_AdminUserViewAddress";
            lbl_AdminUserViewAddress.Size = new Size(77, 23);
            lbl_AdminUserViewAddress.TabIndex = 41;
            lbl_AdminUserViewAddress.Text = "Address";
            // 
            // lbl_AdminUserViewAge
            // 
            lbl_AdminUserViewAge.AutoSize = true;
            lbl_AdminUserViewAge.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewAge.Location = new Point(813, 247);
            lbl_AdminUserViewAge.Name = "lbl_AdminUserViewAge";
            lbl_AdminUserViewAge.Size = new Size(44, 23);
            lbl_AdminUserViewAge.TabIndex = 40;
            lbl_AdminUserViewAge.Text = "Age";
            // 
            // lbl_AdminUserViewEmail
            // 
            lbl_AdminUserViewEmail.AutoSize = true;
            lbl_AdminUserViewEmail.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewEmail.Location = new Point(813, 179);
            lbl_AdminUserViewEmail.Name = "lbl_AdminUserViewEmail";
            lbl_AdminUserViewEmail.Size = new Size(70, 23);
            lbl_AdminUserViewEmail.TabIndex = 39;
            lbl_AdminUserViewEmail.Text = "Email*";
            // 
            // lbl_AdminUserViewPassword
            // 
            lbl_AdminUserViewPassword.AutoSize = true;
            lbl_AdminUserViewPassword.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewPassword.Location = new Point(813, 109);
            lbl_AdminUserViewPassword.Name = "lbl_AdminUserViewPassword";
            lbl_AdminUserViewPassword.Size = new Size(99, 23);
            lbl_AdminUserViewPassword.TabIndex = 38;
            lbl_AdminUserViewPassword.Text = "Password*";
            // 
            // lbl_AdminUserViewUsername
            // 
            lbl_AdminUserViewUsername.AutoSize = true;
            lbl_AdminUserViewUsername.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewUsername.Location = new Point(813, 44);
            lbl_AdminUserViewUsername.Name = "lbl_AdminUserViewUsername";
            lbl_AdminUserViewUsername.Size = new Size(105, 23);
            lbl_AdminUserViewUsername.TabIndex = 37;
            lbl_AdminUserViewUsername.Text = "Username*";
            // 
            // nud_AdminUserViewRegAge
            // 
            nud_AdminUserViewRegAge.Location = new Point(813, 273);
            nud_AdminUserViewRegAge.Name = "nud_AdminUserViewRegAge";
            nud_AdminUserViewRegAge.Size = new Size(383, 24);
            nud_AdminUserViewRegAge.TabIndex = 36;
            // 
            // tb_AdminUserViewRegAddress
            // 
            tb_AdminUserViewRegAddress.Location = new Point(813, 339);
            tb_AdminUserViewRegAddress.Name = "tb_AdminUserViewRegAddress";
            tb_AdminUserViewRegAddress.Size = new Size(383, 24);
            tb_AdminUserViewRegAddress.TabIndex = 35;
            // 
            // tb_AdminUserViewRegEmail
            // 
            tb_AdminUserViewRegEmail.Location = new Point(813, 205);
            tb_AdminUserViewRegEmail.Name = "tb_AdminUserViewRegEmail";
            tb_AdminUserViewRegEmail.Size = new Size(383, 24);
            tb_AdminUserViewRegEmail.TabIndex = 34;
            // 
            // tb_AdminUserViewRegPassword
            // 
            tb_AdminUserViewRegPassword.Location = new Point(813, 135);
            tb_AdminUserViewRegPassword.Name = "tb_AdminUserViewRegPassword";
            tb_AdminUserViewRegPassword.Size = new Size(383, 24);
            tb_AdminUserViewRegPassword.TabIndex = 33;
            tb_AdminUserViewRegPassword.UseSystemPasswordChar = true;
            // 
            // tb_AdminUserViewRegUsername
            // 
            tb_AdminUserViewRegUsername.Location = new Point(813, 70);
            tb_AdminUserViewRegUsername.Name = "tb_AdminUserViewRegUsername";
            tb_AdminUserViewRegUsername.Size = new Size(383, 24);
            tb_AdminUserViewRegUsername.TabIndex = 32;
            // 
            // dgv_AdminUserTable
            // 
            dgv_AdminUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminUserTable.Location = new Point(12, 12);
            dgv_AdminUserTable.Name = "dgv_AdminUserTable";
            dgv_AdminUserTable.RowHeadersWidth = 51;
            dgv_AdminUserTable.Size = new Size(795, 649);
            dgv_AdminUserTable.TabIndex = 48;
            dgv_AdminUserTable.RowEnter += dgv_AdminUserTable_RowEnter;
            // 
            // frm_AdminUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(dgv_AdminUserTable);
            Controls.Add(btn_AdminUserViewRegSubmit);
            Controls.Add(btn_AdminUserViewRegRemove);
            Controls.Add(btn_AdminUserViewRegUpdate);
            Controls.Add(gb_AdminUserViewTypeOpts);
            Controls.Add(btn_AdminUserViewRegAdd);
            Controls.Add(lbl_AdminUserViewRegRequireHint);
            Controls.Add(lbl_AdminUserViewAddress);
            Controls.Add(lbl_AdminUserViewAge);
            Controls.Add(lbl_AdminUserViewEmail);
            Controls.Add(lbl_AdminUserViewPassword);
            Controls.Add(lbl_AdminUserViewUsername);
            Controls.Add(nud_AdminUserViewRegAge);
            Controls.Add(tb_AdminUserViewRegAddress);
            Controls.Add(tb_AdminUserViewRegEmail);
            Controls.Add(tb_AdminUserViewRegPassword);
            Controls.Add(tb_AdminUserViewRegUsername);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_AdminUserControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_AdminUserControl_FormClosed;
            gb_AdminUserViewTypeOpts.ResumeLayout(false);
            gb_AdminUserViewTypeOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_AdminUserViewRegAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminUserTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AdminUserViewRegSubmit;
        private Button btn_AdminUserViewRegRemove;
        private Button btn_AdminUserViewRegUpdate;
        private GroupBox gb_AdminUserViewTypeOpts;
        private RadioButton rb_AdminUserViewRegOptCustomer;
        private RadioButton rb_AdminUserViewRegOptAdmin;
        private Button btn_AdminUserViewRegAdd;
        private Label lbl_AdminUserViewRegRequireHint;
        private Label lbl_AdminUserViewAddress;
        private Label lbl_AdminUserViewAge;
        private Label lbl_AdminUserViewEmail;
        private Label lbl_AdminUserViewPassword;
        private Label lbl_AdminUserViewUsername;
        private NumericUpDown nud_AdminUserViewRegAge;
        private TextBox tb_AdminUserViewRegAddress;
        private TextBox tb_AdminUserViewRegEmail;
        private TextBox tb_AdminUserViewRegPassword;
        private TextBox tb_AdminUserViewRegUsername;
        private DataGridView dgv_AdminUserTable;
    }
}