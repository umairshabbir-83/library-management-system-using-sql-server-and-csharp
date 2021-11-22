
namespace LMS
{
    partial class RETURN_BOOK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReturnBox1 = new System.Windows.Forms.GroupBox();
            this.txt_book = new System.Windows.Forms.TextBox();
            this.btn_return = new System.Windows.Forms.Button();
            this.Booklbl = new System.Windows.Forms.Label();
            this.booksIssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mainlbl = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Recordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.ReturnBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnBox1
            // 
            this.ReturnBox1.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBox1.Controls.Add(this.txt_book);
            this.ReturnBox1.Controls.Add(this.btn_return);
            this.ReturnBox1.Controls.Add(this.Booklbl);
            this.ReturnBox1.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBox1.Location = new System.Drawing.Point(221, 144);
            this.ReturnBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBox1.Name = "ReturnBox1";
            this.ReturnBox1.Padding = new System.Windows.Forms.Padding(4);
            this.ReturnBox1.Size = new System.Drawing.Size(821, 127);
            this.ReturnBox1.TabIndex = 6;
            this.ReturnBox1.TabStop = false;
            this.ReturnBox1.Text = "Return Books";
            // 
            // txt_book
            // 
            this.txt_book.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book.Location = new System.Drawing.Point(227, 63);
            this.txt_book.Name = "txt_book";
            this.txt_book.Size = new System.Drawing.Size(300, 26);
            this.txt_book.TabIndex = 8;
            // 
            // btn_return
            // 
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Calibri", 10F);
            this.btn_return.Location = new System.Drawing.Point(590, 58);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(159, 37);
            this.btn_return.TabIndex = 7;
            this.btn_return.Text = "Return Book";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // Booklbl
            // 
            this.Booklbl.AutoSize = true;
            this.Booklbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booklbl.Location = new System.Drawing.Point(60, 66);
            this.Booklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Booklbl.Name = "Booklbl";
            this.Booklbl.Size = new System.Drawing.Size(107, 19);
            this.Booklbl.TabIndex = 0;
            this.Booklbl.Text = "Book Name";
            // 
            // booksIssueBindingSource
            // 
            this.booksIssueBindingSource.DataMember = "Books_Issue";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(340, 9);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(569, 51);
            this.Mainlbl.TabIndex = 5;
            this.Mainlbl.Text = "Library Management Software";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(929, 551);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 37);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Recordlbl
            // 
            this.Recordlbl.AutoSize = true;
            this.Recordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Recordlbl.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordlbl.Location = new System.Drawing.Point(221, 292);
            this.Recordlbl.Name = "Recordlbl";
            this.Recordlbl.Size = new System.Drawing.Size(154, 21);
            this.Recordlbl.TabIndex = 12;
            this.Recordlbl.Text = "ISSUED BOOKS";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Castellar", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(1107, 564);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(12, 17);
            this.Usernamelbl.TabIndex = 14;
            this.Usernamelbl.Text = ".";
            // 
            // RETURN_BOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._347139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Recordlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReturnBox1);
            this.Controls.Add(this.Mainlbl);
            this.Controls.Add(this.btn_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RETURN_BOOK";
            this.Text = "Return Book :: Library Management System";
            this.Load += new System.EventHandler(this.RETURN_BOOK_Load);
            this.ReturnBox1.ResumeLayout(false);
            this.ReturnBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ReturnBox1;
        private System.Windows.Forms.BindingSource booksIssueBindingSource;
        private System.Windows.Forms.Label Booklbl;
        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Recordlbl;
        private System.Windows.Forms.TextBox txt_book;
        private System.Windows.Forms.Label Usernamelbl;
    }
}