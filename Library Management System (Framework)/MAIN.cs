using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class MAIN : Form
    {
        public MAIN(string Username)
        {
            InitializeComponent();
            Userlbl.Text = Username;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LOGIN Login = new LOGIN();
            this.Hide();
            Login.ShowDialog();
        }

        private void BooksBtn_Click(object sender, EventArgs e)
        {
            BOOKS Books = new BOOKS(Userlbl.Text);
            this.Hide();
            Books.ShowDialog();        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            BOOKS_RECORD Record = new BOOKS_RECORD(Userlbl.Text);
            this.Hide();
            Record.ShowDialog();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            CATEGORY Cat = new CATEGORY(Userlbl.Text);
            this.Hide();
            Cat.ShowDialog();
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            ISSUE_BOOK Issue = new ISSUE_BOOK(Userlbl.Text);
            this.Hide();
            Issue.ShowDialog();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            RETURN_BOOK Return = new RETURN_BOOK(Userlbl.Text);
            this.Hide();
            Return.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHANGE_PASSWORD Change = new CHANGE_PASSWORD(Userlbl.Text);
            this.Hide();
            Change.ShowDialog();
        }
    }
}