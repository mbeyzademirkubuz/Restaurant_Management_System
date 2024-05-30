namespace Restaurant_Management_Project
{
    partial class formDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.pictureboxAvatar = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.panel4 = new System.Windows.Forms.Panel();
            this.formOrder1 = new Restaurant_Management_Project.formOrder();
            this.formCrew1 = new Restaurant_Management_Project.formCrew();
            this.formMenu1 = new Restaurant_Management_Project.formMenu();
            this.formDashboard21 = new Restaurant_Management_Project.formDashboard2();
            this.formStatistic1 = new Restaurant_Management_Project.formStatistic();
            this.restaurant_ManagementDataSet1 = new Restaurant_Management_Project.Restaurant_ManagementDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_ManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonStatistic);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonOrder);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 800);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonSettings.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_settings_50;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 733);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(238, 67);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "    Ayarlar";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            this.buttonSettings.Leave += new System.EventHandler(this.buttonSettings_Leave);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonStatistic.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_statistics_50;
            this.buttonStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStatistic.Location = new System.Drawing.Point(0, 435);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(238, 67);
            this.buttonStatistic.TabIndex = 5;
            this.buttonStatistic.Text = "    İstatistikler";
            this.buttonStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStatistic.UseVisualStyleBackColor = true;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            this.buttonStatistic.Leave += new System.EventHandler(this.buttonStatistic_Leave);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonEmployee.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_employee_50;
            this.buttonEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployee.Location = new System.Drawing.Point(0, 368);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(238, 67);
            this.buttonEmployee.TabIndex = 4;
            this.buttonEmployee.Text = "    Ekip";
            this.buttonEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            this.buttonEmployee.Leave += new System.EventHandler(this.buttonEmployee_Leave);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonMenu.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_restaurant_menu_50;
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(0, 301);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(238, 67);
            this.buttonMenu.TabIndex = 3;
            this.buttonMenu.Text = "    Menü";
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            this.buttonMenu.Leave += new System.EventHandler(this.buttonMenu_Leave);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonOrder.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_fast_food_drive_thru_50;
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrder.Location = new System.Drawing.Point(0, 234);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(238, 67);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "    Siparişler";
            this.buttonOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            this.buttonOrder.Leave += new System.EventHandler(this.buttonOrder_Leave);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonDashboard.Image = global::Restaurant_Management_Project.Properties.Resources.icons8_dashboard_50;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 167);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(238, 67);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "    Panel";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            this.buttonDashboard.Leave += new System.EventHandler(this.buttonDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panelNav);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.labelFullname);
            this.panel2.Controls.Add(this.pictureboxAvatar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 167);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(235, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 800);
            this.panel3.TabIndex = 1;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.panelNav.Location = new System.Drawing.Point(0, 193);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 99);
            this.panelNav.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelTitle.Location = new System.Drawing.Point(84, 137);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 16);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Yönetici";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelFullname.Location = new System.Drawing.Point(82, 118);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(61, 19);
            this.labelFullname.TabIndex = 1;
            this.labelFullname.Text = "admin";
            // 
            // pictureboxAvatar
            // 
            this.pictureboxAvatar.Image = global::Restaurant_Management_Project.Properties.Resources.avatar_me;
            this.pictureboxAvatar.Location = new System.Drawing.Point(68, 12);
            this.pictureboxAvatar.Name = "pictureboxAvatar";
            this.pictureboxAvatar.Size = new System.Drawing.Size(93, 102);
            this.pictureboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxAvatar.TabIndex = 0;
            this.pictureboxAvatar.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.formOrder1);
            this.panel4.Controls.Add(this.formCrew1);
            this.panel4.Controls.Add(this.formMenu1);
            this.panel4.Controls.Add(this.formDashboard21);
            this.panel4.Controls.Add(this.formStatistic1);
            this.panel4.Location = new System.Drawing.Point(238, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 800);
            this.panel4.TabIndex = 1;
            // 
            // formOrder1
            // 
            this.formOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.formOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.formOrder1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formOrder1.Location = new System.Drawing.Point(-3, 0);
            this.formOrder1.Name = "formOrder1";
            this.formOrder1.Size = new System.Drawing.Size(962, 800);
            this.formOrder1.TabIndex = 5;
            // 
            // formCrew1
            // 
            this.formCrew1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.formCrew1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formCrew1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formCrew1.Location = new System.Drawing.Point(0, 0);
            this.formCrew1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.formCrew1.Name = "formCrew1";
            this.formCrew1.Size = new System.Drawing.Size(962, 800);
            this.formCrew1.TabIndex = 4;
            // 
            // formMenu1
            // 
            this.formMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.formMenu1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.formMenu1.Location = new System.Drawing.Point(-4, 0);
            this.formMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.formMenu1.Name = "formMenu1";
            this.formMenu1.Size = new System.Drawing.Size(962, 800);
            this.formMenu1.TabIndex = 2;
            // 
            // formDashboard21
            // 
            this.formDashboard21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.formDashboard21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formDashboard21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.formDashboard21.Location = new System.Drawing.Point(-3, 0);
            this.formDashboard21.Margin = new System.Windows.Forms.Padding(4);
            this.formDashboard21.Name = "formDashboard21";
            this.formDashboard21.Size = new System.Drawing.Size(962, 800);
            this.formDashboard21.TabIndex = 1;
            // 
            // formStatistic1
            // 
            this.formStatistic1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.formStatistic1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formStatistic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.formStatistic1.Location = new System.Drawing.Point(-3, 0);
            this.formStatistic1.Margin = new System.Windows.Forms.Padding(5);
            this.formStatistic1.Name = "formStatistic1";
            this.formStatistic1.Size = new System.Drawing.Size(962, 800);
            this.formStatistic1.TabIndex = 0;
            // 
            // restaurant_ManagementDataSet1
            // 
            this.restaurant_ManagementDataSet1.DataSetName = "Restaurant_ManagementDataSet";
            this.restaurant_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurant_ManagementDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureboxAvatar;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelNav;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private formStatistic formStatistic1;
        private formDashboard2 formDashboard21;
        private formMenu formMenu1;
        private Restaurant_ManagementDataSet restaurant_ManagementDataSet1;
        private formCrew formCrew1;
        private formOrder formOrder1;
    }
}