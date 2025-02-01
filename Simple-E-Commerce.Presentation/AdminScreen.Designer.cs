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
            gb_AdminViewOpt = new GroupBox();
            btn_AdminProductView = new Button();
            btn_AdminCategoryView = new Button();
            btn_AdminUserView = new Button();
            dgv_AdminCurrentView = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            gb_AdminViewOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminCurrentView).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gb_AdminUserViewTypeOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_AdminUserViewRegAge).BeginInit();
            SuspendLayout();
            // 
            // gb_AdminViewOpt
            // 
            gb_AdminViewOpt.Controls.Add(btn_AdminProductView);
            gb_AdminViewOpt.Controls.Add(btn_AdminCategoryView);
            gb_AdminViewOpt.Controls.Add(btn_AdminUserView);
            gb_AdminViewOpt.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gb_AdminViewOpt.Location = new Point(0, 0);
            gb_AdminViewOpt.Name = "gb_AdminViewOpt";
            gb_AdminViewOpt.Size = new Size(1250, 125);
            gb_AdminViewOpt.TabIndex = 0;
            gb_AdminViewOpt.TabStop = false;
            gb_AdminViewOpt.Text = "View";
            // 
            // btn_AdminProductView
            // 
            btn_AdminProductView.Location = new Point(937, 29);
            btn_AdminProductView.Name = "btn_AdminProductView";
            btn_AdminProductView.Size = new Size(287, 76);
            btn_AdminProductView.TabIndex = 2;
            btn_AdminProductView.Text = "Products";
            btn_AdminProductView.UseVisualStyleBackColor = true;
            // 
            // btn_AdminCategoryView
            // 
            btn_AdminCategoryView.Location = new Point(485, 29);
            btn_AdminCategoryView.Name = "btn_AdminCategoryView";
            btn_AdminCategoryView.Size = new Size(287, 76);
            btn_AdminCategoryView.TabIndex = 1;
            btn_AdminCategoryView.Text = "Categories";
            btn_AdminCategoryView.UseVisualStyleBackColor = true;
            // 
            // btn_AdminUserView
            // 
            btn_AdminUserView.Location = new Point(25, 29);
            btn_AdminUserView.Name = "btn_AdminUserView";
            btn_AdminUserView.Size = new Size(287, 76);
            btn_AdminUserView.TabIndex = 0;
            btn_AdminUserView.Text = "Users";
            btn_AdminUserView.UseVisualStyleBackColor = true;
            // 
            // dgv_AdminCurrentView
            // 
            dgv_AdminCurrentView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminCurrentView.Location = new Point(12, 131);
            dgv_AdminCurrentView.Name = "dgv_AdminCurrentView";
            dgv_AdminCurrentView.RowHeadersWidth = 51;
            dgv_AdminCurrentView.Size = new Size(639, 538);
            dgv_AdminCurrentView.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(674, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(576, 530);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_AdminUserViewRegSubmit);
            tabPage1.Controls.Add(btn_AdminUserViewRegRemove);
            tabPage1.Controls.Add(btn_AdminUserViewRegUpdate);
            tabPage1.Controls.Add(gb_AdminUserViewTypeOpts);
            tabPage1.Controls.Add(btn_AdminUserViewRegAdd);
            tabPage1.Controls.Add(lbl_AdminUserViewRegRequireHint);
            tabPage1.Controls.Add(lbl_AdminUserViewAddress);
            tabPage1.Controls.Add(lbl_AdminUserViewAge);
            tabPage1.Controls.Add(lbl_AdminUserViewEmail);
            tabPage1.Controls.Add(lbl_AdminUserViewPassword);
            tabPage1.Controls.Add(lbl_AdminUserViewUsername);
            tabPage1.Controls.Add(nud_AdminUserViewRegAge);
            tabPage1.Controls.Add(tb_AdminUserViewRegAddress);
            tabPage1.Controls.Add(tb_AdminUserViewRegEmail);
            tabPage1.Controls.Add(tb_AdminUserViewRegPassword);
            tabPage1.Controls.Add(tb_AdminUserViewRegUsername);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(568, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "User Control";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_AdminUserViewRegSubmit
            // 
            btn_AdminUserViewRegSubmit.Location = new Point(382, 457);
            btn_AdminUserViewRegSubmit.Name = "btn_AdminUserViewRegSubmit";
            btn_AdminUserViewRegSubmit.Size = new Size(164, 32);
            btn_AdminUserViewRegSubmit.TabIndex = 31;
            btn_AdminUserViewRegSubmit.Text = "Submit";
            btn_AdminUserViewRegSubmit.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegSubmit.Click += btn_AdminUserViewRegSubmit_Click;
            // 
            // btn_AdminUserViewRegRemove
            // 
            btn_AdminUserViewRegRemove.Location = new Point(382, 419);
            btn_AdminUserViewRegRemove.Name = "btn_AdminUserViewRegRemove";
            btn_AdminUserViewRegRemove.Size = new Size(164, 32);
            btn_AdminUserViewRegRemove.TabIndex = 30;
            btn_AdminUserViewRegRemove.Text = "Remove";
            btn_AdminUserViewRegRemove.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegRemove.Click += btn_AdminUserViewRegRemove_Click;
            // 
            // btn_AdminUserViewRegUpdate
            // 
            btn_AdminUserViewRegUpdate.Location = new Point(218, 457);
            btn_AdminUserViewRegUpdate.Name = "btn_AdminUserViewRegUpdate";
            btn_AdminUserViewRegUpdate.Size = new Size(158, 32);
            btn_AdminUserViewRegUpdate.TabIndex = 29;
            btn_AdminUserViewRegUpdate.Text = "Update";
            btn_AdminUserViewRegUpdate.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegUpdate.Click += btn_AdminUserViewRegUpdate_Click;
            // 
            // gb_AdminUserViewTypeOpts
            // 
            gb_AdminUserViewTypeOpts.Controls.Add(rb_AdminUserViewRegOptCustomer);
            gb_AdminUserViewTypeOpts.Controls.Add(rb_AdminUserViewRegOptAdmin);
            gb_AdminUserViewTypeOpts.Location = new Point(6, 357);
            gb_AdminUserViewTypeOpts.Name = "gb_AdminUserViewTypeOpts";
            gb_AdminUserViewTypeOpts.Size = new Size(558, 56);
            gb_AdminUserViewTypeOpts.TabIndex = 28;
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
            btn_AdminUserViewRegAdd.Location = new Point(218, 419);
            btn_AdminUserViewRegAdd.Name = "btn_AdminUserViewRegAdd";
            btn_AdminUserViewRegAdd.Size = new Size(158, 32);
            btn_AdminUserViewRegAdd.TabIndex = 27;
            btn_AdminUserViewRegAdd.Text = "Add";
            btn_AdminUserViewRegAdd.UseVisualStyleBackColor = true;
            btn_AdminUserViewRegAdd.Click += btn_AdminUserViewRegAdd_Click;
            // 
            // lbl_AdminUserViewRegRequireHint
            // 
            lbl_AdminUserViewRegRequireHint.AutoSize = true;
            lbl_AdminUserViewRegRequireHint.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewRegRequireHint.Location = new Point(6, 429);
            lbl_AdminUserViewRegRequireHint.Name = "lbl_AdminUserViewRegRequireHint";
            lbl_AdminUserViewRegRequireHint.Size = new Size(91, 22);
            lbl_AdminUserViewRegRequireHint.TabIndex = 26;
            lbl_AdminUserViewRegRequireHint.Text = "* Required";
            // 
            // lbl_AdminUserViewAddress
            // 
            lbl_AdminUserViewAddress.AutoSize = true;
            lbl_AdminUserViewAddress.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewAddress.Location = new Point(6, 301);
            lbl_AdminUserViewAddress.Name = "lbl_AdminUserViewAddress";
            lbl_AdminUserViewAddress.Size = new Size(77, 23);
            lbl_AdminUserViewAddress.TabIndex = 25;
            lbl_AdminUserViewAddress.Text = "Address";
            // 
            // lbl_AdminUserViewAge
            // 
            lbl_AdminUserViewAge.AutoSize = true;
            lbl_AdminUserViewAge.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewAge.Location = new Point(6, 235);
            lbl_AdminUserViewAge.Name = "lbl_AdminUserViewAge";
            lbl_AdminUserViewAge.Size = new Size(44, 23);
            lbl_AdminUserViewAge.TabIndex = 24;
            lbl_AdminUserViewAge.Text = "Age";
            // 
            // lbl_AdminUserViewEmail
            // 
            lbl_AdminUserViewEmail.AutoSize = true;
            lbl_AdminUserViewEmail.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewEmail.Location = new Point(6, 167);
            lbl_AdminUserViewEmail.Name = "lbl_AdminUserViewEmail";
            lbl_AdminUserViewEmail.Size = new Size(70, 23);
            lbl_AdminUserViewEmail.TabIndex = 23;
            lbl_AdminUserViewEmail.Text = "Email*";
            // 
            // lbl_AdminUserViewPassword
            // 
            lbl_AdminUserViewPassword.AutoSize = true;
            lbl_AdminUserViewPassword.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewPassword.Location = new Point(6, 97);
            lbl_AdminUserViewPassword.Name = "lbl_AdminUserViewPassword";
            lbl_AdminUserViewPassword.Size = new Size(99, 23);
            lbl_AdminUserViewPassword.TabIndex = 22;
            lbl_AdminUserViewPassword.Text = "Password*";
            // 
            // lbl_AdminUserViewUsername
            // 
            lbl_AdminUserViewUsername.AutoSize = true;
            lbl_AdminUserViewUsername.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AdminUserViewUsername.Location = new Point(6, 32);
            lbl_AdminUserViewUsername.Name = "lbl_AdminUserViewUsername";
            lbl_AdminUserViewUsername.Size = new Size(105, 23);
            lbl_AdminUserViewUsername.TabIndex = 21;
            lbl_AdminUserViewUsername.Text = "Username*";
            // 
            // nud_AdminUserViewRegAge
            // 
            nud_AdminUserViewRegAge.Location = new Point(6, 261);
            nud_AdminUserViewRegAge.Name = "nud_AdminUserViewRegAge";
            nud_AdminUserViewRegAge.Size = new Size(558, 24);
            nud_AdminUserViewRegAge.TabIndex = 20;
            // 
            // tb_AdminUserViewRegAddress
            // 
            tb_AdminUserViewRegAddress.Location = new Point(6, 327);
            tb_AdminUserViewRegAddress.Name = "tb_AdminUserViewRegAddress";
            tb_AdminUserViewRegAddress.Size = new Size(558, 24);
            tb_AdminUserViewRegAddress.TabIndex = 19;
            // 
            // tb_AdminUserViewRegEmail
            // 
            tb_AdminUserViewRegEmail.Location = new Point(6, 193);
            tb_AdminUserViewRegEmail.Name = "tb_AdminUserViewRegEmail";
            tb_AdminUserViewRegEmail.Size = new Size(558, 24);
            tb_AdminUserViewRegEmail.TabIndex = 18;
            // 
            // tb_AdminUserViewRegPassword
            // 
            tb_AdminUserViewRegPassword.Location = new Point(6, 123);
            tb_AdminUserViewRegPassword.Name = "tb_AdminUserViewRegPassword";
            tb_AdminUserViewRegPassword.Size = new Size(558, 24);
            tb_AdminUserViewRegPassword.TabIndex = 17;
            tb_AdminUserViewRegPassword.UseSystemPasswordChar = true;
            // 
            // tb_AdminUserViewRegUsername
            // 
            tb_AdminUserViewRegUsername.Location = new Point(6, 58);
            tb_AdminUserViewRegUsername.Name = "tb_AdminUserViewRegUsername";
            tb_AdminUserViewRegUsername.Size = new Size(558, 24);
            tb_AdminUserViewRegUsername.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(568, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Category Control";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(568, 497);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Product Control";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // frm_AdminScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(tabControl1);
            Controls.Add(dgv_AdminCurrentView);
            Controls.Add(gb_AdminViewOpt);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_AdminScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_AdminScreen_FormClosed;
            gb_AdminViewOpt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_AdminCurrentView).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            gb_AdminUserViewTypeOpts.ResumeLayout(false);
            gb_AdminUserViewTypeOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_AdminUserViewRegAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_AdminViewOpt;
        private Button btn_AdminProductView;
        private Button btn_AdminCategoryView;
        private Button btn_AdminUserView;
        private DataGridView dgv_AdminCurrentView;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
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
        private Button btn_AdminUserViewRegSubmit;
        private Button btn_AdminUserViewRegRemove;
        private Button btn_AdminUserViewRegUpdate;
    }
}