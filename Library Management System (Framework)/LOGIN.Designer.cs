
namespace LMS
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.Mainlbl = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.LoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainlbl
            // 
            this.Mainlbl.AutoSize = true;
            this.Mainlbl.BackColor = System.Drawing.Color.Transparent;
            this.Mainlbl.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlbl.ForeColor = System.Drawing.Color.White;
            this.Mainlbl.Location = new System.Drawing.Point(157, 119);
            this.Mainlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mainlbl.Name = "Mainlbl";
            this.Mainlbl.Size = new System.Drawing.Size(536, 51);
            this.Mainlbl.TabIndex = 11;
            this.Mainlbl.Text = "Library Management System";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.Location = new System.Drawing.Point(576, 529);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 37);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Blue;
            this.btn_login.Location = new System.Drawing.Point(166, 529);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(140, 37);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Register.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.Green;
            this.btn_Register.Location = new System.Drawing.Point(365, 529);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(164, 37);
            this.btn_Register.TabIndex = 9;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginBox.Controls.Add(this.Passwordtxt);
            this.LoginBox.Controls.Add(this.Usernametxt);
            this.LoginBox.Controls.Add(this.Passwordlbl);
            this.LoginBox.Controls.Add(this.Usernamelbl);
            this.LoginBox.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBox.ForeColor = System.Drawing.Color.White;
            this.LoginBox.Location = new System.Drawing.Point(166, 227);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Padding = new System.Windows.Forms.Padding(4);
            this.LoginBox.Size = new System.Drawing.Size(527, 262);
            this.LoginBox.TabIndex = 7;
            this.LoginBox.TabStop = false;
            this.LoginBox.Text = "Login User";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwordtxt.Font = new System.Drawing.Font("Arial", 10F);
            this.Passwordtxt.Location = new System.Drawing.Point(199, 148);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(279, 27);
            this.Passwordtxt.TabIndex = 2;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Usernametxt
            // 
            this.Usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usernametxt.Font = new System.Drawing.Font("Arial", 10F);
            this.Usernametxt.Location = new System.Drawing.Point(199, 80);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(279, 27);
            this.Usernametxt.TabIndex = 1;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(65, 153);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(103, 23);
            this.Passwordlbl.TabIndex = 1;
            this.Passwordlbl.Text = "Password";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.Color.White;
            this.Usernamelbl.Location = new System.Drawing.Point(65, 80);
            this.Usernamelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(108, 23);
            this.Usernamelbl.TabIndex = 0;
            this.Usernamelbl.Text = "Username";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Mainlbl);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.LoginBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LOGIN";
            this.Text = "Login :: Library Management System";
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mainlbl;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Usernamelbl;
    }
}

