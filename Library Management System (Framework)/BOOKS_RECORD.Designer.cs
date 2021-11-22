
namespace LMS
{
    partial class BOOKS_RECORD
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
            this.Maintxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Userlbl = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_issued = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Maintxt
            // 
            this.Maintxt.AutoSize = true;
            this.Maintxt.BackColor = System.Drawing.Color.Transparent;
            this.Maintxt.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maintxt.ForeColor = System.Drawing.Color.Black;
            this.Maintxt.Location = new System.Drawing.Point(380, 9);
            this.Maintxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Maintxt.Name = "Maintxt";
            this.Maintxt.Size = new System.Drawing.Size(536, 51);
            this.Maintxt.TabIndex = 15;
            this.Maintxt.Text = "Library Management System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(893, 227);
            this.dataGridView1.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(204, 431);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(752, 158);
            this.dataGridView2.TabIndex = 18;
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userlbl.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Black;
            this.Userlbl.Location = new System.Drawing.Point(1082, 636);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(15, 21);
            this.Userlbl.TabIndex = 33;
            this.Userlbl.Text = ".";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(204, 627);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(109, 36);
            this.btn_back.TabIndex = 56;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.Blue;
            this.btn_show.Location = new System.Drawing.Point(204, 87);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(231, 36);
            this.btn_show.TabIndex = 57;
            this.btn_show.Text = "SHOW BOOKS DATA";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_issued
            // 
            this.btn_issued.BackColor = System.Drawing.Color.Transparent;
            this.btn_issued.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_issued.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_issued.ForeColor = System.Drawing.Color.Blue;
            this.btn_issued.Location = new System.Drawing.Point(204, 388);
            this.btn_issued.Margin = new System.Windows.Forms.Padding(4);
            this.btn_issued.Name = "btn_issued";
            this.btn_issued.Size = new System.Drawing.Size(231, 36);
            this.btn_issued.TabIndex = 58;
            this.btn_issued.Text = "SHOW ISSUED BOOKS";
            this.btn_issued.UseVisualStyleBackColor = false;
            this.btn_issued.Click += new System.EventHandler(this.btn_issued_Click);
            // 
            // BOOKS_RECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._347139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btn_issued);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Maintxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BOOKS_RECORD";
            this.Text = "Books Record :: Library management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Maintxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_issued;
    }
}