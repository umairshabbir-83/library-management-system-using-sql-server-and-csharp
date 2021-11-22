
namespace LMS
{
    partial class REGISTER
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
            this.RegisterBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.PwdLbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.Mainlbl = new System.Windows.Forms.Label();
            this.RegisterBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterBox1
            // 
            this.RegisterBox1.BackColor = System.Drawing.Color.Transparent;
            this.RegisterBox1.Controls.Add(this.btn_exit);
            this.RegisterBox1.Controls.Add(this.btn_register);
            this.RegisterBox1.Controls.Add(this.txt_pwd);
            this.RegisterBox1.Controls.Add(this.txt_uname);
            this.RegisterBox1.Controls.Add(this.PwdLbl);
            this.RegisterBox1.Controls.Add(this.Userlbl);
            this.RegisterBox1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBox1.ForeColor = System.Drawing.Color.White;
            this.RegisterBox1.Location = new System.Drawing.Point(162, 264);
            this.RegisterBox1.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterBox1.Name = "RegisterBox1";
            this.RegisterBox1.Padding = new System.Windows.Forms.Padding(4);
            this.RegisterBox1.Size = new System.Drawing.Size(527, 302);
            this.RegisterBox1.TabIndex = 3;
            this.RegisterBox1.TabStop = false;
            this.RegisterBox1.Text = "User Register";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(373, 226);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 37);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_register.ForeColor = System.Drawing.Color.Blue;
            this.btn_register.Location = new System.Drawing.Point(73, 226);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(161, 37);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_pwd
            // 
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Location = new System.Drawing.Point(238, 135);
            this.txt_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(251, 26);
            this.txt_pwd.TabIndex = 2;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // txt_uname
            // 
            this.txt_uname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_uname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uname.Location = new System.Drawing.Point(238, 75);
            this.txt_uname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(251, 26);
            this.txt_uname.TabIndex = 1;
            // 
            // PwdLbl
            // 
            this.PwdLbl.AutoSize = true;
            this.PwdLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdLbl.Location = new System.Drawing.Point(71, 138);
            this.PwdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PwdLbl.Name = "PwdLbl";
            this.PwdLbl.Size = new System.Drawing.Size(100, 23);
            this.PwdLbl.TabIndex = 1;
            this.PwdLbl.Text = "Password";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.Location = new System.Drawing.Point(69, 78);
            this.Userlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(108, 23);
            this.Userlbl.TabIndex = 0;
            this.Userlbl.Text = "Username";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.ForeColor = System.Drawing.Color.White;
            this.Mainlbl.Location = new System.Drawing.Point(153, 127);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(536, 51);
            this.Mainlbl.TabIndex = 2;
            this.Mainlbl.Text = "Library Management System";
            // 
            // REGISTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._162410;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.RegisterBox1);
            this.Controls.Add(this.Mainlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "REGISTER";
            this.Text = "New User :: Library Management System";
            this.RegisterBox1.ResumeLayout(false);
            this.RegisterBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RegisterBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label PwdLbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.Label Mainlbl;
    }
}