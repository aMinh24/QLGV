namespace UngDungHoTroGiangVien
{
    partial class LoginAccount
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
            this.panelTitleDN = new System.Windows.Forms.Panel();
            this.titleDN = new System.Windows.Forms.Label();
            this.khungLogin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.khungPassword = new System.Windows.Forms.Panel();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.matKhau = new System.Windows.Forms.Label();
            this.khungUser = new System.Windows.Forms.Panel();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.tenDangNhap = new System.Windows.Forms.Label();
            this.panelTitleDN.SuspendLayout();
            this.khungLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.khungPassword.SuspendLayout();
            this.khungUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleDN
            // 
            this.panelTitleDN.Controls.Add(this.titleDN);
            this.panelTitleDN.Location = new System.Drawing.Point(131, 75);
            this.panelTitleDN.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleDN.Name = "panelTitleDN";
            this.panelTitleDN.Size = new System.Drawing.Size(539, 75);
            this.panelTitleDN.TabIndex = 4;
            // 
            // titleDN
            // 
            this.titleDN.AutoSize = true;
            this.titleDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleDN.Location = new System.Drawing.Point(163, 17);
            this.titleDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleDN.Name = "titleDN";
            this.titleDN.Size = new System.Drawing.Size(214, 46);
            this.titleDN.TabIndex = 2;
            this.titleDN.Text = "Đăng nhập";
            // 
            // khungLogin
            // 
            this.khungLogin.BackColor = System.Drawing.Color.White;
            this.khungLogin.Controls.Add(this.panel1);
            this.khungLogin.Controls.Add(this.khungPassword);
            this.khungLogin.Controls.Add(this.khungUser);
            this.khungLogin.Location = new System.Drawing.Point(131, 174);
            this.khungLogin.Margin = new System.Windows.Forms.Padding(4);
            this.khungLogin.Name = "khungLogin";
            this.khungLogin.Size = new System.Drawing.Size(539, 202);
            this.khungLogin.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSignIn);
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Location = new System.Drawing.Point(11, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 48);
            this.panel1.TabIndex = 3;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.Location = new System.Drawing.Point(245, 4);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(115, 38);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Đăng kí";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(368, 4);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(136, 38);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // khungPassword
            // 
            this.khungPassword.Controls.Add(this.tBoxPassword);
            this.khungPassword.Controls.Add(this.matKhau);
            this.khungPassword.Location = new System.Drawing.Point(11, 74);
            this.khungPassword.Margin = new System.Windows.Forms.Padding(4);
            this.khungPassword.Name = "khungPassword";
            this.khungPassword.Size = new System.Drawing.Size(519, 57);
            this.khungPassword.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(148, 15);
            this.tBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(355, 22);
            this.tBoxPassword.TabIndex = 2;
            this.tBoxPassword.UseSystemPasswordChar = true;
            // 
            // matKhau
            // 
            this.matKhau.AutoSize = true;
            this.matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matKhau.Location = new System.Drawing.Point(16, 20);
            this.matKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matKhau.Name = "matKhau";
            this.matKhau.Size = new System.Drawing.Size(77, 20);
            this.matKhau.TabIndex = 1;
            this.matKhau.Text = "Mật khẩu";
            // 
            // khungUser
            // 
            this.khungUser.Controls.Add(this.tBoxLogin);
            this.khungUser.Controls.Add(this.tenDangNhap);
            this.khungUser.Location = new System.Drawing.Point(11, 10);
            this.khungUser.Margin = new System.Windows.Forms.Padding(4);
            this.khungUser.Name = "khungUser";
            this.khungUser.Size = new System.Drawing.Size(519, 57);
            this.khungUser.TabIndex = 1;
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Location = new System.Drawing.Point(148, 17);
            this.tBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(355, 22);
            this.tBoxLogin.TabIndex = 1;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.AutoSize = true;
            this.tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDangNhap.Location = new System.Drawing.Point(4, 18);
            this.tenDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.Size = new System.Drawing.Size(119, 20);
            this.tenDangNhap.TabIndex = 0;
            this.tenDangNhap.Text = "Tên đăng nhập";
            // 
            // LoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTitleDN);
            this.Controls.Add(this.khungLogin);
            this.Name = "LoginAccount";
            this.Text = "LoginAccount";
            this.Load += new System.EventHandler(this.LoginAccount_Load);
            this.panelTitleDN.ResumeLayout(false);
            this.panelTitleDN.PerformLayout();
            this.khungLogin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.khungPassword.ResumeLayout(false);
            this.khungPassword.PerformLayout();
            this.khungUser.ResumeLayout(false);
            this.khungUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleDN;
        private System.Windows.Forms.Label titleDN;
        private System.Windows.Forms.Panel khungLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel khungPassword;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label matKhau;
        private System.Windows.Forms.Panel khungUser;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.Label tenDangNhap;
    }
}