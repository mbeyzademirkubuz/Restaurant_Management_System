using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_Project
{
    public partial class formManageMenu : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");

        public formManageMenu()
        {
            InitializeComponent();

            //To display data from database to food table
            displayMenuData();
        }

        public void displayMenuData()
        {
            MenuData md = new MenuData();
            List<MenuData> listData = md.menuListData(); 

            datagridviewShowMenu.DataSource = listData;
            datagridviewShowMenu.Refresh();  // DataGridView'i yenilemek için

        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            if (textboxFoodName.Text == ""
             || listboxFoodType.Text == ""
             || textboxFoodPrice.Text == ""
             || textboxFoodDescription.Text == ""
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
                        string checkfoodID = "SELECT COUNT(*) FROM food WHERE food_id = @foodID";

                        using (SqlCommand checkFood = new SqlCommand(checkfoodID, connect))
                        {
                            checkFood.Parameters.AddWithValue("@foodID", textboxFoodID.Text.Trim());
                            int count = (int)checkFood.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(textboxFoodID.Text.Trim() + " zaten alınmıştır."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string insertData = "INSERT INTO food " +
                                    "( food_name, food_type, food_price" +     //column names
                                    ", food_description, food_image) " +
                                    "VALUES( @foodName, @foodType, @foodPrice" +
                                    ", @foodDesc, @foodImage)";


                                string path = Path.Combine(@"C:\Users\beyza\OneDrive\Masaüstü\Bitirme_Projesi\Restaurant_Management_Project\Restaurant_Management_Project\Directory\"
                                    + textboxFoodID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(pictureboxAddFoodImage.ImageLocation, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@foodID", textboxFoodID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodName", textboxFoodName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodType", listboxFoodType.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodPrice", textboxFoodPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodDesc", textboxFoodDescription.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodImage", path);



                                    cmd.ExecuteNonQuery();

                                    displayMenuData();

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
        
        private void buttonAddFoodImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png) | *.jpg; *.png";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    pictureboxAddFoodImage.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:  " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tablodaki herhangi bir kayıda tıklandığında tüm alanları dolu getirir.

        private void datagridviewShowMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewShowMenu.Rows[e.RowIndex];
                textboxFoodID.Text = row.Cells[0].Value.ToString();
                textboxFoodName.Text = row.Cells[1].Value.ToString();
                listboxFoodType.Text = row.Cells[2].Value.ToString();
                textboxFoodPrice.Text = row.Cells[3].Value.ToString();
                textboxFoodDescription.Text = row.Cells[4].Value.ToString();

               /* string imagePath = row.Cells[5].Value.ToString();

                if(imagePath != null)
                {
                    pictureboxAddFoodImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureboxAddFoodImage.Image = null;
                }*/
            }

        }

        //işlemler sonrasında form alanındaki verileri temizler. 
        public void clearFields()
        {
            textboxFoodName.Text = "";
            listboxFoodType.SelectedIndex = -1;
            textboxFoodPrice.Text = "";
            textboxFoodDescription.Text = "";
            pictureboxAddFoodImage.Image = null;
        }

        private void buttonUpdateFood_Click(object sender, EventArgs e)
        {
            if (textboxFoodName.Text == ""
            || listboxFoodType.Text == ""
            || textboxFoodPrice.Text == ""
            || textboxFoodDescription.Text == ""
            )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Yemek ID'si " + textboxFoodID.Text.Trim() + " olan yemeği güncellemek istiyor musunuz?", "Confirmation Message" , 
                    MessageBoxButtons.YesNo , MessageBoxIcon.Information);
                if(check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE food SET food_name = @foodName , food_type = @foodType , food_price = @foodPrice" +
                              ", food_description = @foodDesc " +
                              "WHERE food_id = @foodID"; 

                                using (SqlCommand cmd = new SqlCommand(updateData, connect))
                                {
                                    
                                    cmd.Parameters.AddWithValue("@foodName", textboxFoodName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodType", listboxFoodType.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodPrice", textboxFoodPrice.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodDesc", textboxFoodDescription.Text.Trim());
                                    cmd.Parameters.AddWithValue("@foodID", textboxFoodID.Text.Trim());



                                    cmd.ExecuteNonQuery();

                                    displayMenuData();

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

        private void buttonClearFood_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            if (textboxFoodID.Text == "")
            {
                MessageBox.Show("Lütfen bir yemek ID'si seçin."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Yemek ID'si " + textboxFoodID.Text.Trim() + " olan yemeği silmek istiyor musunuz?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM food WHERE food_id = @foodID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@foodID", textboxFoodID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayMenuData();

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

        private void listboxFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textboxFoodID_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonManageOrder_Click(object sender, EventArgs e)
        {
            formManageOrder manageOrderForm = new formManageOrder();
            manageOrderForm.Show();
            this.Hide();
        }
    }
}
