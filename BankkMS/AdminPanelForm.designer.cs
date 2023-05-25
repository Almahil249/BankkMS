namespace BankkMS
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.buttonManageBank = new System.Windows.Forms.Button();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.buttonShowData = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.Controls.Add(this.LogOut);
            this.panelMenu.Controls.Add(this.buttonManageBank);
            this.panelMenu.Controls.Add(this.buttonAddBank);
            this.panelMenu.Controls.Add(this.buttonShowData);
            this.panelMenu.Controls.Add(this.panelTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(167, 653);
            this.panelMenu.TabIndex = 0;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.Location = new System.Drawing.Point(0, 221);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(167, 46);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "LOG OUT";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // buttonManageBank
            // 
            this.buttonManageBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManageBank.Location = new System.Drawing.Point(0, 175);
            this.buttonManageBank.Name = "buttonManageBank";
            this.buttonManageBank.Size = new System.Drawing.Size(167, 46);
            this.buttonManageBank.TabIndex = 4;
            this.buttonManageBank.Text = "Manage Bank";
            this.buttonManageBank.UseVisualStyleBackColor = true;
            this.buttonManageBank.Click += new System.EventHandler(this.buttonManageBank_Click);
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddBank.Location = new System.Drawing.Point(0, 129);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(167, 46);
            this.buttonAddBank.TabIndex = 2;
            this.buttonAddBank.Text = "Add Bank";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // buttonShowData
            // 
            this.buttonShowData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonShowData.Location = new System.Drawing.Point(0, 83);
            this.buttonShowData.Name = "buttonShowData";
            this.buttonShowData.Size = new System.Drawing.Size(167, 46);
            this.buttonShowData.TabIndex = 1;
            this.buttonShowData.Text = "Show All Data";
            this.buttonShowData.UseVisualStyleBackColor = true;
            this.buttonShowData.Click += new System.EventHandler(this.buttonShowData_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(167, 83);
            this.panelTitle.TabIndex = 0;
            this.panelTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitle_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(36, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(83, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Admin Panel";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::BankkMS.Properties.Resources.open_uri20211230_15_18s1lgf;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(167, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1019, 653);
            this.panelContent.TabIndex = 1;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 653);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonShowData;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonManageBank;
        private System.Windows.Forms.Button buttonAddBank;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button LogOut;
    }
}