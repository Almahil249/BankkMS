namespace BankkMS
{
    partial class login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_Page));
            this.LogIn = new System.Windows.Forms.Button();
            this.newAccount_LNK = new System.Windows.Forms.LinkLabel();
            this.welcomeMSG = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Label();
            this.Account_type = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.RadioButton();
            this.Employee = new System.Windows.Forms.RadioButton();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Password_Read = new System.Windows.Forms.TextBox();
            this.Username_Read = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.AccessibleDescription = "Login";
            this.LogIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn.Location = new System.Drawing.Point(253, 470);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(147, 45);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = false;
            // 
            // newAccount_LNK
            // 
            this.newAccount_LNK.AutoSize = true;
            this.newAccount_LNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccount_LNK.Location = new System.Drawing.Point(444, 483);
            this.newAccount_LNK.Name = "newAccount_LNK";
            this.newAccount_LNK.Size = new System.Drawing.Size(130, 18);
            this.newAccount_LNK.TabIndex = 1;
            this.newAccount_LNK.TabStop = true;
            this.newAccount_LNK.Text = "Create an Account";
            // 
            // welcomeMSG
            // 
            this.welcomeMSG.AutoSize = true;
            this.welcomeMSG.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMSG.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMSG.Location = new System.Drawing.Point(93, 35);
            this.welcomeMSG.Name = "welcomeMSG";
            this.welcomeMSG.Size = new System.Drawing.Size(645, 80);
            this.welcomeMSG.TabIndex = 3;
            this.welcomeMSG.Text = "Welcome To Banks MS";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(210, 375);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(94, 34);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.BackColor = System.Drawing.Color.Transparent;
            this.User_name.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_name.Location = new System.Drawing.Point(201, 307);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(108, 34);
            this.User_name.TabIndex = 3;
            this.User_name.Text = "User Name";
            // 
            // Account_type
            // 
            this.Account_type.AutoSize = true;
            this.Account_type.BackColor = System.Drawing.Color.Transparent;
            this.Account_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_type.Location = new System.Drawing.Point(26, 18);
            this.Account_type.Name = "Account_type";
            this.Account_type.Size = new System.Drawing.Size(175, 31);
            this.Account_type.TabIndex = 3;
            this.Account_type.Text = "Account type:";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.BackColor = System.Drawing.Color.Transparent;
            this.Customer.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(54, 50);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(147, 35);
            this.Customer.TabIndex = 4;
            this.Customer.TabStop = true;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.BackColor = System.Drawing.Color.Transparent;
            this.Employee.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(217, 50);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(147, 35);
            this.Employee.TabIndex = 4;
            this.Employee.TabStop = true;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(423, 50);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(112, 35);
            this.Admin.TabIndex = 4;
            this.Admin.TabStop = true;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            // 
            // Password_Read
            // 
            this.Password_Read.Location = new System.Drawing.Point(345, 372);
            this.Password_Read.Multiline = true;
            this.Password_Read.Name = "Password_Read";
            this.Password_Read.Size = new System.Drawing.Size(296, 27);
            this.Password_Read.TabIndex = 5;
            this.Password_Read.Text = "Please Enter your Password";
            // 
            // Username_Read
            // 
            this.Username_Read.AcceptsReturn = true;
            this.Username_Read.Location = new System.Drawing.Point(345, 304);
            this.Username_Read.Multiline = true;
            this.Username_Read.Name = "Username_Read";
            this.Username_Read.Size = new System.Drawing.Size(296, 27);
            this.Username_Read.TabIndex = 5;
            this.Username_Read.Text = "Please Enter your Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Account_type);
            this.groupBox1.Controls.Add(this.Customer);
            this.groupBox1.Controls.Add(this.Employee);
            this.groupBox1.Controls.Add(this.Admin);
            this.groupBox1.Location = new System.Drawing.Point(149, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Username_Read);
            this.Controls.Add(this.Password_Read);
            this.Controls.Add(this.User_name);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.welcomeMSG);
            this.Controls.Add(this.newAccount_LNK);
            this.Controls.Add(this.LogIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_Page";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.LinkLabel newAccount_LNK;
        private System.Windows.Forms.Label welcomeMSG;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.Label Account_type;
        private System.Windows.Forms.RadioButton Customer;
        private System.Windows.Forms.RadioButton Employee;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.TextBox Password_Read;
        private System.Windows.Forms.TextBox Username_Read;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

