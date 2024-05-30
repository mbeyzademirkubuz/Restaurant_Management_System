using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_Project
{
    public partial class formManageOrder : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");

        public formManageOrder()
        {
            InitializeComponent();

            displayOrderData();
        }

        public void displayOrderData()
        {
            OrderData cd = new OrderData();
            List<OrderData> listData = cd.orderListData();

            datagridviewShowOrder.DataSource = listData;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {

            if (
                textboxOrderID.Text == ""
            || textboxOrderName.Text == ""
            || textboxOrderTable.Text == ""
            || listboxOrderDetail.Text == ""
            || textboxOrderPeople.Text == ""
            || textboxTotalCost.Text == ""
            
            )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkOrderID = "SELECT COUNT(*) FROM orders WHERE order_id = @orderID";

                        using (SqlCommand checkOrder = new SqlCommand(checkOrderID, connect))
                        {
                            checkOrder.Parameters.AddWithValue("@orderID", textboxOrderID.Text.Trim());
                            int count = (int)checkOrder.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(textboxOrderID.Text.Trim() + " zaten alınmıştır."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO orders " +
                                    "( order_name, order_table, order_situation" +     //column names
                                    ", order_people, total_cost , order_date ) " +
                                    "VALUES( @orderName, @orderTable , @orderSituation" +
                                    ", @orderPeople, @totalCost , @orderDate)";



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@orderID", textboxOrderID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@orderName", textboxOrderName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@orderTable", textboxOrderTable.Text.Trim());
                                    cmd.Parameters.AddWithValue("@orderSituation", listboxOrderDetail.Text);
                                    cmd.Parameters.AddWithValue("@orderPeople", textboxOrderPeople.Text.Trim());
                                    cmd.Parameters.AddWithValue("@totalCost", textboxTotalCost.Text.Trim());
                                    cmd.Parameters.AddWithValue("@orderDate", today);
                                    



                                    cmd.ExecuteNonQuery();

                                    displayOrderData();

                                    MessageBox.Show("Başarıyla eklendi!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }


        public void clearFields()
        {
            textboxOrderID.Text = "";
            textboxOrderName.Text = "";
            textboxOrderTable.Text = "";
            listboxOrderDetail.SelectedIndex = -1;
            textboxOrderPeople.Text = "";
            textboxTotalCost.Text = "";
            
        }

        private void buttonManageMenu_Click(object sender, EventArgs e)
        {
            formManageMenu manageMenuForm = new formManageMenu();
            manageMenuForm.Show();
            this.Hide();
        }

        private void buttonManageCrew_Click(object sender, EventArgs e)
        {
            formManageCrew manageCrewForm = new formManageCrew();
            manageCrewForm.Show();
            this.Hide();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            formDashboard dashboardForm = new formDashboard();
            dashboardForm.Show();
            this.Hide();
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

        private void datagridviewShowOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewShowOrder.Rows[e.RowIndex];
                textboxOrderID.Text = row.Cells[0].Value.ToString();
                textboxOrderName.Text = row.Cells[1].Value.ToString();
                textboxOrderTable.Text = row.Cells[2].Value.ToString();
                listboxOrderDetail.Text = row.Cells[3].Value.ToString();
                textboxOrderPeople.Text = row.Cells[4].Value.ToString();
                textboxTotalCost.Text = row.Cells[5].Value.ToString();

            }
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (
                       textboxOrderID.Text == ""
                    || textboxOrderName.Text == ""
                    || textboxOrderTable.Text == ""
                    || listboxOrderDetail.Text == ""
                    || textboxOrderPeople.Text == ""
                    || textboxTotalCost.Text == ""

                )
                
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("ID değeri " + textboxOrderID.Text.Trim() + " olan siparişi güncellemek istiyor musunuz?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();


                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE orders SET order_name = @OrderName , order_table = @orderTable " +
                            ", order_situation = @orderSituation, order_people = @orderPeople" +
                            ", total_cost = @totalCost " +
                            "WHERE order_id = @orderID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@orderID", textboxOrderID.Text.Trim());
                            cmd.Parameters.AddWithValue("@OrderName", textboxOrderName.Text.Trim());
                            cmd.Parameters.AddWithValue("@orderTable", textboxOrderTable.Text.Trim());
                            cmd.Parameters.AddWithValue("@orderSituation", listboxOrderDetail.Text.Trim());
                            cmd.Parameters.AddWithValue("@orderPeople", textboxOrderTable.Text);
                            cmd.Parameters.AddWithValue("@totalCost", textboxTotalCost.Text.Trim());


                            cmd.ExecuteNonQuery();


                            //güncellenen veri datagridview'da görüntülenir. 
                            displayOrderData();

                            MessageBox.Show("Başarıyla güncellendi!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("İptal edildi."
                 , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (textboxOrderID.Text == "")
            {
                MessageBox.Show("Lütfen bir ID değeri seçin."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("ID değeri " + textboxOrderID.Text.Trim() + " olan çalışanı silmek istiyor musunuz?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM orders WHERE order_id = @orderID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@orderID", textboxOrderID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayOrderData();

                            MessageBox.Show("Başarıyla silindi!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex
                            , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
