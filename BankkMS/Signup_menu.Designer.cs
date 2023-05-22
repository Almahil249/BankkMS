namespace BankkMS
{
    partial class Signup_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup_menu));
            this.Account_type = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Account_type
            // 
            this.Account_type.AutoSize = true;
            this.Account_type.BackColor = System.Drawing.Color.Transparent;
            this.Account_type.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Account_type.Location = new System.Drawing.Point(115, 202);
            this.Account_type.Name = "Account_type";
            this.Account_type.Size = new System.Drawing.Size(187, 48);
            this.Account_type.TabIndex = 9;
            this.Account_type.Text = "Account type:";
            this.Account_type.Click += new System.EventHandler(this.Account_type_Click);
            // 
            // Customer
            // 
            this.Customer.AccessibleDescription = "";
            this.Customer.BackColor = System.Drawing.Color.Transparent;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(96, 351);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(175, 54);
            this.Customer.TabIndex = 13;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Admin
            // 
            this.Admin.AccessibleDescription = "";
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(619, 351);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(175, 54);
            this.Admin.TabIndex = 13;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Employee
            // 
            this.Employee.AccessibleDescription = "";
            this.Employee.BackColor = System.Drawing.Color.Transparent;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(344, 351);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(175, 54);
            this.Employee.TabIndex = 13;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Signup_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 679);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Account_type);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup_menu";
            this.Text = "Sign Up Menu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Account_type;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Employee;
    }
}