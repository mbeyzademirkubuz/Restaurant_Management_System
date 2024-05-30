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
using System.Runtime.Remoting.Contexts;

namespace Restaurant_Management_Project
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");



        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textboxRegisterUsername.Text == ""
                 || textboxRegisterPassword.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz."
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        // TO CHECK IF THE USER IS EXISTING ALREADY
                        string selectUsername = "SELECT COUNT(user_id) FROM login WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, conn))
                        {
                            checkUser.Parameters.AddWithValue("@username", textboxRegisterUsername.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(textboxRegisterUsername.Text.Trim() + " zaten alınmış."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO login " +
                                    "(username, password, login_date) " +
                                    "VALUES(@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@username", textboxRegisterUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", textboxRegisterPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Kayıt başarılı!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    formLogin loginForm = new formLogin();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
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

        private void buttonExitReg_Click(object sender, EventArgs e)
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
