
namespace LMS
{
    partial class CATEGORY
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
            this.Mainlbl = new System.Windows.Forms.Label();
            this.ACatlbl = new System.Windows.Forms.Label();
            this.add_cat = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.RCatBox = new System.Windows.Forms.GroupBox();
            this.rem_cat = new System.Windows.Forms.TextBox();
            this.rem_btn = new System.Windows.Forms.Button();
            this.RCatlbl = new System.Windows.Forms.Label();
            this.ACatBox = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.CatData = new System.Windows.Forms.DataGridView();
            this.Recordlbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.RCatBox.SuspendLayout();
            this.ACatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatData)).BeginInit();
            this.SuspendLayout();
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.Location = new System.Drawing.Point(402, 9);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(536, 51);
            this.Mainlbl.TabIndex = 7;
            this.Mainlbl.Text = "Library Management System";
            // 
            // ACatlbl
            // 
            this.ACatlbl.AutoSize = true;
            this.ACatlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACatlbl.Location = new System.Drawing.Point(37, 64);
            this.ACatlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ACatlbl.Name = "ACatlbl";
            this.ACatlbl.Size = new System.Drawing.Size(141, 19);
            this.ACatlbl.TabIndex = 0;
            this.ACatlbl.Text = "Category Name";
            // 
            // add_cat
            // 
            this.add_cat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cat.Location = new System.Drawing.Point(201, 61);
            this.add_cat.Margin = new System.Windows.Forms.Padding(4);
            this.add_cat.Name = "add_cat";
            this.add_cat.Size = new System.Drawing.Size(245, 26);
            this.add_cat.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Blue;
            this.add_btn.Location = new System.Drawing.Point(201, 119);
            this.add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(245, 34);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add Category";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // RCatBox
            // 
            this.RCatBox.BackColor = System.Drawing.Color.Transparent;
            this.RCatBox.Controls.Add(this.rem_cat);
            this.RCatBox.Controls.Add(this.rem_btn);
            this.RCatBox.Controls.Add(this.RCatlbl);
            this.RCatBox.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCatBox.Location = new System.Drawing.Point(643, 98);
            this.RCatBox.Margin = new System.Windows.Forms.Padding(4);
            this.RCatBox.Name = "RCatBox";
            this.RCatBox.Padding = new System.Windows.Forms.Padding(4);
            this.RCatBox.Size = new System.Drawing.Size(495, 186);
            this.RCatBox.TabIndex = 8;
            this.RCatBox.TabStop = false;
            this.RCatBox.Text = "Remove Category";
            // 
            // rem_cat
            // 
            this.rem_cat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem_cat.Location = new System.Drawing.Point(221, 61);
            this.rem_cat.Margin = new System.Windows.Forms.Padding(4);
            this.rem_cat.Name = "rem_cat";
            this.rem_cat.Size = new System.Drawing.Size(245, 26);
            this.rem_cat.TabIndex = 3;
            // 
            // rem_btn
            // 
            this.rem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rem_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rem_btn.ForeColor = System.Drawing.Color.Red;
            this.rem_btn.Location = new System.Drawing.Point(221, 119);
            this.rem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(245, 34);
            this.rem_btn.TabIndex = 12;
            this.rem_btn.Text = "Remove Category";
            this.rem_btn.UseVisualStyleBackColor = true;
            this.rem_btn.Click += new System.EventHandler(this.rem_btn_Click);
            // 
            // RCatlbl
            // 
            this.RCatlbl.AutoSize = true;
            this.RCatlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCatlbl.Location = new System.Drawing.Point(57, 64);
            this.RCatlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCatlbl.Name = "RCatlbl";
            this.RCatlbl.Size = new System.Drawing.Size(107, 19);
            this.RCatlbl.TabIndex = 0;
            this.RCatlbl.Text = "Category ID";
            // 
            // ACatBox
            // 
            this.ACatBox.BackColor = System.Drawing.Color.Transparent;
            this.ACatBox.Controls.Add(this.ACatlbl);
            this.ACatBox.Controls.Add(this.add_cat);
            this.ACatBox.Controls.Add(this.add_btn);
            this.ACatBox.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACatBox.Location = new System.Drawing.Point(128, 98);
            this.ACatBox.Margin = new System.Windows.Forms.Padding(4);
            this.ACatBox.Name = "ACatBox";
            this.ACatBox.Padding = new System.Windows.Forms.Padding(4);
            this.ACatBox.Size = new System.Drawing.Size(507, 186);
            this.ACatBox.TabIndex = 9;
            this.ACatBox.TabStop = false;
            this.ACatBox.Text = "Add Book Category";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(490, 584);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(145, 34);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_load.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Green;
            this.btn_load.Location = new System.Drawing.Point(490, 324);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(145, 137);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Show Data";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // CatData
            // 
            this.CatData.AllowUserToAddRows = false;
            this.CatData.AllowUserToDeleteRows = false;
            this.CatData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CatData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatData.ColumnHeadersHeight = 29;
            this.CatData.Location = new System.Drawing.Point(128, 324);
            this.CatData.Margin = new System.Windows.Forms.Padding(4);
            this.CatData.Name = "CatData";
            this.CatData.RowHeadersWidth = 25;
            this.CatData.Size = new System.Drawing.Size(274, 294);
            this.CatData.TabIndex = 10;
            // 
            // Recordlbl
            // 
            this.Recordlbl.AutoSize = true;
            this.Recordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Recordlbl.Font = new System.Drawing.Font("Castellar", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordlbl.ForeColor = System.Drawing.Color.Black;
            this.Recordlbl.Location = new System.Drawing.Point(124, 299);
            this.Recordlbl.Name = "Recordlbl";
            this.Recordlbl.Size = new System.Drawing.Size(215, 21);
            this.Recordlbl.TabIndex = 13;
            this.Recordlbl.Text = "Category Record";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userlbl.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Black;
            this.Userlbl.Location = new System.Drawing.Point(732, 592);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(15, 21);
            this.Userlbl.TabIndex = 61;
            this.Userlbl.Text = ".";
            // 
            // CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._347139;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.Recordlbl);
            this.Controls.Add(this.Mainlbl);
            this.Controls.Add(this.RCatBox);
            this.Controls.Add(this.ACatBox);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.CatData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CATEGORY";
            this.Text = "Category Management :: Library Management System";
            this.RCatBox.ResumeLayout(false);
            this.RCatBox.PerformLayout();
            this.ACatBox.ResumeLayout(false);
            this.ACatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Label ACatlbl;
        private System.Windows.Forms.TextBox add_cat;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.GroupBox RCatBox;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Label RCatlbl;
        private System.Windows.Forms.GroupBox ACatBox;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView CatData;
        private System.Windows.Forms.TextBox rem_cat;
        private System.Windows.Forms.Label Recordlbl;
        private System.Windows.Forms.Label Userlbl;
    }
}