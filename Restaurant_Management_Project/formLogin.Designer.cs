namespace Restaurant_Management_Project
{
    partial class formLogin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.checkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelDontHaveAccount = new System.Windows.Forms.Label();
            this.labelRegisterAccount = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelLogin.Location = new System.Drawing.Point(431, 50);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(231, 56);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Giriş Yap";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelUsername.Location = new System.Drawing.Point(436, 152);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(143, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Kullanıcı adı:";
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.textboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxUsername.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.textboxUsername.Location = new System.Drawing.Point(442, 197);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textboxUsername.Multiline = true;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(380, 43);
            this.textboxUsername.TabIndex = 2;
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPassword.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.textboxPassword.Location = new System.Drawing.Point(442, 305);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textboxPassword.Multiline = true;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(380, 43);
            this.textboxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelPassword.Location = new System.Drawing.Point(436, 260);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(60, 25);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Şifre:";
            // 
            // checkboxShowPassword
            // 
            this.checkboxShowPassword.AutoSize = true;
            this.checkboxShowPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkboxShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.checkboxShowPassword.Location = new System.Drawing.Point(710, 354);
            this.checkboxShowPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkboxShowPassword.Name = "checkboxShowPassword";
            this.checkboxShowPassword.Size = new System.Drawing.Size(112, 20);
            this.checkboxShowPassword.TabIndex = 5;
            this.checkboxShowPassword.Text = "Şifreyi Göster";
            this.checkboxShowPassword.UseVisualStyleBackColor = true;
            this.checkboxShowPassword.CheckedChanged += new System.EventHandler(this.checkboxShowPassword_CheckedChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.buttonLogin.Location = new System.Drawing.Point(502, 403);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(238, 57);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "GİRİŞ YAP";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelDontHaveAccount
            // 
            this.labelDontHaveAccount.AutoSize = true;
            this.labelDontHaveAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDontHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelDontHaveAccount.Location = new System.Drawing.Point(541, 485);
            this.labelDontHaveAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDontHaveAccount.Name = "labelDontHaveAccount";
            this.labelDontHaveAccount.Size = new System.Drawing.Size(164, 19);
            this.labelDontHaveAccount.TabIndex = 7;
            this.labelDontHaveAccount.Text = "Bir hesabın yok mu?";
            // 
            // labelRegisterAccount
            // 
            this.labelRegisterAccount.AutoSize = true;
            this.labelRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegisterAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRegisterAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.labelRegisterAccount.Location = new System.Drawing.Point(588, 504);
            this.labelRegisterAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterAccount.Name = "labelRegisterAccount";
            this.labelRegisterAccount.Size = new System.Drawing.Size(69, 19);
            this.labelRegisterAccount.TabIndex = 8;
            this.labelRegisterAccount.Text = "Kayıt ol!";
            this.labelRegisterAccount.Click += new System.EventHandler(this.labelRegisterAccount_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Restaurant_Management_Project.Properties.Resources.close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(848, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 34);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelRegisterAccount);
            this.Controls.Add(this.labelDontHaveAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkboxShowPassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox checkboxShowPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelDontHaveAccount;
        private System.Windows.Forms.Label labelRegisterAccount;
        private System.Windows.Forms.Button buttonExit;
    }
}

