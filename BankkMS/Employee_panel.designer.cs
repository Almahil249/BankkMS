namespace BankkMS
{
    partial class Employee_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_panel));
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.ShowLoansReq = new System.Windows.Forms.Button();
            this.CreatLoan = new System.Windows.Forms.Button();
            this.TransactiosRprt = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::BankkMS.Properties.Resources.open_uri20211230_15_18s1lgf;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(178, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(813, 726);
            this.panelContent.TabIndex = 3;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.LogOut);
            this.panelMenu.Controls.Add(this.DeleteCustomer);
            this.panelMenu.Controls.Add(this.Edit);
            this.panelMenu.Controls.Add(this.AddCustomer);
            this.panelMenu.Controls.Add(this.ShowLoansReq);
            this.panelMenu.Controls.Add(this.CreatLoan);
            this.panelMenu.Controls.Add(this.TransactiosRprt);
            this.panelMenu.Controls.Add(this.Reports);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 726);
            this.panelMenu.TabIndex = 2;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.Location = new System.Drawing.Point(0, 405);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(178, 46);
            this.LogOut.TabIndex = 9;
            this.LogOut.Text = "LOG OUT";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteCustomer.Location = new System.Drawing.Point(0, 359);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(178, 46);
            this.DeleteCustomer.TabIndex = 8;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // Edit
            // 
            this.Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit.Location = new System.Drawing.Point(0, 313);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(178, 46);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit Customer Details";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddCustomer.Location = new System.Drawing.Point(0, 267);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(178, 46);
            this.AddCustomer.TabIndex = 6;
            this.AddCustomer.Text = "Add New Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // ShowLoansReq
            // 
            this.ShowLoansReq.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowLoansReq.Location = new System.Drawing.Point(0, 221);
            this.ShowLoansReq.Name = "ShowLoansReq";
            this.ShowLoansReq.Size = new System.Drawing.Size(178, 46);
            this.ShowLoansReq.TabIndex = 5;
            this.ShowLoansReq.Text = "Show Loans Requests";
            this.ShowLoansReq.UseVisualStyleBackColor = true;
            this.ShowLoansReq.Click += new System.EventHandler(this.ShowLoansReq_Click);
            // 
            // CreatLoan
            // 
            this.CreatLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreatLoan.Location = new System.Drawing.Point(0, 175);
            this.CreatLoan.Name = "CreatLoan";
            this.CreatLoan.Size = new System.Drawing.Size(178, 46);
            this.CreatLoan.TabIndex = 4;
            this.CreatLoan.Text = "Create Loan Offer";
            this.CreatLoan.UseVisualStyleBackColor = true;
            this.CreatLoan.Click += new System.EventHandler(this.CreatLoan_Click);
            // 
            // TransactiosRprt
            // 
            this.TransactiosRprt.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactiosRprt.Location = new System.Drawing.Point(0, 129);
            this.TransactiosRprt.Name = "TransactiosRprt";
            this.TransactiosRprt.Size = new System.Drawing.Size(178, 46);
            this.TransactiosRprt.TabIndex = 2;
            this.TransactiosRprt.Text = "Veiw Transactions";
            this.TransactiosRprt.UseVisualStyleBackColor = true;
            this.TransactiosRprt.Click += new System.EventHandler(this.TransactiosRprt_Click);
            // 
            // Reports
            // 
            this.Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports.Location = new System.Drawing.Point(0, 83);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(178, 46);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Show Branch Report";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(178, 83);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(42, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(107, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Employee Panle";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // Employee_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(991, 726);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_panel";
            this.Text = "Employee Panel";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button ShowLoansReq;
        private System.Windows.Forms.Button CreatLoan;
        private System.Windows.Forms.Button TransactiosRprt;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button LogOut;
    }
}