
namespace LMS
{
    partial class CHANGE_PASSWORD
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
            this.ChamgeBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_cpwd = new System.Windows.Forms.TextBox();
            this.cPwdlbl = new System.Windows.Forms.Label();
            this.new_Pwdlbl = new System.Windows.Forms.Label();
            this.Mainlbl = new System.Windows.Forms.Label();
            this.Userlbl = new System.Windows.Forms.Label();
            this.txt_newpwd = new System.Windows.Forms.TextBox();
            this.ChamgeBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChamgeBox1
            // 
            this.ChamgeBox1.BackColor = System.Drawing.Color.Transparent;
            this.ChamgeBox1.Controls.Add(this.txt_newpwd);
            this.ChamgeBox1.Controls.Add(this.btn_back);
            this.ChamgeBox1.Controls.Add(this.btn_update);
            this.ChamgeBox1.Controls.Add(this.txt_cpwd);
            this.ChamgeBox1.Controls.Add(this.cPwdlbl);
            this.ChamgeBox1.Controls.Add(this.new_Pwdlbl);
            this.ChamgeBox1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChamgeBox1.ForeColor = System.Drawing.Color.White;
            this.ChamgeBox1.Location = new System.Drawing.Point(180, 259);
            this.ChamgeBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ChamgeBox1.Name = "ChamgeBox1";
            this.ChamgeBox1.Padding = new System.Windows.Forms.Padding(4);
            this.ChamgeBox1.Size = new System.Drawing.Size(527, 302);
            this.ChamgeBox1.TabIndex = 5;
            this.ChamgeBox1.TabStop = false;
            this.ChamgeBox1.Text = "CHANGE PASSWORD";
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.ForeColor = System.Drawing.Color.Red;
            this.btn_back.Location = new System.Drawing.Point(373, 226);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(116, 37);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.ForeColor = System.Drawing.Color.Blue;
            this.btn_update.Location = new System.Drawing.Point(40, 226);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(285, 37);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "UPDATE PASSWORD";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_cpwd
            // 
            this.txt_cpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cpwd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpwd.Location = new System.Drawing.Point(238, 135);
            this.txt_cpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cpwd.Name = "txt_cpwd";
            this.txt_cpwd.Size = new System.Drawing.Size(251, 26);
            this.txt_cpwd.TabIndex = 2;
            this.txt_cpwd.UseSystemPasswordChar = true;
            // 
            // cPwdlbl
            // 
            this.cPwdlbl.AutoSize = true;
            this.cPwdlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPwdlbl.Location = new System.Drawing.Point(36, 138);
            this.cPwdlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cPwdlbl.Name = "cPwdlbl";
            this.cPwdlbl.Size = new System.Drawing.Size(183, 23);
            this.cPwdlbl.TabIndex = 1;
            this.cPwdlbl.Text = "Confirm Password";
            // 
            // new_Pwdlbl
            // 
            this.new_Pwdlbl.AutoSize = true;
            this.new_Pwdlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_Pwdlbl.Location = new System.Drawing.Point(36, 78);
            this.new_Pwdlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.new_Pwdlbl.Name = "new_Pwdlbl";
            this.new_Pwdlbl.Size = new System.Drawing.Size(150, 23);
            this.new_Pwdlbl.TabIndex = 0;
            this.new_Pwdlbl.Text = "New Password";
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.ForeColor = System.Drawing.Color.White;
            this.Mainlbl.Location = new System.Drawing.Point(171, 122);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(536, 51);
            this.Mainlbl.TabIndex = 4;
            this.Mainlbl.Text = "Library Management System";
            // 
            // Userlbl
            // 
            this.Userlbl.AutoSize = true;
            this.Userlbl.BackColor = System.Drawing.Color.Transparent;
            this.Userlbl.Font = new System.Drawing.Font("Castellar", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlbl.ForeColor = System.Drawing.Color.Black;
            this.Userlbl.Location = new System.Drawing.Point(865, 540);
            this.Userlbl.Name = "Userlbl";
            this.Userlbl.Size = new System.Drawing.Size(15, 21);
            this.Userlbl.TabIndex = 33;
            this.Userlbl.Text = ".";
            // 
            // txt_newpwd
            // 
            this.txt_newpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newpwd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpwd.Location = new System.Drawing.Point(238, 80);
            this.txt_newpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_newpwd.Name = "txt_newpwd";
            this.txt_newpwd.Size = new System.Drawing.Size(251, 26);
            this.txt_newpwd.TabIndex = 6;
            this.txt_newpwd.UseSystemPasswordChar = true;
            // 
            // CHANGE_PASSWORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources._162410;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Userlbl);
            this.Controls.Add(this.ChamgeBox1);
            this.Controls.Add(this.Mainlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CHANGE_PASSWORD";
            this.Text = "Change Password :: Library Management System";
            this.ChamgeBox1.ResumeLayout(false);
            this.ChamgeBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ChamgeBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_cpwd;
        private System.Windows.Forms.Label cPwdlbl;
        private System.Windows.Forms.Label new_Pwdlbl;
        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Label Userlbl;
        private System.Windows.Forms.TextBox txt_newpwd;
    }
}