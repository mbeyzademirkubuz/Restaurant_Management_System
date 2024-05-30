using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_Project
{
    public partial class formCrew : UserControl
    {
        public formCrew()
        {
            InitializeComponent();
            displayCrewData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCrewData();
        }

        public void displayCrewData()
        {
            ShowCrewData scd = new ShowCrewData();
            List<ShowCrewData> listData = scd.showCrewListData();

            dataGridViewShowCrewFirst.DataSource = listData;
        }

        private void buttonOrderManagement_Click(object sender, EventArgs e)
        {
            formManageCrew manageCrewForm = new formManageCrew();
            manageCrewForm.Show();
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

        private void formCrew_Load(object sender, EventArgs e)
        {

        }
    }
}
