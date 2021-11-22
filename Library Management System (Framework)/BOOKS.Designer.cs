
namespace LMS
{
    partial class BOOKS
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.RemoveBox = new System.Windows.Forms.GroupBox();
            this.rem_book = new System.Windows.Forms.TextBox();
            this.rem_qntrem = new System.Windows.Forms.TextBox();
            this.RQanlbl = new System.Windows.Forms.Label();
            this.RemoveBooklbl = new System.Windows.Forms.Label();
            this.Catlbl = new System.Windows.Forms.Label();
            this.Booklbl = new System.Windows.Forms.Label();
            this.AddBox = new System.Windows.Forms.GroupBox();
            this.add_cat = new System.Windows.Forms.TextBox();
            this.add_price = new System.Windows.Forms.TextBox();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.add_author = new System.Windows.Forms.TextBox();
            this.Autrlbl = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.add_qnt = new System.Windows.Forms.TextBox();
            this.add_book = new System.Windows.Forms.TextBox();
            this.Qntlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lMSDataSet = new LMS.LMSDataSet();
            this.lMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BooksRecordlbl = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Button();
            this.booksRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Userlbl = new System.Windows.Forms.Label();
            this.RemoveBox.SuspendLayout();
            this.AddBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(1030, 591);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 36);
            this.btn_back.TabIndex = 55;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Blue;
            this.btn_remove.Location = new System.Drawing.Point(729, 34);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(236, 38);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove Book";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // RemoveBox
            // 
            this.RemoveBox.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBox.Controls.Add(this.rem_book);
            this.RemoveBox.Controls.Add(this.btn_remove);
            this.RemoveBox.Controls.Add(this.rem_qntrem);
            this.RemoveBox.Controls.Add(this.RQanlbl);
            this.RemoveBox.Controls.Add(this.RemoveBooklbl);
            this.RemoveBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBox.Location = new System.Drawing.Point(126, 217);
            this.RemoveBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveBox.Name = "RemoveBox";
            this.RemoveBox.Padding = new System.Windows.Forms.Padding(4);
            this.RemoveBox.Size = new System.Drawing.Size(1013, 106);
            this.RemoveBox.TabIndex = 54;
            this.RemoveBox.TabStop = false;
            this.RemoveBox.Text = "Remove Book";
            // 
            // rem_book
            // 
            this.rem_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_book.Location = new System.Drawing.Point(123, 41);
            this.rem_book.Margin = new System.Windows.Forms.Padding(4);
            this.rem_book.Name = "rem_book";
            this.rem_book.Size = new System.Drawing.Size(122, 28);
            this.rem_book.TabIndex = 6;
            // 
            // rem_qntrem
            // 
            this.rem_qntrem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rem_qntrem.Font = new System.Drawing.Font("Calibri", 10F);
            this.rem_qntrem.Location = new System.Drawing.Point(495, 41);
            this.rem_qntrem.Margin = new System.Windows.Forms.Padding(4);
            this.rem_qntrem.Name = "rem_qntrem";
            this.rem_qntrem.Size = new System.Drawing.Size(176, 28);
            this.rem_qntrem.TabIndex = 4;
            // 
            // RQanlbl
            // 
            this.RQanlbl.AutoSize = true;
            this.RQanlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RQanlbl.Location = new System.Drawing.Point(268, 43);
            this.RQanlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RQanlbl.Name = "RQanlbl";
            this.RQanlbl.Size = new System.Drawing.Size(208, 19);
            this.RQanlbl.TabIndex = 0;
            this.RQanlbl.Text = "Quantity to be Removed";
            // 
            // RemoveBooklbl
            // 
            this.RemoveBooklbl.AutoSize = true;
            this.RemoveBooklbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBooklbl.Location = new System.Drawing.Point(8, 43);
            this.RemoveBooklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemoveBooklbl.Name = "RemoveBooklbl";
            this.RemoveBooklbl.Size = new System.Drawing.Size(107, 19);
            this.RemoveBooklbl.TabIndex = 0;
            this.RemoveBooklbl.Text = "Book Name";
            // 
            // Catlbl
            // 
            this.Catlbl.AutoSize = true;
            this.Catlbl.Location = new System.Drawing.Point(576, 37);
            this.Catlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Catlbl.Name = "Catlbl";
            this.Catlbl.Size = new System.Drawing.Size(132, 19);
            this.Catlbl.TabIndex = 0;
            this.Catlbl.Text = "Book Category";
            // 
            // Booklbl
            // 
            this.Booklbl.AutoSize = true;
            this.Booklbl.Location = new System.Drawing.Point(8, 37);
            this.Booklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Booklbl.Name = "Booklbl";
            this.Booklbl.Size = new System.Drawing.Size(107, 19);
            this.Booklbl.TabIndex = 0;
            this.Booklbl.Text = "Book Name";
            // 
            // AddBox
            // 
            this.AddBox.BackColor = System.Drawing.Color.Transparent;
            this.AddBox.Controls.Add(this.add_cat);
            this.AddBox.Controls.Add(this.add_price);
            this.AddBox.Controls.Add(this.Pricelbl);
            this.AddBox.Controls.Add(this.add_author);
            this.AddBox.Controls.Add(this.Autrlbl);
            this.AddBox.Controls.Add(this.btn_add);
            this.AddBox.Controls.Add(this.add_qnt);
            this.AddBox.Controls.Add(this.add_book);
            this.AddBox.Controls.Add(this.Qntlbl);
            this.AddBox.Controls.Add(this.Catlbl);
            this.AddBox.Controls.Add(this.Booklbl);
            this.AddBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBox.Location = new System.Drawing.Point(126, 88);
            this.AddBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddBox.Name = "AddBox";
            this.AddBox.Padding = new System.Windows.Forms.Padding(4);
            this.AddBox.Size = new System.Drawing.Size(1012, 121);
            this.AddBox.TabIndex = 53;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "Add Books";
            // 
            // add_cat
            // 
            this.add_cat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_cat.Location = new System.Drawing.Point(729, 34);
            this.add_cat.Margin = new System.Windows.Forms.Padding(4);
            this.add_cat.Name = "add_cat";
            this.add_cat.Size = new System.Drawing.Size(236, 28);
            this.add_cat.TabIndex = 7;
            // 
            // add_price
            // 
            this.add_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_price.Location = new System.Drawing.Point(448, 81);
            this.add_price.Margin = new System.Windows.Forms.Padding(4);
            this.add_price.Name = "add_price";
            this.add_price.Size = new System.Drawing.Size(223, 28);
            this.add_price.TabIndex = 3;
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(335, 83);
            this.Pricelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(97, 19);
            this.Pricelbl.TabIndex = 0;
            this.Pricelbl.Text = "Book Price";
            // 
            // add_author
            // 
            this.add_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_author.Location = new System.Drawing.Point(138, 81);
            this.add_author.Margin = new System.Windows.Forms.Padding(4);
            this.add_author.Name = "add_author";
            this.add_author.Size = new System.Drawing.Size(162, 28);
            this.add_author.TabIndex = 5;
            // 
            // Autrlbl
            // 
            this.Autrlbl.AutoSize = true;
            this.Autrlbl.Location = new System.Drawing.Point(8, 83);
            this.Autrlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Autrlbl.Name = "Autrlbl";
            this.Autrlbl.Size = new System.Drawing.Size(118, 19);
            this.Autrlbl.TabIndex = 0;
            this.Autrlbl.Text = "Author Name";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.ForeColor = System.Drawing.Color.Blue;
            this.btn_add.Location = new System.Drawing.Point(729, 75);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(236, 37);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add Book";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // add_qnt
            // 
            this.add_qnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_qnt.Location = new System.Drawing.Point(448, 34);
            this.add_qnt.Margin = new System.Windows.Forms.Padding(4);
            this.add_qnt.Name = "add_qnt";
            this.add_qnt.Size = new System.Drawing.Size(109, 28);
            this.add_qnt.TabIndex = 4;
            // 
            // add_book
            // 
            this.add_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_book.Location = new System.Drawing.Point(138, 34);
            this.add_book.Margin = new System.Windows.Forms.Padding(4);
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(162, 28);
            this.add_book.TabIndex = 1;
            // 
            // Qntlbl
            // 
            this.Qntlbl.AutoSize = true;
            this.Qntlbl.Location = new System.Drawing.Point(335, 36);
            this.Qntlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Qntlbl.Name = "Qntlbl";
            this.Qntlbl.Size = new System.Drawing.Size(76, 19);
            this.Qntlbl.TabIndex = 0;
            this.Qntlbl.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 51);
            this.label1.TabIndex = 56;
            this.label1.Text = "Library Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(897, 267);
            this.dataGridView1.TabIndex = 57;
            // 
            // lMSDataSet
            // 
            this.lMSDataSet.DataSetName = "LMSDataSet";
            this.lMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lMSDataSetBindingSource
            // 
            this.lMSDataSetBindingSource.DataSource = this.lMSDataSet;
            this.lMSDataSetBindingSource.Position = 0;
            // 
            // BooksRecordlbl
            // 
            this.BooksRecordlbl.AutoSize = true;
            this.BooksRecordlbl.BackColor = System.Drawing.Color.Transparent;
            this.BooksRecordlbl.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksRecordlbl.Location = new System.Drawing.Point(122, 336);
            this.BooksRecordlbl.Name = "BooksRecordlbl";
            this.BooksRecordlbl.Size = new System.Drawing.Size(170, 21);
            this.BooksRecordlbl.TabIndex = 58;
            this.BooksRecordlbl.Text = "BOOKS RECORD";
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.Transparent;
            this.Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.ForeColor = System.Drawing.Color.Green;
            this.Show.Location = new System.Drawing.Point(1030, 360);
            this.Show.Margin = new System.Windows.Forms.Padding(4);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(109, 163);
            this.Show.TabIndex = 59;
            this.Show.Text = "Show Record";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // booksRecordBindingSource1
            // 
            this.booksRecordBindingSource1.DataMember = "Books_Record";
            // 
            // booksCategoryBindingSource
            // 
            this.booksCategoryBindingSource.DataMember = "Books_Category";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userlbl.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Black;
            this.Userlbl.Location = new System.Drawing.Point(1156, 606);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(15, 21);
            this.Userlbl.TabIndex = 60;
            this.Userlbl.Text = ".";
            // 
            // BOOKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._347139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.BooksRecordlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.RemoveBox);
            this.Controls.Add(this.AddBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BOOKS";
            this.Text = "Book Management :: Library Management System";
            this.RemoveBox.ResumeLayout(false);
            this.RemoveBox.PerformLayout();
            this.AddBox.ResumeLayout(false);
            this.AddBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource booksRecordBindingSource;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.BindingSource booksRecordBindingSource1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.GroupBox RemoveBox;
        private System.Windows.Forms.TextBox rem_qntrem;
        private System.Windows.Forms.Label RQanlbl;
        private System.Windows.Forms.Label RemoveBooklbl;
        private System.Windows.Forms.Label Catlbl;
        private System.Windows.Forms.Label Booklbl;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.TextBox add_price;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.TextBox add_author;
        private System.Windows.Forms.Label Autrlbl;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox add_qnt;
        private System.Windows.Forms.TextBox add_book;
        private System.Windows.Forms.BindingSource booksCategoryBindingSource;
        private System.Windows.Forms.Label Qntlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rem_book;
        private System.Windows.Forms.TextBox add_cat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lMSDataSetBindingSource;
        private LMSDataSet lMSDataSet;
        private System.Windows.Forms.Label BooksRecordlbl;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Label Userlbl;
    }
}