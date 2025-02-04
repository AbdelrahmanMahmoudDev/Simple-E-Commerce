namespace Simple_E_Commerce.Presentation
{
    partial class frm_StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            btn_Register = new Button();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            lbl_Username = new Label();
            lbl_Password = new Label();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(397, 384);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(477, 63);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(397, 470);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(477, 63);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(397, 146);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(476, 24);
            tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(397, 280);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(476, 24);
            tb_Password.TabIndex = 3;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Bell MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(397, 111);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(145, 34);
            lbl_Username.TabIndex = 4;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Bell MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(397, 245);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(139, 34);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password";
            // 
            // frm_StartScreen
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Font = new Font("Bell MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frm_StartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple E-Commerce";
            FormClosed += frm_StartScreen_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Login;
        private Button btn_Register;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private Label lbl_Username;
        private Label lbl_Password;
    }
}
