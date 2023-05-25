namespace BankkMS
{
    partial class Customer_Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Signup));
            this.Signin_lnk = new System.Windows.Forms.LinkLabel();
            this.Sign_up = new System.Windows.Forms.Button();
            this.Password_Read = new System.Windows.Forms.TextBox();
            this.User_name_Read = new System.Windows.Forms.TextBox();
            this.Read_Age = new System.Windows.Forms.TextBox();
            this.Password_MSG = new System.Windows.Forms.Label();
            this.Phone_Read = new System.Windows.Forms.TextBox();
            this.Age_MSG = new System.Windows.Forms.Label();
            this.City_Read = new System.Windows.Forms.TextBox();
            this.SSN_Read = new System.Windows.Forms.TextBox();
            this.City_MSG = new System.Windows.Forms.Label();
            this.SSN_MSG = new System.Windows.Forms.Label();
            this.Street_Read = new System.Windows.Forms.TextBox();
            this.Street_MSG = new System.Windows.Forms.Label();
            this.Name_Read = new System.Windows.Forms.TextBox();
            this.Name_MSG = new System.Windows.Forms.Label();
            this.SignupMSG = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName_MSG = new System.Windows.Forms.Label();
            this.Phone_MSG = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Signin_lnk
            // 
            this.Signin_lnk.AutoSize = true;
            this.Signin_lnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_lnk.Location = new System.Drawing.Point(446, 537);
            this.Signin_lnk.Name = "Signin_lnk";
            this.Signin_lnk.Size = new System.Drawing.Size(69, 20);
            this.Signin_lnk.TabIndex = 10;
            this.Signin_lnk.TabStop = true;
            this.Signin_lnk.Text = "Sign In?";
            this.Signin_lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signin_lnk_LinkClicked);
            // 
            // Sign_up
            // 
            this.Sign_up.AccessibleDescription = "";
            this.Sign_up.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sign_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_up.Location = new System.Drawing.Point(276, 525);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(147, 45);
            this.Sign_up.TabIndex = 9;
            this.Sign_up.Text = "Sign Up";
            this.Sign_up.UseVisualStyleBackColor = false;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // Password_Read
            // 
            this.Password_Read.Location = new System.Drawing.Point(400, 415);
            this.Password_Read.Multiline = true;
            this.Password_Read.Name = "Password_Read";
            this.Password_Read.Size = new System.Drawing.Size(249, 38);
            this.Password_Read.TabIndex = 2;
            // 
            // User_name_Read
            // 
            this.User_name_Read.Location = new System.Drawing.Point(21, 415);
            this.User_name_Read.Multiline = true;
            this.User_name_Read.Name = "User_name_Read";
            this.User_name_Read.Size = new System.Drawing.Size(301, 38);
            this.User_name_Read.TabIndex = 2;
            // 
            // Read_Age
            // 
            this.Read_Age.Location = new System.Drawing.Point(400, 331);
            this.Read_Age.Multiline = true;
            this.Read_Age.Name = "Read_Age";
            this.Read_Age.Size = new System.Drawing.Size(249, 38);
            this.Read_Age.TabIndex = 2;
            // 
            // Password_MSG
            // 
            this.Password_MSG.AutoSize = true;
            this.Password_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_MSG.Location = new System.Drawing.Point(397, 383);
            this.Password_MSG.Name = "Password_MSG";
            this.Password_MSG.Size = new System.Drawing.Size(81, 18);
            this.Password_MSG.TabIndex = 1;
            this.Password_MSG.Text = "Password";
            // 
            // Phone_Read
            // 
            this.Phone_Read.Location = new System.Drawing.Point(21, 331);
            this.Phone_Read.Multiline = true;
            this.Phone_Read.Name = "Phone_Read";
            this.Phone_Read.Size = new System.Drawing.Size(301, 38);
            this.Phone_Read.TabIndex = 2;
            // 
            // Age_MSG
            // 
            this.Age_MSG.AutoSize = true;
            this.Age_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_MSG.Location = new System.Drawing.Point(397, 299);
            this.Age_MSG.Name = "Age_MSG";
            this.Age_MSG.Size = new System.Drawing.Size(35, 18);
            this.Age_MSG.TabIndex = 1;
            this.Age_MSG.Text = "Age";
            // 
            // City_Read
            // 
            this.City_Read.Location = new System.Drawing.Point(400, 252);
            this.City_Read.Multiline = true;
            this.City_Read.Name = "City_Read";
            this.City_Read.Size = new System.Drawing.Size(249, 38);
            this.City_Read.TabIndex = 2;
            // 
            // SSN_Read
            // 
            this.SSN_Read.Location = new System.Drawing.Point(21, 252);
            this.SSN_Read.Multiline = true;
            this.SSN_Read.Name = "SSN_Read";
            this.SSN_Read.Size = new System.Drawing.Size(301, 38);
            this.SSN_Read.TabIndex = 2;
            // 
            // City_MSG
            // 
            this.City_MSG.AutoSize = true;
            this.City_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_MSG.Location = new System.Drawing.Point(397, 220);
            this.City_MSG.Name = "City_MSG";
            this.City_MSG.Size = new System.Drawing.Size(37, 18);
            this.City_MSG.TabIndex = 1;
            this.City_MSG.Text = "City";
            // 
            // SSN_MSG
            // 
            this.SSN_MSG.AutoSize = true;
            this.SSN_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN_MSG.Location = new System.Drawing.Point(18, 220);
            this.SSN_MSG.Name = "SSN_MSG";
            this.SSN_MSG.Size = new System.Drawing.Size(203, 18);
            this.SSN_MSG.TabIndex = 1;
            this.SSN_MSG.Text = "National ID number(SSN)";
            // 
            // Street_Read
            // 
            this.Street_Read.Location = new System.Drawing.Point(400, 171);
            this.Street_Read.Multiline = true;
            this.Street_Read.Name = "Street_Read";
            this.Street_Read.Size = new System.Drawing.Size(249, 38);
            this.Street_Read.TabIndex = 2;
            // 
            // Street_MSG
            // 
            this.Street_MSG.AutoSize = true;
            this.Street_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Street_MSG.Location = new System.Drawing.Point(397, 139);
            this.Street_MSG.Name = "Street_MSG";
            this.Street_MSG.Size = new System.Drawing.Size(118, 18);
            this.Street_MSG.TabIndex = 1;
            this.Street_MSG.Text = "Street Address";
            // 
            // Name_Read
            // 
            this.Name_Read.Location = new System.Drawing.Point(21, 171);
            this.Name_Read.Multiline = true;
            this.Name_Read.Name = "Name_Read";
            this.Name_Read.Size = new System.Drawing.Size(301, 38);
            this.Name_Read.TabIndex = 2;
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
            this.SignupMSG.Location = new System.Drawing.Point(201, 41);
            this.SignupMSG.Name = "SignupMSG";
            this.SignupMSG.Size = new System.Drawing.Size(277, 32);
            this.SignupMSG.TabIndex = 0;
            this.SignupMSG.Text = "Customer Sign Up";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Signin_lnk);
            this.panel1.Controls.Add(this.Sign_up);
            this.panel1.Controls.Add(this.Password_Read);
            this.panel1.Controls.Add(this.User_name_Read);
            this.panel1.Controls.Add(this.Read_Age);
            this.panel1.Controls.Add(this.UserName_MSG);
            this.panel1.Controls.Add(this.Password_MSG);
            this.panel1.Controls.Add(this.Phone_Read);
            this.panel1.Controls.Add(this.Phone_MSG);
            this.panel1.Controls.Add(this.Age_MSG);
            this.panel1.Controls.Add(this.City_Read);
            this.panel1.Controls.Add(this.SSN_Read);
            this.panel1.Controls.Add(this.City_MSG);
            this.panel1.Controls.Add(this.SSN_MSG);
            this.panel1.Controls.Add(this.Street_Read);
            this.panel1.Controls.Add(this.Street_MSG);
            this.panel1.Controls.Add(this.Name_Read);
            this.panel1.Controls.Add(this.Name_MSG);
            this.panel1.Controls.Add(this.SignupMSG);
            this.panel1.Location = new System.Drawing.Point(135, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 604);
            this.panel1.TabIndex = 2;
            // 
            // UserName_MSG
            // 
            this.UserName_MSG.AutoSize = true;
            this.UserName_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_MSG.Location = new System.Drawing.Point(18, 383);
            this.UserName_MSG.Name = "UserName_MSG";
            this.UserName_MSG.Size = new System.Drawing.Size(90, 18);
            this.UserName_MSG.TabIndex = 1;
            this.UserName_MSG.Text = "User Name";
            // 
            // Phone_MSG
            // 
            this.Phone_MSG.AutoSize = true;
            this.Phone_MSG.Font = new System.Drawing.Font("Georgia Pro Cond Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_MSG.Location = new System.Drawing.Point(18, 299);
            this.Phone_MSG.Name = "Phone_MSG";
            this.Phone_MSG.Size = new System.Drawing.Size(120, 18);
            this.Phone_MSG.TabIndex = 1;
            this.Phone_MSG.Text = "Phone Number";
            // 
            // Customer_Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankkMS.Properties.Resources.open_uri20211230_15_18s1lgf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 792);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Signup";
            this.Text = "Customer Sign up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel Signin_lnk;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.TextBox Password_Read;
        private System.Windows.Forms.TextBox User_name_Read;
        private System.Windows.Forms.TextBox Read_Age;
        private System.Windows.Forms.Label Password_MSG;
        private System.Windows.Forms.TextBox Phone_Read;
        private System.Windows.Forms.Label Age_MSG;
        private System.Windows.Forms.TextBox City_Read;
        private System.Windows.Forms.TextBox SSN_Read;
        private System.Windows.Forms.Label City_MSG;
        private System.Windows.Forms.Label SSN_MSG;
        private System.Windows.Forms.TextBox Street_Read;
        private System.Windows.Forms.Label Street_MSG;
        private System.Windows.Forms.TextBox Name_Read;
        private System.Windows.Forms.Label Name_MSG;
        private System.Windows.Forms.Label SignupMSG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Phone_MSG;
        private System.Windows.Forms.Label UserName_MSG;
    }
}