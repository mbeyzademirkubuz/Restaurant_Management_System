namespace Restaurant_Management_Project
{
    partial class formOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrder));
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelOrders = new System.Windows.Forms.Label();
            this.textboxSearch2 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOrderManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewShowActiveOrder = new System.Windows.Forms.DataGridView();
            this.labelActiveOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxActiveOrderTable = new System.Windows.Forms.ComboBox();
            this.labelOrderTable = new System.Windows.Forms.Label();
            this.buttonClearActiveOrder = new System.Windows.Forms.Button();
            this.buttonRemoveActiveOrder = new System.Windows.Forms.Button();
            this.buttonAddActiveOrder = new System.Windows.Forms.Button();
            this.labelActiveOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.labelOrderQuantity = new System.Windows.Forms.Label();
            this.numericupdownActiveOrderQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelActiveFoodName = new System.Windows.Forms.Label();
            this.labelOrderName = new System.Windows.Forms.Label();
            this.comboboxActiveOrderFoodID = new System.Windows.Forms.ComboBox();
            this.labelFoodID = new System.Windows.Forms.Label();
            this.listboxOrderDetail = new System.Windows.Forms.ComboBox();
            this.labelOrderProductType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonReceiptActiveOrder = new System.Windows.Forms.Button();
            this.buttonPayActiveOrder = new System.Windows.Forms.Button();
            this.labelOrderChange = new System.Windows.Forms.Label();
            this.labelActiveOrderChange = new System.Windows.Forms.Label();
            this.labelActiveOrderAmount = new System.Windows.Forms.Label();
            this.labelOrderPrices = new System.Windows.Forms.Label();
            this.labelOrderActivePrice = new System.Windows.Forms.Label();
            this.labelTotalOrder = new System.Windows.Forms.Label();
            this.labelOrderAmounts = new System.Windows.Forms.TextBox();
            this.datagridviewShowTotalOrder = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowActiveOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownActiveOrderQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowTotalOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel4.Controls.Add(this.labelOrders);
            this.panel4.Controls.Add(this.textboxSearch2);
            this.panel4.Controls.Add(this.buttonExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 72);
            this.panel4.TabIndex = 30;
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrders.Location = new System.Drawing.Point(19, 8);
            this.labelOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(205, 49);
            this.labelOrders.TabIndex = 20;
            this.labelOrders.Text = "Siparişler";
            // 
            // textboxSearch2
            // 
            this.textboxSearch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.textboxSearch2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSearch2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textboxSearch2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.textboxSearch2.Location = new System.Drawing.Point(550, 26);
            this.textboxSearch2.Margin = new System.Windows.Forms.Padding(2);
            this.textboxSearch2.Multiline = true;
            this.textboxSearch2.Name = "textboxSearch2";
            this.textboxSearch2.Size = new System.Drawing.Size(354, 25);
            this.textboxSearch2.TabIndex = 21;
            this.textboxSearch2.Text = "    Sistem içinde ara...";
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Restaurant_Management_Project.Properties.Resources.close;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(910, 19);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 34);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOrderManagement
            // 
            this.buttonOrderManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.buttonOrderManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.buttonOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrderManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.buttonOrderManagement.Location = new System.Drawing.Point(681, 96);
            this.buttonOrderManagement.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrderManagement.Name = "buttonOrderManagement";
            this.buttonOrderManagement.Size = new System.Drawing.Size(230, 43);
            this.buttonOrderManagement.TabIndex = 40;
            this.buttonOrderManagement.Text = " Siparişleri Yönet";
            this.buttonOrderManagement.UseVisualStyleBackColor = false;
            this.buttonOrderManagement.Click += new System.EventHandler(this.buttonOrderManagement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.datagridviewShowActiveOrder);
            this.panel1.Controls.Add(this.labelActiveOrder);
            this.panel1.Location = new System.Drawing.Point(28, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 373);
            this.panel1.TabIndex = 43;
            // 
            // datagridviewShowActiveOrder
            // 
            this.datagridviewShowActiveOrder.AllowUserToAddRows = false;
            this.datagridviewShowActiveOrder.AllowUserToDeleteRows = false;
            this.datagridviewShowActiveOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewShowActiveOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewShowActiveOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridviewShowActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewShowActiveOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.datagridviewShowActiveOrder.EnableHeadersVisualStyles = false;
            this.datagridviewShowActiveOrder.Location = new System.Drawing.Point(7, 37);
            this.datagridviewShowActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.datagridviewShowActiveOrder.Name = "datagridviewShowActiveOrder";
            this.datagridviewShowActiveOrder.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewShowActiveOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridviewShowActiveOrder.Size = new System.Drawing.Size(590, 328);
            this.datagridviewShowActiveOrder.TabIndex = 4;
            // 
            // labelActiveOrder
            // 
            this.labelActiveOrder.AutoSize = true;
            this.labelActiveOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrder.Location = new System.Drawing.Point(12, 10);
            this.labelActiveOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActiveOrder.Name = "labelActiveOrder";
            this.labelActiveOrder.Size = new System.Drawing.Size(153, 25);
            this.labelActiveOrder.TabIndex = 3;
            this.labelActiveOrder.Text = "Aktif Siparişler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.comboBoxActiveOrderTable);
            this.panel2.Controls.Add(this.labelOrderTable);
            this.panel2.Controls.Add(this.buttonClearActiveOrder);
            this.panel2.Controls.Add(this.buttonRemoveActiveOrder);
            this.panel2.Controls.Add(this.buttonAddActiveOrder);
            this.panel2.Controls.Add(this.labelActiveOrderPrice);
            this.panel2.Controls.Add(this.labelOrderPrice);
            this.panel2.Controls.Add(this.labelOrderQuantity);
            this.panel2.Controls.Add(this.numericupdownActiveOrderQuantity);
            this.panel2.Controls.Add(this.labelActiveFoodName);
            this.panel2.Controls.Add(this.labelOrderName);
            this.panel2.Controls.Add(this.comboboxActiveOrderFoodID);
            this.panel2.Controls.Add(this.labelFoodID);
            this.panel2.Controls.Add(this.listboxOrderDetail);
            this.panel2.Controls.Add(this.labelOrderProductType);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(27, 528);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 248);
            this.panel2.TabIndex = 44;
            // 
            // comboBoxActiveOrderTable
            // 
            this.comboBoxActiveOrderTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxActiveOrderTable.DisplayMember = "department_name";
            this.comboBoxActiveOrderTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxActiveOrderTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxActiveOrderTable.FormattingEnabled = true;
            this.comboBoxActiveOrderTable.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Hazır",
            "Tamamlandı"});
            this.comboBoxActiveOrderTable.Location = new System.Drawing.Point(430, 104);
            this.comboBoxActiveOrderTable.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActiveOrderTable.Name = "comboBoxActiveOrderTable";
            this.comboBoxActiveOrderTable.Size = new System.Drawing.Size(149, 27);
            this.comboBoxActiveOrderTable.TabIndex = 22;
            this.comboBoxActiveOrderTable.ValueMember = "department_id";
            // 
            // labelOrderTable
            // 
            this.labelOrderTable.AutoSize = true;
            this.labelOrderTable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderTable.Location = new System.Drawing.Point(359, 110);
            this.labelOrderTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderTable.Name = "labelOrderTable";
            this.labelOrderTable.Size = new System.Drawing.Size(59, 19);
            this.labelOrderTable.TabIndex = 21;
            this.labelOrderTable.Text = "Masa :";
            // 
            // buttonClearActiveOrder
            // 
            this.buttonClearActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonClearActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonClearActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClearActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonClearActiveOrder.Location = new System.Drawing.Point(455, 179);
            this.buttonClearActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearActiveOrder.Name = "buttonClearActiveOrder";
            this.buttonClearActiveOrder.Size = new System.Drawing.Size(124, 42);
            this.buttonClearActiveOrder.TabIndex = 20;
            this.buttonClearActiveOrder.Text = "Temizle";
            this.buttonClearActiveOrder.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveActiveOrder
            // 
            this.buttonRemoveActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonRemoveActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonRemoveActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRemoveActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonRemoveActiveOrder.Location = new System.Drawing.Point(250, 179);
            this.buttonRemoveActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveActiveOrder.Name = "buttonRemoveActiveOrder";
            this.buttonRemoveActiveOrder.Size = new System.Drawing.Size(124, 42);
            this.buttonRemoveActiveOrder.TabIndex = 19;
            this.buttonRemoveActiveOrder.Text = "Kaldır";
            this.buttonRemoveActiveOrder.UseVisualStyleBackColor = false;
            // 
            // buttonAddActiveOrder
            // 
            this.buttonAddActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonAddActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonAddActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonAddActiveOrder.Location = new System.Drawing.Point(55, 179);
            this.buttonAddActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddActiveOrder.Name = "buttonAddActiveOrder";
            this.buttonAddActiveOrder.Size = new System.Drawing.Size(124, 42);
            this.buttonAddActiveOrder.TabIndex = 18;
            this.buttonAddActiveOrder.Text = "Ekle";
            this.buttonAddActiveOrder.UseVisualStyleBackColor = false;
            this.buttonAddActiveOrder.Click += new System.EventHandler(this.buttonAddActiveOrder_Click);
            // 
            // labelActiveOrderPrice
            // 
            this.labelActiveOrderPrice.AutoSize = true;
            this.labelActiveOrderPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrderPrice.Location = new System.Drawing.Point(104, 110);
            this.labelActiveOrderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActiveOrderPrice.Name = "labelActiveOrderPrice";
            this.labelActiveOrderPrice.Size = new System.Drawing.Size(18, 19);
            this.labelActiveOrderPrice.TabIndex = 17;
            this.labelActiveOrderPrice.Text = "0";
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderPrice.Location = new System.Drawing.Point(36, 110);
            this.labelOrderPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(58, 19);
            this.labelOrderPrice.TabIndex = 16;
            this.labelOrderPrice.Text = "Tutar : ";
            // 
            // labelOrderQuantity
            // 
            this.labelOrderQuantity.AutoSize = true;
            this.labelOrderQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderQuantity.Location = new System.Drawing.Point(364, 64);
            this.labelOrderQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderQuantity.Name = "labelOrderQuantity";
            this.labelOrderQuantity.Size = new System.Drawing.Size(54, 19);
            this.labelOrderQuantity.TabIndex = 15;
            this.labelOrderQuantity.Text = "Adet: ";
            // 
            // numericupdownActiveOrderQuantity
            // 
            this.numericupdownActiveOrderQuantity.Location = new System.Drawing.Point(430, 62);
            this.numericupdownActiveOrderQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.numericupdownActiveOrderQuantity.Name = "numericupdownActiveOrderQuantity";
            this.numericupdownActiveOrderQuantity.Size = new System.Drawing.Size(149, 27);
            this.numericupdownActiveOrderQuantity.TabIndex = 14;
            // 
            // labelActiveFoodName
            // 
            this.labelActiveFoodName.AutoSize = true;
            this.labelActiveFoodName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveFoodName.Location = new System.Drawing.Point(104, 64);
            this.labelActiveFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActiveFoodName.Name = "labelActiveFoodName";
            this.labelActiveFoodName.Size = new System.Drawing.Size(99, 19);
            this.labelActiveFoodName.TabIndex = 13;
            this.labelActiveFoodName.Text = "Test Product";
            // 
            // labelOrderName
            // 
            this.labelOrderName.AutoSize = true;
            this.labelOrderName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderName.Location = new System.Drawing.Point(18, 64);
            this.labelOrderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderName.Name = "labelOrderName";
            this.labelOrderName.Size = new System.Drawing.Size(76, 19);
            this.labelOrderName.TabIndex = 12;
            this.labelOrderName.Text = "Yemek : ";
            // 
            // comboboxActiveOrderFoodID
            // 
            this.comboboxActiveOrderFoodID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxActiveOrderFoodID.DisplayMember = "department_name";
            this.comboboxActiveOrderFoodID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxActiveOrderFoodID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboboxActiveOrderFoodID.FormattingEnabled = true;
            this.comboboxActiveOrderFoodID.Location = new System.Drawing.Point(430, 21);
            this.comboboxActiveOrderFoodID.Margin = new System.Windows.Forms.Padding(2);
            this.comboboxActiveOrderFoodID.Name = "comboboxActiveOrderFoodID";
            this.comboboxActiveOrderFoodID.Size = new System.Drawing.Size(149, 27);
            this.comboboxActiveOrderFoodID.TabIndex = 11;
            this.comboboxActiveOrderFoodID.ValueMember = "department_id";
            this.comboboxActiveOrderFoodID.SelectedIndexChanged += new System.EventHandler(this.comboboxActiveOrderFoodID_SelectedIndexChanged);
            // 
            // labelFoodID
            // 
            this.labelFoodID.AutoSize = true;
            this.labelFoodID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFoodID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelFoodID.Location = new System.Drawing.Point(327, 23);
            this.labelFoodID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoodID.Name = "labelFoodID";
            this.labelFoodID.Size = new System.Drawing.Size(91, 19);
            this.labelFoodID.TabIndex = 10;
            this.labelFoodID.Text = "Yemek ID: ";
            // 
            // listboxOrderDetail
            // 
            this.listboxOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listboxOrderDetail.DisplayMember = "department_name";
            this.listboxOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listboxOrderDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listboxOrderDetail.FormattingEnabled = true;
            this.listboxOrderDetail.Items.AddRange(new object[] {
            "Avantaj Menüleri",
            "Aperatifler",
            "Pizza",
            "Burger",
            "Kahvaltı",
            "Makarna",
            "Döner",
            "Tavuk Tabağı",
            "Tatlılar",
            "Soğuk İçecekler",
            "Sıcak İçecekler",
            "Kokteyl"});
            this.listboxOrderDetail.Location = new System.Drawing.Point(108, 23);
            this.listboxOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.listboxOrderDetail.Name = "listboxOrderDetail";
            this.listboxOrderDetail.Size = new System.Drawing.Size(149, 27);
            this.listboxOrderDetail.TabIndex = 9;
            this.listboxOrderDetail.ValueMember = "department_id";
            this.listboxOrderDetail.SelectedIndexChanged += new System.EventHandler(this.listboxOrderDetail_SelectedIndexChanged);
            // 
            // labelOrderProductType
            // 
            this.labelOrderProductType.AutoSize = true;
            this.labelOrderProductType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderProductType.Location = new System.Drawing.Point(51, 24);
            this.labelOrderProductType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderProductType.Name = "labelOrderProductType";
            this.labelOrderProductType.Size = new System.Drawing.Size(43, 19);
            this.labelOrderProductType.TabIndex = 4;
            this.labelOrderProductType.Text = "Tür : ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.buttonReceiptActiveOrder);
            this.panel3.Controls.Add(this.buttonPayActiveOrder);
            this.panel3.Controls.Add(this.labelOrderChange);
            this.panel3.Controls.Add(this.labelActiveOrderChange);
            this.panel3.Controls.Add(this.labelActiveOrderAmount);
            this.panel3.Controls.Add(this.labelOrderPrices);
            this.panel3.Controls.Add(this.labelOrderActivePrice);
            this.panel3.Controls.Add(this.labelTotalOrder);
            this.panel3.Controls.Add(this.labelOrderAmounts);
            this.panel3.Controls.Add(this.datagridviewShowTotalOrder);
            this.panel3.Location = new System.Drawing.Point(639, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 625);
            this.panel3.TabIndex = 45;
            // 
            // buttonReceiptActiveOrder
            // 
            this.buttonReceiptActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonReceiptActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReceiptActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonReceiptActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceiptActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonReceiptActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonReceiptActiveOrder.Location = new System.Drawing.Point(8, 556);
            this.buttonReceiptActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReceiptActiveOrder.Name = "buttonReceiptActiveOrder";
            this.buttonReceiptActiveOrder.Size = new System.Drawing.Size(294, 43);
            this.buttonReceiptActiveOrder.TabIndex = 24;
            this.buttonReceiptActiveOrder.Text = "FATURA";
            this.buttonReceiptActiveOrder.UseVisualStyleBackColor = false;
            this.buttonReceiptActiveOrder.Click += new System.EventHandler(this.buttonReceiptActiveOrder_Click);
            // 
            // buttonPayActiveOrder
            // 
            this.buttonPayActiveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.buttonPayActiveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayActiveOrder.FlatAppearance.BorderSize = 0;
            this.buttonPayActiveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayActiveOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPayActiveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            this.buttonPayActiveOrder.Location = new System.Drawing.Point(8, 506);
            this.buttonPayActiveOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayActiveOrder.Name = "buttonPayActiveOrder";
            this.buttonPayActiveOrder.Size = new System.Drawing.Size(294, 43);
            this.buttonPayActiveOrder.TabIndex = 23;
            this.buttonPayActiveOrder.Text = "ÖDE";
            this.buttonPayActiveOrder.UseVisualStyleBackColor = false;
            this.buttonPayActiveOrder.Click += new System.EventHandler(this.buttonPayActiveOrder_Click);
            // 
            // labelOrderChange
            // 
            this.labelOrderChange.AutoSize = true;
            this.labelOrderChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderChange.Location = new System.Drawing.Point(154, 470);
            this.labelOrderChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderChange.Name = "labelOrderChange";
            this.labelOrderChange.Size = new System.Drawing.Size(18, 19);
            this.labelOrderChange.TabIndex = 22;
            this.labelOrderChange.Text = "0";
            // 
            // labelActiveOrderChange
            // 
            this.labelActiveOrderChange.AutoSize = true;
            this.labelActiveOrderChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrderChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrderChange.Location = new System.Drawing.Point(55, 470);
            this.labelActiveOrderChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActiveOrderChange.Name = "labelActiveOrderChange";
            this.labelActiveOrderChange.Size = new System.Drawing.Size(92, 19);
            this.labelActiveOrderChange.TabIndex = 21;
            this.labelActiveOrderChange.Text = "Pasa üstü : ";
            // 
            // labelActiveOrderAmount
            // 
            this.labelActiveOrderAmount.AutoSize = true;
            this.labelActiveOrderAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelActiveOrderAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelActiveOrderAmount.Location = new System.Drawing.Point(90, 435);
            this.labelActiveOrderAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActiveOrderAmount.Name = "labelActiveOrderAmount";
            this.labelActiveOrderAmount.Size = new System.Drawing.Size(57, 19);
            this.labelActiveOrderAmount.TabIndex = 20;
            this.labelActiveOrderAmount.Text = "Total : ";
            // 
            // labelOrderPrices
            // 
            this.labelOrderPrices.AutoSize = true;
            this.labelOrderPrices.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderPrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderPrices.Location = new System.Drawing.Point(154, 398);
            this.labelOrderPrices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderPrices.Name = "labelOrderPrices";
            this.labelOrderPrices.Size = new System.Drawing.Size(18, 19);
            this.labelOrderPrices.TabIndex = 19;
            this.labelOrderPrices.Text = "0";
            // 
            // labelOrderActivePrice
            // 
            this.labelOrderActivePrice.AutoSize = true;
            this.labelOrderActivePrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderActivePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderActivePrice.Location = new System.Drawing.Point(90, 400);
            this.labelOrderActivePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderActivePrice.Name = "labelOrderActivePrice";
            this.labelOrderActivePrice.Size = new System.Drawing.Size(58, 19);
            this.labelOrderActivePrice.TabIndex = 18;
            this.labelOrderActivePrice.Text = "Tutar : ";
            // 
            // labelTotalOrder
            // 
            this.labelTotalOrder.AutoSize = true;
            this.labelTotalOrder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTotalOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelTotalOrder.Location = new System.Drawing.Point(3, 10);
            this.labelTotalOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalOrder.Name = "labelTotalOrder";
            this.labelTotalOrder.Size = new System.Drawing.Size(89, 25);
            this.labelTotalOrder.TabIndex = 4;
            this.labelTotalOrder.Text = "Sipariş: ";
            // 
            // labelOrderAmounts
            // 
            this.labelOrderAmounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelOrderAmounts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrderAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(229)))));
            this.labelOrderAmounts.Location = new System.Drawing.Point(152, 435);
            this.labelOrderAmounts.Margin = new System.Windows.Forms.Padding(2);
            this.labelOrderAmounts.Multiline = true;
            this.labelOrderAmounts.Name = "labelOrderAmounts";
            this.labelOrderAmounts.Size = new System.Drawing.Size(120, 25);
            this.labelOrderAmounts.TabIndex = 5;
            this.labelOrderAmounts.TextChanged += new System.EventHandler(this.labelOrderAmounts_TextChanged);
            this.labelOrderAmounts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.labelOrderAmounts_KeyDown);
            // 
            // datagridviewShowTotalOrder
            // 
            this.datagridviewShowTotalOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(187)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewShowTotalOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridviewShowTotalOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewShowTotalOrder.DefaultCellStyle = dataGridViewCellStyle10;
            this.datagridviewShowTotalOrder.Location = new System.Drawing.Point(8, 37);
            this.datagridviewShowTotalOrder.Margin = new System.Windows.Forms.Padding(2);
            this.datagridviewShowTotalOrder.Name = "datagridviewShowTotalOrder";
            this.datagridviewShowTotalOrder.Size = new System.Drawing.Size(294, 336);
            this.datagridviewShowTotalOrder.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // formOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOrderManagement);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "formOrder";
            this.Size = new System.Drawing.Size(962, 800);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowActiveOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownActiveOrderQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewShowTotalOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.TextBox textboxSearch2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOrderManagement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelActiveOrder;
        private System.Windows.Forms.DataGridView datagridviewShowActiveOrder;
        private System.Windows.Forms.DataGridView datagridviewShowTotalOrder;
        private System.Windows.Forms.Label labelTotalOrder;
        private System.Windows.Forms.TextBox labelOrderAmounts;
        private System.Windows.Forms.Label labelOrderProductType;
        private System.Windows.Forms.NumericUpDown numericupdownActiveOrderQuantity;
        private System.Windows.Forms.Label labelActiveFoodName;
        private System.Windows.Forms.Label labelOrderName;
        private System.Windows.Forms.ComboBox comboboxActiveOrderFoodID;
        private System.Windows.Forms.Label labelFoodID;
        private System.Windows.Forms.ComboBox listboxOrderDetail;
        private System.Windows.Forms.Label labelActiveOrderPrice;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.Label labelOrderQuantity;
        private System.Windows.Forms.Button buttonClearActiveOrder;
        private System.Windows.Forms.Button buttonRemoveActiveOrder;
        private System.Windows.Forms.Button buttonAddActiveOrder;
        private System.Windows.Forms.Label labelActiveOrderAmount;
        private System.Windows.Forms.Label labelOrderPrices;
        private System.Windows.Forms.Label labelOrderActivePrice;
        private System.Windows.Forms.Button buttonReceiptActiveOrder;
        private System.Windows.Forms.Button buttonPayActiveOrder;
        private System.Windows.Forms.Label labelOrderChange;
        private System.Windows.Forms.Label labelActiveOrderChange;
        private System.Windows.Forms.ComboBox comboBoxActiveOrderTable;
        private System.Windows.Forms.Label labelOrderTable;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
