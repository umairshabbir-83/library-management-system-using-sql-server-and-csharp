
namespace LMS
{
    partial class ISSUE_BOOK
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
            this.SearchBox1 = new System.Windows.Forms.GroupBox();
            this.txt_book = new System.Windows.Forms.TextBox();
            this.btn_issue = new System.Windows.Forms.Button();
            this.Booklbl = new System.Windows.Forms.Label();
            this.Mainlbl = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Recordlbl = new System.Windows.Forms.Label();
            this.SearchBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox1
            // 
            this.SearchBox1.BackColor = System.Drawing.Color.Transparent;
            this.SearchBox1.Controls.Add(this.txt_book);
            this.SearchBox1.Controls.Add(this.btn_issue);
            this.SearchBox1.Controls.Add(this.Booklbl);
            this.SearchBox1.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox1.Location = new System.Drawing.Point(125, 100);
            this.SearchBox1.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBox1.Name = "SearchBox1";
            this.SearchBox1.Padding = new System.Windows.Forms.Padding(4);
            this.SearchBox1.Size = new System.Drawing.Size(1013, 168);
            this.SearchBox1.TabIndex = 8;
            this.SearchBox1.TabStop = false;
            this.SearchBox1.Text = "ISSUE BOOK";
            // 
            // txt_book
            // 
            this.txt_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_book.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_book.Location = new System.Drawing.Point(382, 49);
            this.txt_book.Margin = new System.Windows.Forms.Padding(4);
            this.txt_book.Name = "txt_book";
            this.txt_book.Size = new System.Drawing.Size(281, 26);
            this.txt_book.TabIndex = 2;
            // 
            // btn_issue
            // 
            this.btn_issue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_issue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issue.ForeColor = System.Drawing.Color.Blue;
            this.btn_issue.Location = new System.Drawing.Point(791, 41);
            this.btn_issue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_issue.Name = "btn_issue";
            this.btn_issue.Size = new System.Drawing.Size(144, 38);
            this.btn_issue.TabIndex = 13;
            this.btn_issue.Text = "Issue Book";
            this.btn_issue.UseVisualStyleBackColor = true;
            this.btn_issue.Click += new System.EventHandler(this.btn_issue_Click);
            // 
            // Booklbl
            // 
            this.Booklbl.AutoSize = true;
            this.Booklbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booklbl.Location = new System.Drawing.Point(167, 51);
            this.Booklbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Booklbl.Name = "Booklbl";
            this.Booklbl.Size = new System.Drawing.Size(107, 19);
            this.Booklbl.TabIndex = 0;
            this.Booklbl.Text = "Book Name";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(387, 9);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(536, 51);
            this.Mainlbl.TabIndex = 7;
            this.Mainlbl.Text = "Library Management System";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(1021, 624);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 38);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(125, 357);
            this.gridview.Margin = new System.Windows.Forms.Padding(4);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 51;
            this.gridview.Size = new System.Drawing.Size(1013, 260);
            this.gridview.TabIndex = 9;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Castellar", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(1164, 638);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(12, 17);
            this.Usernamelbl.TabIndex = 13;
            this.Usernamelbl.Text = ".";
            // 
            // Recordlbl
            // 
            this.Recordlbl.AutoSize = true;
            this.Recordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Recordlbl.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordlbl.Location = new System.Drawing.Point(125, 305);
            this.Recordlbl.Name = "Recordlbl";
            this.Recordlbl.Size = new System.Drawing.Size(161, 21);
            this.Recordlbl.TabIndex = 14;
            this.Recordlbl.Text = "BOOK RECORD";
            // 
            // ISSUE_BOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._347139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Recordlbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.SearchBox1);
            this.Controls.Add(this.Mainlbl);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.gridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ISSUE_BOOK";
            this.Text = "Issue Book :: Library Management System";
            this.Load += new System.EventHandler(this.ISSUE_BOOK_Load);
            this.SearchBox1.ResumeLayout(false);
            this.SearchBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox1;
        private System.Windows.Forms.TextBox txt_book;
        private System.Windows.Forms.Label Booklbl;
        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Button btn_issue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label Recordlbl;
    }
}