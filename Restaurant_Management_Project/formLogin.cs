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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=magnolia;Initial Catalog=Restaurant_Management;Integrated Security=True;Encrypt=False");

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                // Uygulamayı kapat
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textboxUsername.Text == ""
                   || textboxPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();

                        string selectData = "SELECT * FROM login WHERE username = @username " +
                        "AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, conn))  //sql komutu çalıştıracak objeyi yaratıyoruz. 
                        {
                            cmd.Parameters.AddWithValue("@username", textboxUsername.Text.Trim());  //username ve password'u alıyoruz.
                            cmd.Parameters.AddWithValue("@password", textboxPassword.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Giriş Başarılı!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                formDashboard dForm = new formDashboard();
                                dForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Yanlış kullanıcı adı veya şifre!."
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //şifreyi görmemizi engeller.
            textboxPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';

           

        }

        private void labelRegisterAccount_Click(object sender, EventArgs e)
        {
            formRegister registerForm = new formRegister();
            registerForm.Show();
            this.Hide();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
