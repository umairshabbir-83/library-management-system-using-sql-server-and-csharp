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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string Username = txt_uname.Text;
            string Password = txt_pwd.Text;

            SqlConnection myConnection = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection.Open();
            SqlCommand CMD = new SqlCommand("Execute Insert_User @Username,@Password", myConnection);

            CMD.Parameters.AddWithValue("@Username", Username);
            CMD.Parameters.AddWithValue("@Password", Password);

            MessageBox.Show("USER ADDED SUCCESSFULLY!!!");

            LOGIN newLogin = new LOGIN();
            this.Hide();
            newLogin.ShowDialog();

            CMD.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}