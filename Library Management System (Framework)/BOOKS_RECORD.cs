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
    public partial class BOOKS_RECORD : Form
    {
        public BOOKS_RECORD(string Username)
        {
            InitializeComponent();
            Userlbl.Text = Username;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Userlbl.Text);
            this.Hide();
            Back.ShowDialog();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection1 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection1.Open();
            DataTable Table1 = new DataTable();
            SqlDataAdapter Adapter1 = new SqlDataAdapter("SELECT  *FROM [LMS].[dbo].[ReadLibraryData]", myConnection1);
            Adapter1.Fill(Table1);
            dataGridView1.DataSource = Table1;
            myConnection1.Close();
        }

        private void btn_issued_Click(object sender, EventArgs e)
        {
            string User = Userlbl.Text;

            SqlConnection myConnection2 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection2.Open();
            DataTable Table2 = new DataTable();
            SqlDataAdapter Adapter2 = new SqlDataAdapter("SELECT *FROM Books_Issue", myConnection2);
            Adapter2.Fill(Table2);
            //Adapter2.SelectCommand.Parameters.AddWithValue("@User", User);
            dataGridView2.DataSource = Table2;
            myConnection2.Close();
        }
    }
}