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
    public partial class CHANGE_PASSWORD : Form
    {
        public CHANGE_PASSWORD(string Username)
        {
            InitializeComponent();
            Userlbl.Text = Username;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string newPassword = txt_newpwd.Text;

            SqlConnection myConnection = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection.Open();
            SqlCommand CMD = new SqlCommand("Execute UpdatePassword @Username,@Password", myConnection);

            CMD.Parameters.AddWithValue("@Username", Userlbl.Text);
            CMD.Parameters.AddWithValue("@Password", newPassword);

            MessageBox.Show("PASSWORD UPDATED SUCCESSFULLY!!!");

            LOGIN newLogin = new LOGIN();
            this.Hide();
            newLogin.ShowDialog();

            CMD.ExecuteNonQuery();
            myConnection.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Userlbl.Text);
            this.Hide();
            Back.ShowDialog();
        }
    }
}