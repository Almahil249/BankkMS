﻿namespace BankkMS
{
    partial class Employee_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Signin_lnk = new System.Windows.Forms.LinkLabel();
            this.Sign_up = new System.Windows.Forms.Button();
            this.Password_Read = new System.Windows.Forms.TextBox();
            this.User_read = new System.Windows.Forms.TextBox();
            this.Password_MSG = new System.Windows.Forms.Label();
            this.UserName_Read = new System.Windows.Forms.Label();
            this.SSN_Read = new System.Windows.Forms.TextBox();
            this.SSN_MSG = new System.Windows.Forms.Label();
            this.Name_Read = new System.Windows.Forms.TextBox();
            this.Name_MSG = new System.Windows.Forms.Label();
            this.SignupMSG = new System.Windows.Forms.Label();
            this.BranchID = new System.Windows.Forms.Label();
            this.BranchID_MSG = new System.Windows.Forms.Label();
            this.BankID_Read = new System.Windows.Forms.TextBox();
            this.BranchID_Read = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Signin_lnk);
            this.panel1.Controls.Add(this.Sign_up);
            this.panel1.Controls.Add(this.BranchID_Read);
            this.panel1.Controls.Add(this.Password_Read);
            this.panel1.Controls.Add(this.BankID_Read);
            this.panel1.Controls.Add(this.User_read);
            this.panel1.Controls.Add(this.BranchID_MSG);
            this.panel1.Controls.Add(this.BranchID);
            this.panel1.Controls.Add(this.Password_MSG);
            this.panel1.Controls.Add(this.UserName_Read);
            this.panel1.Controls.Add(this.SSN_Read);
            this.panel1.Controls.Add(this.SSN_MSG);
            this.panel1.Controls.Add(this.Name_Read);
            this.panel1.Controls.Add(this.Name_MSG);
            this.panel1.Controls.Add(this.SignupMSG);
            this.panel1.Location = new System.Drawing.Point(98, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 546);
            this.panel1.TabIndex = 1;
            // 
            // Signin_lnk
            // 
            this.Signin_lnk.AutoSize = true;
            this.Signin_lnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_lnk.Location = new System.Drawing.Point(409, 446);
            this.Signin_lnk.Name = "Signin_lnk";
            this.Signin_lnk.Size = new System.Drawing.Size(69, 20);
            this.Signin_lnk.TabIndex = 10;
            this.Signin_lnk.TabStop = true;
            this.Signin_lnk.Text = "Sign In?";
            // 
            // Sign_up
            // 
            this.Sign_up.AccessibleDescription = "Login";
            this.Sign_up.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.Location = new System.Drawing.Point(239, 434);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(147, 45);
            this.Sign_up.TabIndex = 9;
            this.Sign_up.Text = "Sign Up";
            this.Sign_up.UseVisualStyleBackColor = false;
            // 
            // Password_Read
            // 
            this.Password_Read.Location = new System.Drawing.Point(362, 335);
            this.Password_Read.Multiline = true;
            this.Password_Read.Name = "Password_Read";
            this.Password_Read.Size = new System.Drawing.Size(301, 38);
            this.Password_Read.TabIndex = 2;
            this.Password_Read.TextChanged += new System.EventHandler(this.Password_Read_TextChanged);
            // 
            // User_read
            // 
            this.User_read.Location = new System.Drawing.Point(21, 335);
            this.User_read.Multiline = true;
            this.User_read.Name = "User_read";
            this.User_read.Size = new System.Drawing.Size(301, 38);
            this.User_read.TabIndex = 2;
            this.User_read.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Password_MSG
            // 
            this.Password_MSG.AutoSize = true;
            this.Password_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_MSG.Location = new System.Drawing.Point(359, 303);
            this.Password_MSG.Name = "Password_MSG";
            this.Password_MSG.Size = new System.Drawing.Size(81, 18);
            this.Password_MSG.TabIndex = 1;
            this.Password_MSG.Text = "Password";
            // 
            // UserName_Read
            // 
            this.UserName_Read.AutoSize = true;
            this.UserName_Read.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Read.Location = new System.Drawing.Point(18, 303);
            this.UserName_Read.Name = "UserName_Read";
            this.UserName_Read.Size = new System.Drawing.Size(90, 18);
            this.UserName_Read.TabIndex = 1;
            this.UserName_Read.Text = "User Name";
            // 
            // SSN_Read
            // 
            this.SSN_Read.Location = new System.Drawing.Point(362, 171);
            this.SSN_Read.Multiline = true;
            this.SSN_Read.Name = "SSN_Read";
            this.SSN_Read.Size = new System.Drawing.Size(301, 38);
            this.SSN_Read.TabIndex = 2;
            // 
            // SSN_MSG
            // 
            this.SSN_MSG.AutoSize = true;
            this.SSN_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN_MSG.Location = new System.Drawing.Point(359, 139);
            this.SSN_MSG.Name = "SSN_MSG";
            this.SSN_MSG.Size = new System.Drawing.Size(203, 18);
            this.SSN_MSG.TabIndex = 1;
            this.SSN_MSG.Text = "National ID number(SSN)";
            // 
            // Name_Read
            // 
            this.Name_Read.Location = new System.Drawing.Point(21, 171);
            this.Name_Read.Multiline = true;
            this.Name_Read.Name = "Name_Read";
            this.Name_Read.Size = new System.Drawing.Size(301, 38);
            this.Name_Read.TabIndex = 2;
            this.Name_Read.TextChanged += new System.EventHandler(this.Name_Read_TextChanged);
            // 
            // Name_MSG
            // 
            this.Name_MSG.AutoSize = true;
            this.Name_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_MSG.Location = new System.Drawing.Point(18, 139);
            this.Name_MSG.Name = "Name_MSG";
            this.Name_MSG.Size = new System.Drawing.Size(84, 18);
            this.Name_MSG.TabIndex = 1;
            this.Name_MSG.Text = "Full Name";
            // 
            // SignupMSG
            // 
            this.SignupMSG.AutoSize = true;
            this.SignupMSG.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupMSG.Location = new System.Drawing.Point(184, 41);
            this.SignupMSG.Name = "SignupMSG";
            this.SignupMSG.Size = new System.Drawing.Size(281, 32);
            this.SignupMSG.TabIndex = 0;
            this.SignupMSG.Text = "Employee Sign Up";
            // 
            // BranchID
            // 
            this.BranchID.AutoSize = true;
            this.BranchID.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID.Location = new System.Drawing.Point(18, 223);
            this.BranchID.Name = "BranchID";
            this.BranchID.Size = new System.Drawing.Size(70, 18);
            this.BranchID.TabIndex = 1;
            this.BranchID.Text = "Bank ID";
            this.BranchID.Click += new System.EventHandler(this.label1_Click);
            // 
            // BranchID_MSG
            // 
            this.BranchID_MSG.AutoSize = true;
            this.BranchID_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchID_MSG.Location = new System.Drawing.Point(359, 223);
            this.BranchID_MSG.Name = "BranchID_MSG";
            this.BranchID_MSG.Size = new System.Drawing.Size(87, 18);
            this.BranchID_MSG.TabIndex = 1;
            this.BranchID_MSG.Text = "Branch ID";
            // 
            // BankID_Read
            // 
            this.BankID_Read.Location = new System.Drawing.Point(21, 255);
            this.BankID_Read.Multiline = true;
            this.BankID_Read.Name = "BankID_Read";
            this.BankID_Read.Size = new System.Drawing.Size(301, 38);
            this.BankID_Read.TabIndex = 2;
            this.BankID_Read.TextChanged += new System.EventHandler(this.Bank_ID_TextChanged);
            // 
            // BranchID_Read
            // 
            this.BranchID_Read.Location = new System.Drawing.Point(362, 255);
            this.BranchID_Read.Multiline = true;
            this.BranchID_Read.Name = "BranchID_Read";
            this.BranchID_Read.Size = new System.Drawing.Size(301, 38);
            this.BranchID_Read.TabIndex = 2;
            // 
            // Employee_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 703);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Signup";
            this.Text = "Employee_Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel Signin_lnk;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.TextBox BranchID_Read;
        private System.Windows.Forms.TextBox Password_Read;
        private System.Windows.Forms.TextBox BankID_Read;
        private System.Windows.Forms.TextBox User_read;
        private System.Windows.Forms.Label BranchID_MSG;
        private System.Windows.Forms.Label BranchID;
        private System.Windows.Forms.Label Password_MSG;
        private System.Windows.Forms.Label UserName_Read;
        private System.Windows.Forms.TextBox SSN_Read;
        private System.Windows.Forms.Label SSN_MSG;
        private System.Windows.Forms.TextBox Name_Read;
        private System.Windows.Forms.Label Name_MSG;
        private System.Windows.Forms.Label SignupMSG;
    }
}