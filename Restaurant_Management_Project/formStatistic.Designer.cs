namespace Restaurant_Management_Project
{
    partial class formStatistic
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelStatistic = new System.Windows.Forms.Label();
            this.textboxSearch5 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.labelStatistic);
            this.panel4.Controls.Add(this.textboxSearch5);
            this.panel4.Controls.Add(this.buttonExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 80);
            this.panel4.TabIndex = 36;
            // 
            // labelStatistic
            // 
            this.labelStatistic.AutoSize = true;
            this.labelStatistic.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelStatistic.Location = new System.Drawing.Point(29, 12);
            this.labelStatistic.Name = "labelStatistic";
            this.labelStatistic.Size = new System.Drawing.Size(236, 49);
            this.labelStatistic.TabIndex = 20;
            this.labelStatistic.Text = "İstatistikler";
            // 
            // textboxSearch5
            // 
            this.textboxSearch5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.textboxSearch5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSearch5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxSearch5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.textboxSearch5.Location = new System.Drawing.Point(550, 26);
            this.textboxSearch5.Multiline = true;
            this.textboxSearch5.Name = "textboxSearch5";
            this.textboxSearch5.Size = new System.Drawing.Size(354, 25);
            this.textboxSearch5.TabIndex = 21;
            this.textboxSearch5.Text = "    Sistem içinde ara...";
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Restaurant_Management_Project.Properties.Resources.close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(910, 19);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 34);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // formStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formStatistic";
            this.Size = new System.Drawing.Size(962, 800);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelStatistic;
        private System.Windows.Forms.TextBox textboxSearch5;
        private System.Windows.Forms.Button buttonExit;
    }
}
