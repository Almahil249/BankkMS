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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPanelForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.withdrawal = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.openAccount = new System.Windows.Forms.Button();
            this.buttonLoanRequest = new System.Windows.Forms.Button();
            this.buttonTransactions = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.LogOut);
            this.panelMenu.Controls.Add(this.withdrawal);
            this.panelMenu.Controls.Add(this.deposit);
            this.panelMenu.Controls.Add(this.openAccount);
            this.panelMenu.Controls.Add(this.buttonLoanRequest);
            this.panelMenu.Controls.Add(this.buttonTransactions);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(165, 782);
            this.panelMenu.TabIndex = 2;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.LightCoral;
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogOut.Location = new System.Drawing.Point(0, 309);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(165, 46);
            this.LogOut.TabIndex = 12;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click_1);
            // 
            // withdrawal
            // 
            this.withdrawal.Dock = System.Windows.Forms.DockStyle.Top;
            this.withdrawal.Location = new System.Drawing.Point(0, 261);
            this.withdrawal.Name = "withdrawal";
            this.withdrawal.Size = new System.Drawing.Size(165, 48);
            this.withdrawal.TabIndex = 11;
            this.withdrawal.Text = "Withdrawal";
            this.withdrawal.UseVisualStyleBackColor = true;
            this.withdrawal.Click += new System.EventHandler(this.withdrawal_Click);
            // 
            // deposit
            // 
            this.deposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.deposit.Location = new System.Drawing.Point(0, 221);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(165, 40);
            this.deposit.TabIndex = 6;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // openAccount
            // 
            this.openAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.openAccount.Location = new System.Drawing.Point(0, 175);
            this.openAccount.Name = "openAccount";
            this.openAccount.Size = new System.Drawing.Size(165, 46);
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
            this.buttonLoanRequest.Size = new System.Drawing.Size(165, 46);
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
            this.buttonTransactions.Size = new System.Drawing.Size(165, 46);
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
            this.panelTitle.Size = new System.Drawing.Size(165, 83);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(23, 36);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(102, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Customer Panel";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContent.Location = new System.Drawing.Point(743, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(686, 782);
            this.panelContent.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 782);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 138);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "My Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(578, 119);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 138);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Accounts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // CustomerPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankkMS.Properties.Resources.open_uri20211230_15_18s1lgf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1429, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerPanelForm";
            this.Text = "Customer Panel";
            this.Load += new System.EventHandler(this.CustomerPanelForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button openAccount;
        private System.Windows.Forms.Button buttonLoanRequest;
        private System.Windows.Forms.Button buttonTransactions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button withdrawal;
    }
}