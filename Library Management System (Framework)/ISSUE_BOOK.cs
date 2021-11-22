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
    public partial class ISSUE_BOOK : Form
    {
        public ISSUE_BOOK(string Username)
        {
            InitializeComponent();
            Usernamelbl.Text = Username;
        }

        private void ISSUE_BOOK_Load(object sender, EventArgs e)
        {
            SqlConnection myConnection1 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection1.Open();
            DataTable Table1 = new DataTable();
            SqlDataAdapter Adapter1 = new SqlDataAdapter("Select *From Books_Record", myConnection1);
            Adapter1.Fill(Table1);
            gridview.DataSource = Table1;
            myConnection1.Close();
        }

        private void btn_issue_Click(object sender, EventArgs e)
        {
            string BookName = txt_book.Text;

            SqlConnection myConnection2 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection2.Open();
            SqlCommand CMD = new SqlCommand("Execute IssueBook @user, @Bookname", myConnection2);

            CMD.Parameters.AddWithValue("@user", Usernamelbl.Text);
            CMD.Parameters.AddWithValue("@Bookname", BookName);

            MessageBox.Show("BOOK ISSUED SYCCESSFULLY!!!");

            CMD.ExecuteNonQuery();
            myConnection2.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Usernamelbl.Text);
            this.Hide();
            Back.ShowDialog();
        }
    }
}