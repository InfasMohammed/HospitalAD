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
using Hospital.Admin.Dashborad;
using Hospital.Admin.Doctor;

namespace Hospital
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U39BO60\\SQLEXPRESS;Initial Catalog=hospitalmstm;Integrated Security=True");
        SqlCommand cmd;

        
        public FormLogin()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();
            /* conn.Open();

             cmd = new SqlCommand("SELECT * from Users WHERE Username = @username", conn);
             cmd.Parameters.AddWithValue("username", username);
             SqlDataReader  dr = cmd.ExecuteReader();

             if (dr.Read())
             {

             }*/

        }
    }
}
