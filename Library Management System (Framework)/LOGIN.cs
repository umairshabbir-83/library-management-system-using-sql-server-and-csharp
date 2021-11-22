using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string Username = Usernametxt.Text;
            string Password = Passwordtxt.Text;

            SqlConnection myConnection = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection.Open();
            SqlCommand CMD = new SqlCommand("Select * from User_Register where Username = @Username and Password = @Password", myConnection);
            CMD.Parameters.AddWithValue("@Username", Username);
            CMD.Parameters.AddWithValue("@Password", Password);
            SqlDataAdapter SDA = new SqlDataAdapter(CMD);
            DataTable DT = new DataTable();
            SDA.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                this.Hide();
                MessageBox.Show("LOGGING IN...");
                MAIN Welcome = new MAIN(Usernametxt.Text);
                Welcome.ShowDialog();
            }
            else
            {
                MessageBox.Show("ACCESS DENIED!!!");
            }

            CMD.ExecuteNonQuery();
            myConnection.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            REGISTER Register = new REGISTER();
            this.Hide();
            Register.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}