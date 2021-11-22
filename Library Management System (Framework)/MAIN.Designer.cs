
namespace LMS
{
    partial class MAIN
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.Maintxt = new System.Windows.Forms.Label();
            this.BooksBtn = new System.Windows.Forms.Button();
            this.CategoryBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.Red;
            this.LogoutBtn.Location = new System.Drawing.Point(70, 539);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(659, 77);
            this.LogoutBtn.TabIndex = 24;
            this.LogoutBtn.Text = "LogOut";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Maintxt
            // 
            this.Maintxt.AutoSize = true;
            this.Maintxt.BackColor = System.Drawing.Color.Transparent;
            this.Maintxt.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintxt.ForeColor = System.Drawing.Color.White;
            this.Maintxt.Location = new System.Drawing.Point(134, 72);
            this.Maintxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maintxt.Name = "Maintxt";
            this.Maintxt.Size = new System.Drawing.Size(536, 51);
            this.Maintxt.TabIndex = 14;
            this.Maintxt.Text = "Library Management System";
            // 
            // BooksBtn
            // 
            this.BooksBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksBtn.ForeColor = System.Drawing.Color.Blue;
            this.BooksBtn.Location = new System.Drawing.Point(70, 221);
            this.BooksBtn.Name = "BooksBtn";
            this.BooksBtn.Size = new System.Drawing.Size(275, 80);
            this.BooksBtn.TabIndex = 26;
            this.BooksBtn.Text = "Add / Remove Books";
            this.BooksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BooksBtn.UseVisualStyleBackColor = false;
            this.BooksBtn.Click += new System.EventHandler(this.BooksBtn_Click);
            // 
            // CategoryBtn
            // 
            this.CategoryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryBtn.ForeColor = System.Drawing.Color.Blue;
            this.CategoryBtn.Location = new System.Drawing.Point(454, 221);
            this.CategoryBtn.Name = "CategoryBtn";
            this.CategoryBtn.Size = new System.Drawing.Size(275, 80);
            this.CategoryBtn.TabIndex = 27;
            this.CategoryBtn.Text = "Add / Remove Category";
            this.CategoryBtn.UseVisualStyleBackColor = false;
            this.CategoryBtn.Click += new System.EventHandler(this.CategoryBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.ForeColor = System.Drawing.Color.Blue;
            this.IssueBtn.Location = new System.Drawing.Point(70, 330);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(275, 74);
            this.IssueBtn.TabIndex = 28;
            this.IssueBtn.Text = "Issue Book";
            this.IssueBtn.UseVisualStyleBackColor = false;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.ForeColor = System.Drawing.Color.Blue;
            this.ReturnBtn.Location = new System.Drawing.Point(454, 330);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(275, 74);
            this.ReturnBtn.TabIndex = 29;
            this.ReturnBtn.Text = "Return Book";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // RecordBtn
            // 
            this.RecordBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordBtn.ForeColor = System.Drawing.Color.Blue;
            this.RecordBtn.Location = new System.Drawing.Point(70, 428);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(275, 81);
            this.RecordBtn.TabIndex = 30;
            this.RecordBtn.Text = "View Record";
            this.RecordBtn.UseVisualStyleBackColor = false;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.ForeColor = System.Drawing.Color.White;
            this.Welcomelbl.Location = new System.Drawing.Point(70, 161);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(113, 21);
            this.Welcomelbl.TabIndex = 31;
            this.Welcomelbl.Text = "WELCOME";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userlbl.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.White;
            this.Userlbl.Location = new System.Drawing.Point(209, 161);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(15, 21);
            this.Userlbl.TabIndex = 32;
            this.Userlbl.Text = ".";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(454, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 81);
            this.button1.TabIndex = 33;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._162410;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Welcomelbl);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.CategoryBtn);
            this.Controls.Add(this.BooksBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.Maintxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MAIN";
            this.Text = "Welcome :: Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label Maintxt;
        private System.Windows.Forms.Button BooksBtn;
        private System.Windows.Forms.Button CategoryBtn;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button RecordBtn;
        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Button button1;
    }
}