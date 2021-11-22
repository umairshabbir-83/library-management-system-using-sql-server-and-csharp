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
    public partial class RETURN_BOOK : Form
    {
        public RETURN_BOOK(string Username)
        {
            InitializeComponent();
            Usernamelbl.Text = Username;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Usernamelbl.Text);
            this.Hide();
            Back.ShowDialog();
        }

        private void RETURN_BOOK_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection1 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection1.Open();
            DataTable Table1 = new DataTable();
            SqlDataAdapter Adapter1 = new SqlDataAdapter("Select *From Books_Issue", myConnection1);
            Adapter1.Fill(Table1);
            dataGridView1.DataSource = Table1;
            myConnection1.Close();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string User = Usernamelbl.Text;
            string BookName = txt_book.Text;

            SqlConnection myConnection = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection.Open();
            SqlCommand CMD = new SqlCommand("Execute ReturnBook @user, @Bookname", myConnection);

            CMD.Parameters.AddWithValue("@user", Usernamelbl.Text);
            CMD.Parameters.AddWithValue("@BookName", BookName);

            MessageBox.Show("BOOK RETURNED SUCCESSFULLY!!!");

            CMD.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}