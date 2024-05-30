using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;



namespace Restaurant_Management_Project
{
    public partial class formDashboard : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );



        public formDashboard()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            formStatistic1.Visible = false;
            formDashboard21.Visible = true;
            formCrew1.Visible = false;
            formMenu1.Visible = false;
            formOrder1.Visible = false;
            


            panelNav.Height = buttonDashboard.Height;
            panelNav.Top = buttonDashboard.Top;
            panelNav.Left = buttonDashboard.Left;
            buttonDashboard.BackColor = Color.FromArgb(49, 48, 77);
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            formStatistic1.Visible = false;
            formDashboard21.Visible = true;
            formCrew1.Visible = false;
            formMenu1.Visible = false;
            formOrder1.Visible = false;


            

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            formStatistic1.Visible = false;
            formDashboard21.Visible = false;
            formCrew1.Visible = false;
            formMenu1.Visible = false;
            formOrder1.Visible = true;

            formOrder aaProd = formOrder1 as formOrder;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }


        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            formStatistic1.Visible = false;
            formDashboard21.Visible = false;
            formCrew1.Visible = false;
            formMenu1.Visible = true;
            formOrder1.Visible = false;

            formMenu aaProd = formMenu1 as formMenu;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }


        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            formStatistic1.Visible = false;
            formDashboard21.Visible = false;
            formCrew1.Visible = true;
            formMenu1.Visible = false;
            formOrder1.Visible = false;

            formCrew aaProd = formCrew1 as formCrew;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }


        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            formStatistic1.Visible = true; 
            formDashboard21.Visible= false;
            formCrew1.Visible = false;
            formMenu1.Visible = false;
            formOrder1.Visible = false;

            formStatistic aaProd = formStatistic1 as formStatistic;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelNav.Height = buttonSettings.Height;
            panelNav.Top = buttonSettings.Top;
            buttonSettings.BackColor = Color.FromArgb(49, 48, 77);
        }

        private void buttonDashboard_Leave(object sender, EventArgs e)
        {
            buttonDashboard.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void buttonOrder_Leave(object sender, EventArgs e)
        {
            buttonOrder.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void buttonMenu_Leave(object sender, EventArgs e)
        {
            buttonMenu.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void buttonEmployee_Leave(object sender, EventArgs e)
        {
            buttonEmployee.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void buttonStatistic_Leave(object sender, EventArgs e)
        {
            buttonStatistic.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void buttonSettings_Leave(object sender, EventArgs e)
        {
            buttonSettings.BackColor = Color.FromArgb(22, 26, 48);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void formMenuManagement1_Load(object sender, EventArgs e)
        {

        }
    }
}
