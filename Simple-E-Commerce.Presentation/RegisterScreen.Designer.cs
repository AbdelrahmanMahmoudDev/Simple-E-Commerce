namespace Simple_E_Commerce.Presentation
{
    partial class frm_RegisterScreen
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
            tb_RegUsername = new TextBox();
            tb_RegPassword = new TextBox();
            tb_RegEmail = new TextBox();
            tb_RegAddress = new TextBox();
            nud_RegAge = new NumericUpDown();
            lbl_RegUsername = new Label();
            lbl_RegPassword = new Label();
            lbl_RegEmail = new Label();
            lbl_RegAge = new Label();
            lbl_RegAddress = new Label();
            lbl_RegRequireHint = new Label();
            btn_RegRegister = new Button();
            rb_RegOptCustomer = new RadioButton();
            rb_RegOptAdmin = new RadioButton();
            gb_UserTypeOpts = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nud_RegAge).BeginInit();
            gb_UserTypeOpts.SuspendLayout();
            SuspendLayout();
            // 
            // tb_RegUsername
            // 
            tb_RegUsername.Location = new Point(27, 35);
            tb_RegUsername.Name = "tb_RegUsername";
            tb_RegUsername.Size = new Size(558, 24);
            tb_RegUsername.TabIndex = 0;
            // 
            // tb_RegPassword
            // 
            tb_RegPassword.Location = new Point(27, 100);
            tb_RegPassword.Name = "tb_RegPassword";
            tb_RegPassword.Size = new Size(558, 24);
            tb_RegPassword.TabIndex = 1;
            tb_RegPassword.UseSystemPasswordChar = true;
            // 
            // tb_RegEmail
            // 
            tb_RegEmail.Location = new Point(27, 170);
            tb_RegEmail.Name = "tb_RegEmail";
            tb_RegEmail.Size = new Size(558, 24);
            tb_RegEmail.TabIndex = 2;
            // 
            // tb_RegAddress
            // 
            tb_RegAddress.Location = new Point(27, 304);
            tb_RegAddress.Name = "tb_RegAddress";
            tb_RegAddress.Size = new Size(558, 24);
            tb_RegAddress.TabIndex = 4;
            // 
            // nud_RegAge
            // 
            nud_RegAge.Location = new Point(27, 238);
            nud_RegAge.Name = "nud_RegAge";
            nud_RegAge.Size = new Size(558, 24);
            nud_RegAge.TabIndex = 5;
            // 
            // lbl_RegUsername
            // 
            lbl_RegUsername.AutoSize = true;
            lbl_RegUsername.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegUsername.Location = new Point(27, 9);
            lbl_RegUsername.Name = "lbl_RegUsername";
            lbl_RegUsername.Size = new Size(105, 23);
            lbl_RegUsername.TabIndex = 6;
            lbl_RegUsername.Text = "Username*";
            // 
            // lbl_RegPassword
            // 
            lbl_RegPassword.AutoSize = true;
            lbl_RegPassword.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegPassword.Location = new Point(27, 74);
            lbl_RegPassword.Name = "lbl_RegPassword";
            lbl_RegPassword.Size = new Size(99, 23);
            lbl_RegPassword.TabIndex = 7;
            lbl_RegPassword.Text = "Password*";
            // 
            // lbl_RegEmail
            // 
            lbl_RegEmail.AutoSize = true;
            lbl_RegEmail.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegEmail.Location = new Point(27, 144);
            lbl_RegEmail.Name = "lbl_RegEmail";
            lbl_RegEmail.Size = new Size(70, 23);
            lbl_RegEmail.TabIndex = 8;
            lbl_RegEmail.Text = "Email*";
            // 
            // lbl_RegAge
            // 
            lbl_RegAge.AutoSize = true;
            lbl_RegAge.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegAge.Location = new Point(27, 212);
            lbl_RegAge.Name = "lbl_RegAge";
            lbl_RegAge.Size = new Size(44, 23);
            lbl_RegAge.TabIndex = 9;
            lbl_RegAge.Text = "Age";
            // 
            // lbl_RegAddress
            // 
            lbl_RegAddress.AutoSize = true;
            lbl_RegAddress.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegAddress.Location = new Point(27, 278);
            lbl_RegAddress.Name = "lbl_RegAddress";
            lbl_RegAddress.Size = new Size(77, 23);
            lbl_RegAddress.TabIndex = 10;
            lbl_RegAddress.Text = "Address";
            // 
            // lbl_RegRequireHint
            // 
            lbl_RegRequireHint.AutoSize = true;
            lbl_RegRequireHint.Font = new Font("Bell MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RegRequireHint.Location = new Point(27, 406);
            lbl_RegRequireHint.Name = "lbl_RegRequireHint";
            lbl_RegRequireHint.Size = new Size(91, 22);
            lbl_RegRequireHint.TabIndex = 11;
            lbl_RegRequireHint.Text = "* Required";
            // 
            // btn_RegRegister
            // 
            btn_RegRegister.Location = new Point(452, 396);
            btn_RegRegister.Name = "btn_RegRegister";
            btn_RegRegister.Size = new Size(178, 45);
            btn_RegRegister.TabIndex = 12;
            btn_RegRegister.Text = "Register";
            btn_RegRegister.UseVisualStyleBackColor = true;
            btn_RegRegister.Click += btn_RegRegister_Click;
            // 
            // rb_RegOptCustomer
            // 
            rb_RegOptCustomer.AutoSize = true;
            rb_RegOptCustomer.Checked = true;
            rb_RegOptCustomer.Location = new Point(15, 23);
            rb_RegOptCustomer.Name = "rb_RegOptCustomer";
            rb_RegOptCustomer.Size = new Size(90, 23);
            rb_RegOptCustomer.TabIndex = 13;
            rb_RegOptCustomer.TabStop = true;
            rb_RegOptCustomer.Text = "Customer";
            rb_RegOptCustomer.UseVisualStyleBackColor = false;
            // 
            // rb_RegOptAdmin
            // 
            rb_RegOptAdmin.AutoSize = true;
            rb_RegOptAdmin.Location = new Point(129, 23);
            rb_RegOptAdmin.Name = "rb_RegOptAdmin";
            rb_RegOptAdmin.Size = new Size(72, 23);
            rb_RegOptAdmin.TabIndex = 14;
            rb_RegOptAdmin.Text = "Admin";
            rb_RegOptAdmin.UseVisualStyleBackColor = false;
            // 
            // gb_UserTypeOpts
            // 
            gb_UserTypeOpts.Controls.Add(rb_RegOptCustomer);
            gb_UserTypeOpts.Controls.Add(rb_RegOptAdmin);
            gb_UserTypeOpts.Location = new Point(27, 334);
            gb_UserTypeOpts.Name = "gb_UserTypeOpts";
            gb_UserTypeOpts.Size = new Size(558, 56);
            gb_UserTypeOpts.TabIndex = 15;
            gb_UserTypeOpts.TabStop = false;
            gb_UserTypeOpts.Text = "User Type*";
            // 
            // frm_RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 453);
            Controls.Add(gb_UserTypeOpts);
            Controls.Add(btn_RegRegister);
            Controls.Add(lbl_RegRequireHint);
            Controls.Add(lbl_RegAddress);
            Controls.Add(lbl_RegAge);
            Controls.Add(lbl_RegEmail);
            Controls.Add(lbl_RegPassword);
            Controls.Add(lbl_RegUsername);
            Controls.Add(nud_RegAge);
            Controls.Add(tb_RegAddress);
            Controls.Add(tb_RegEmail);
            Controls.Add(tb_RegPassword);
            Controls.Add(tb_RegUsername);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_RegisterScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            ((System.ComponentModel.ISupportInitialize)nud_RegAge).EndInit();
            gb_UserTypeOpts.ResumeLayout(false);
            gb_UserTypeOpts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_RegUsername;
        private TextBox tb_RegPassword;
        private TextBox tb_RegEmail;
        private TextBox tb_RegAddress;
        private NumericUpDown nud_RegAge;
        private Label lbl_RegUsername;
        private Label lbl_RegPassword;
        private Label lbl_RegEmail;
        private Label lbl_RegAge;
        private Label lbl_RegAddress;
        private Label lbl_RegRequireHint;
        private Button btn_RegRegister;
        private RadioButton rb_RegOptCustomer;
        private RadioButton rb_RegOptAdmin;
        private GroupBox gb_UserTypeOpts;
    }
}