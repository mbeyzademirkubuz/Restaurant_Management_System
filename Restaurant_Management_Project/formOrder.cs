using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Restaurant_Management_Project
{
    public partial class formOrder : UserControl
    {

        public static int getCustID;


        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");


        public formOrder()
        {
            InitializeComponent();

            displayAvailableProds();

            displayAllOrders();

            displayTotalPrice();
        }


        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableProds();
            displayAllOrders();

            displayTotalPrice();
        }


        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductsData();

            datagridviewShowActiveOrder.DataSource = listData;
        }

        public void displayAllOrders()
        {
            CashierOrderData allOrders = new CashierOrderData();

            List<CashierOrderData> listData = allOrders.ordersListData();

            datagridviewShowTotalOrder.DataSource = listData;
        }

        private float totalPrice;

        public void displayTotalPrice()
        {
            IDGenerator();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(total_cost) FROM orders WHERE customer_id = @custId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custId", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            labelOrderPrices.Text = totalPrice.ToString("0.00");
                        }
                        else
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                // Uygulamayı kapat
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonOrderManagement_Click(object sender, EventArgs e)
        {
            formManageOrder manageOrderForm = new formManageOrder();
            manageOrderForm.Show();
            this.Hide();
        }

        private void buttonAddActiveOrder_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (listboxOrderDetail.SelectedIndex == -1 || comboboxActiveOrderFoodID.SelectedIndex == -1
                || labelActiveFoodName.Text == "" || numericupdownActiveOrderQuantity.Value == 0
                || labelActiveOrderPrice.Text == "")
            {
                MessageBox.Show("Lütfen önce seçim yapınız.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM food WHERE food_name = @foodName";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@foodName", comboboxActiveOrderFoodID.Text.Trim());

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["food_price"];
                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertOrder = "INSERT INTO orders ( order_name, order_table, order_situation, order_people, total_cost , food_type, order_date , customer_id) " +
                            "VALUES( @foodName, @orderTable,  'Tamamlandı', @qty , @prodPrice, @prodType , @orderDate,  @customerID)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@customerID", idGen);
                            //cmd.Parameters.AddWithValue("@food_id", comboBoxActiveOrderTable.Text.Trim());
                            cmd.Parameters.AddWithValue("@foodName", comboboxActiveOrderFoodID.Text.Trim());
                            // cmd.Parameters.AddWithValue("@food_id", labelActiveFoodName.Text.Trim());
                           
                            cmd.Parameters.AddWithValue("@prodType", listboxOrderDetail.Text.Trim());
                            cmd.Parameters.AddWithValue("@orderTable", comboBoxActiveOrderTable.Text.Trim());

                            float totalPrice = (getPrice * (int)numericupdownActiveOrderQuantity.Value);

                            cmd.Parameters.AddWithValue("@qty", numericupdownActiveOrderQuantity.Value);
                            cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@orderDate", today);

                            cmd.ExecuteNonQuery();


                            displayAllOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayTotalPrice();
        }


        private int idGen = 0;
        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False"))
            {
                connect.Open();
                string selectID = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                    getCustID = idGen;
                }
            }
        }

        private void listboxOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxActiveOrderFoodID.SelectedIndex = -1;
            comboboxActiveOrderFoodID.Items.Clear();
            labelActiveFoodName.Text = "";
            labelActiveOrderPrice.Text = "";



            string selectedValue = listboxOrderDetail.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM food WHERE food_type = '{selectedValue}' AND food_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["food_name"].ToString();

                                    comboboxActiveOrderFoodID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error: " + exx, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboboxActiveOrderFoodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboboxActiveOrderFoodID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM food WHERE food_name = '{selectedValue}' AND food_status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["food_name"].ToString();
                                    string prodPrice = reader["food_price"].ToString();

                                    labelActiveFoodName.Text = prodName;
                                    labelActiveOrderPrice.Text = prodPrice;

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void labelOrderAmounts_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelOrderAmounts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(labelOrderAmounts.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        labelOrderAmounts.Text = "";
                        labelOrderChange.Text = "";
                    }
                    else
                    {
                        labelOrderChange.Text = getChange.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    labelOrderAmounts.Text = "";
                    labelOrderChange.Text = "";
                }
            }
        }

        private void buttonPayActiveOrder_Click(object sender, EventArgs e)
        {

            if (labelOrderAmounts.Text == "" || datagridviewShowTotalOrder.Rows.Count < 0)
            {
                MessageBox.Show("Bir şeyler yanlış gitti.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Ödeme gerçekleşsin mi?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            IDGenerator();


                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", labelOrderAmounts.Text);
                                cmd.Parameters.AddWithValue("@change", labelOrderChange.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Ödeme gerçekleşti!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bağlantı Hatası: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();
        }


        private int rowIndex = 0;

        private void buttonReceiptActiveOrder_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Magnolia Restaurant";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (datagridviewShowTotalOrder.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < datagridviewShowTotalOrder.Rows.Count)
            {
                DataGridViewRow row = datagridviewShowTotalOrder.Rows[rowIndex];

                for (int i = 0; i < datagridviewShowTotalOrder.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Toplam Tutar : \t$" + totalPrice + "\nTutar : \t$"
                + labelOrderAmounts.Text + "\n\t\t------------\nPara Üstü : \t$" + labelOrderChange.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);
        }
    }
}
