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
    public partial class BOOKS : Form
    {
        public BOOKS(string Username)
        {
            InitializeComponent();
            Userlbl.Text = Username;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string Name = add_book.Text;
            int Category = int.Parse(add_cat.Text);
            decimal Price = decimal.Parse(add_price.Text);
            int Quantity = int.Parse(add_qnt.Text);
            string Author = add_author.Text;

            SqlConnection myConnection1 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection1.Open();
            SqlCommand CMD = new SqlCommand("Execute AddBook @Book, @Category, @Price, @Quantity, @Author", myConnection1);

            CMD.Parameters.AddWithValue("@Book", Name);
            CMD.Parameters.AddWithValue("@Category", Category);
            CMD.Parameters.AddWithValue("@Price", Price);
            CMD.Parameters.AddWithValue("@Quantity", Quantity);
            CMD.Parameters.AddWithValue("@Author", Author);

            MessageBox.Show("BOOK ADDED SYCCESSFULLY!!!");

            CMD.ExecuteNonQuery();
            myConnection1.Close();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection0 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection0.Open();
            DataTable Table = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("Select *From Books_Record", myConnection0);
            Adapter.Fill(Table);
            dataGridView1.DataSource = Table;
            myConnection0.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string RemName = rem_book.Text;
            int RemQuantity = int.Parse(rem_qntrem.Text);

            SqlConnection myConnection2 = new SqlConnection(@"Data Source = DESKTOP-HPUSO; Initial Catalog = LMS; Integrated Security = True");
            myConnection2.Open();
            SqlCommand CMD = new SqlCommand("Execute RemBook @RemBook, @RemQuantity", myConnection2);

            CMD.Parameters.AddWithValue("@RemBook", RemName);
            CMD.Parameters.AddWithValue("@RemQuantity", RemQuantity);

            MessageBox.Show("BOOK REMOVED SYCCESSFULLY!!!");

            CMD.ExecuteNonQuery();
            myConnection2.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MAIN Back = new MAIN(Userlbl.Text);
            this.Hide();
            Back.ShowDialog();
        }
    }
}