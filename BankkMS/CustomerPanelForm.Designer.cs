namespace BankkMS
{
    partial class CustomerPanelForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.openAccount = new System.Windows.Forms.Button();
            this.buttonLoanRequest = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.openAccount);
            this.panelMenu.Controls.Add(this.buttonLoanRequest);
            this.panelMenu.Controls.Add(this.buttonTransactions);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(167, 450);
            this.panelMenu.TabIndex = 2;
            // 
            // openAccount
            // 
            this.openAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.openAccount.Location = new System.Drawing.Point(0, 175);
            this.openAccount.Name = "openAccount";
            this.openAccount.Size = new System.Drawing.Size(167, 46);
            this.openAccount.TabIndex = 5;
            this.openAccount.Text = "Open Account";
            this.openAccount.UseVisualStyleBackColor = true;
            this.openAccount.Click += new System.EventHandler(this.openAccount_Click);
            // 
            // buttonLoanRequest
            // 
            this.buttonLoanRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLoanRequest.Location = new System.Drawing.Point(0, 129);
            this.buttonLoanRequest.Name = "buttonLoanRequest";
            this.buttonLoanRequest.Size = new System.Drawing.Size(167, 46);
            this.buttonLoanRequest.TabIndex = 4;
            this.buttonLoanRequest.Text = "Request Loan";
            this.buttonLoanRequest.UseVisualStyleBackColor = true;
            this.buttonLoanRequest.Click += new System.EventHandler(this.buttonLoanRequest_Click);
            // 
            // buttonTransactions
            // 
            this.buttonTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTransactions.Location = new System.Drawing.Point(0, 83);
            this.buttonTransactions.Name = "buttonTransactions";
            this.buttonTransactions.Size = new System.Drawing.Size(167, 46);
            this.buttonTransactions.TabIndex = 2;
            this.buttonTransactions.Text = "Transactions";
            this.buttonTransactions.UseVisualStyleBackColor = true;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(167, 83);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(36, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Customer Panel";
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Location = new System.Drawing.Point(166, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(634, 450);
            this.panelContent.TabIndex = 3;
            // 
            // CustomerPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelContent);
            this.Name = "CustomerPanelForm";
            this.Text = "CustomerPanelForm";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLoanRequest;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button openAccount;
    }
}