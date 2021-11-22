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
    public partial class CATEGORY : Form
    {
        public CATEGORY(string Username)
        {
            InitializeComponent();
            Userlbl.Text = Username;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string Cat = add_cat.Text;

            SqlConnection myConnection1 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection1.Open();
            SqlCommand CMD1 = new SqlCommand("Execute AddCategory @Book_Category", myConnection1);

            CMD1.Parameters.AddWithValue("@Book_Category", Cat);

            MessageBox.Show("CATEGORY ADDED SYCCESSFULLY!!!");

            CMD1.ExecuteNonQuery();
            myConnection1.Close();
        }

        private void rem_btn_Click(object sender, EventArgs e)
        {
            int Cat_ID = int.Parse(rem_cat.Text);

            SqlConnection myConnection2 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection2.Open();
            SqlCommand CMD2 = new SqlCommand("Execute RemCategory @Category", myConnection2);

            CMD2.Parameters.AddWithValue("@Category", Cat_ID);

            MessageBox.Show("CATEGORY REMOVED SYCCESSFULLY!!!");

            CMD2.ExecuteNonQuery();
            myConnection2.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Userlbl.Text);
            this.Hide();
            Back.ShowDialog();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection0 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection0.Open();
            DataTable Table = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("Select *From Books_Category", myConnection0);
            Adapter.Fill(Table);
            CatData.DataSource = Table;
            myConnection0.Close();
        }
    }
}