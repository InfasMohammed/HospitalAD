using Hospital.Admin.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.Admin.Dashborad
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void lblThRoom_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.dashboardPanel.Controls.Count > 0)
                this.dashboardPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboardPanel.Controls.Add(f);
            this.dashboardPanel.Tag = f;
            f.Show();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            loadform(new ManageDoctor());
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            loadform(new addPtients());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            loadform(new Staff());
        }
    }
}
