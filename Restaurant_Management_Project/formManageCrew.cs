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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Restaurant_Management_Project
{
    public partial class formManageCrew : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");
        public formManageCrew()
        {
            InitializeComponent();

            displayCrewData();
        }

        public void displayCrewData()
        {
            CrewData cd = new CrewData();
            List<CrewData> listData = cd.crewListData();

            datagridviewShowCrew.DataSource = listData;
        }


        private List<Department> GetDepartmentList()
        {
            List<Department> departments = new List<Department>();

            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                    string query = "SELECT department_id, department_name FROM department";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Department department = new Department
                                {
                                    DepartmentID = Convert.ToInt32(reader["department_id"]),
                                    DepartmentName = reader["department_name"].ToString()
                                };
                                departments.Add(department);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            return departments;
        }

        // Department sınıfını tanımladık.
        public class Department
        {
            public int DepartmentID { get; set; }
            public string DepartmentName { get; set; }
        }

        private void Form_Load(object sender, EventArgs e)
        {


            listboxCrewDepartment.DataSource = GetDepartmentList();
            listboxCrewDepartment.DisplayMember = "DepartmentName";
            listboxCrewDepartment.ValueMember = "DepartmentID";
        }


        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            if (textboxCrewName.Text == ""
            || textboxCrewLastName.Text == ""
            || listboxCrewDepartment.Text == ""
            || textboxCrewEmail.Text == ""
            || textboxCrewPhone.Text == ""
            || comboBoxCrewShift.Text == ""
            || textboxCrewSalary.Text == "" 
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
                        string checkCrewID = "SELECT COUNT(*) FROM employees WHERE employee_id = @employeeID";

                        using (SqlCommand checkCrew = new SqlCommand(checkCrewID, connect))
                        {
                            checkCrew.Parameters.AddWithValue("@employeeID", textboxCrewID.Text.Trim());
                            int count = (int)checkCrew.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(textboxCrewID.Text.Trim() + " zaten alınmıştır."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employees " +
                                    "( first_name, last_name, department_name" +     //column names
                                    ", email, phone, shift, hire_date, salary ) " +
                                    "VALUES( @employeeName, @employeeLastName, @employeeDepartmentName" +
                                    ", @employeeEmail, @employeePhone, @employeeShift, @employeeHireDate, @employeeSalary)";

                                /*
                                string path = Path.Combine(@"C:\Users\beyza\OneDrive\Masaüstü\Bitirme_Projesi\Restaurant_Management_Project\Restaurant_Management_Project\Directory\Crew\"
                                    + textboxCrewID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(pictureboxAddCrewImage.ImageLocation, path, true);
                                */


                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", textboxCrewID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeName", textboxCrewName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeLastName", textboxCrewLastName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeDepartmentID", Convert.ToInt32(listboxCrewDepartment.SelectedValue));
                                    cmd.Parameters.AddWithValue("@employeeDepartmentName", listboxCrewDepartment.Text);
                                    cmd.Parameters.AddWithValue("@employeeEmail", textboxCrewEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeePhone", textboxCrewPhone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeShift", comboBoxCrewShift.Text.Trim());
                                    cmd.Parameters.AddWithValue("@employeeHireDate", today);
                                    cmd.Parameters.AddWithValue("@employeeSalary", textboxCrewSalary.Text.Trim());
                                    //cmd.Parameters.AddWithValue("@employeeImage", path);



                                    cmd.ExecuteNonQuery();

                                    displayCrewData();

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

        //işlemler sonrasında form alanındaki verileri temizler. 
        public void clearFields()
        {
            textboxCrewID.Text = "";
            textboxCrewName.Text = "";
            textboxCrewLastName.Text = "";
            listboxCrewDepartment.SelectedIndex = -1;
            textboxCrewEmail.Text = "";
            textboxCrewPhone.Text = "";
            comboBoxCrewShift.SelectedIndex = -1;
            textboxCrewSalary.Text = "";
            //pictureboxAddCrewImage.Image = null;
        }

        private void formManageCrew_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'restaurant_ManagementDataSet.department' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmentTableAdapter.Fill(this.restaurant_ManagementDataSet.department);

        }

        /*
        private void buttonAddCrewImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png) | *.jpg; *.png";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;

                    pictureboxAddCrewImage.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:  " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void datagridviewShowCrew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewShowCrew.Rows[e.RowIndex];
                textboxCrewID.Text = row.Cells[0].Value.ToString();
                textboxCrewName.Text = row.Cells[1].Value.ToString();
                textboxCrewLastName.Text = row.Cells[2].Value.ToString();
                listboxCrewDepartment.Text = row.Cells[3].Value.ToString();
                textboxCrewEmail.Text = row.Cells[4].Value.ToString();
                textboxCrewPhone.Text = row.Cells[5].Value.ToString();
                comboBoxCrewShift.Text = row.Cells[7].Value.ToString();
                textboxCrewSalary.Text = row.Cells[8].Value.ToString();
                

                /*string imagePath = row.Cells[9].Value.ToString();

                if (imagePath != null)
                {
                    pictureboxAddCrewImage.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureboxAddCrewImage.Image = null;
                }*/
            }
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (textboxCrewName.Text == ""
             || textboxCrewLastName.Text == ""
             || listboxCrewDepartment.Text == ""
             || textboxCrewEmail.Text == ""
             || textboxCrewPhone.Text == ""
             || comboBoxCrewShift.Text == ""
             || textboxCrewSalary.Text == ""
             )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("ID değeri " + textboxCrewID.Text.Trim() + " olan yemeği güncellemek istiyor musunuz?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();


                        DateTime today = DateTime.Today;
                        string updateData = "UPDATE employees SET first_name = @employeeName , last_name = @employeeLastName " +
                            ", department_id = @employeeDepartmentID, department_name = @employeeDepartmentName" +
                            ", email = @employeeEmail, phone = @employeePhone , shift = @employeeShift, hire_date = @employeeHireDate, salary= @employeeSalary " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {

                            cmd.Parameters.AddWithValue("@employeeID", textboxCrewID.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeName", textboxCrewName.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeLastName", textboxCrewLastName.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeDepartmentID", Convert.ToInt32(listboxCrewDepartment.SelectedValue));
                            cmd.Parameters.AddWithValue("@employeeDepartmentName", listboxCrewDepartment.Text);
                            cmd.Parameters.AddWithValue("@employeeEmail", textboxCrewEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeePhone", textboxCrewPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeShift", comboBoxCrewShift.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeHireDate", today);
                            cmd.Parameters.AddWithValue("@employeeSalary", textboxCrewSalary.Text.Trim());
                            


                            cmd.ExecuteNonQuery();


                            //güncellenen veri datagridview'da görüntülenir. 
                            displayCrewData();

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

        private void buttonClearEmployee_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (textboxCrewID.Text == "")
            {
                MessageBox.Show("Lütfen bir ID değeri seçin."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("ID değeri " + textboxCrewID.Text.Trim() + " olan çalışanı silmek istiyor musunuz?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM employees WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@employeeID", textboxCrewID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayCrewData();

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

        private void textboxCrewEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonManageMenu_Click(object sender, EventArgs e)
        {
            formManageMenu manageMenuForm = new formManageMenu();
            manageMenuForm.Show();
            this.Hide();
        }

        private void buttonManageOrder_Click(object sender, EventArgs e)
        {
            formManageOrder manageOrderForm = new formManageOrder();
            manageOrderForm.Show();
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
    }
}
