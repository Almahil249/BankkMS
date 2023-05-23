namespace BankkMS
{
    partial class ManageBankForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.branchCity = new System.Windows.Forms.TextBox();
            this.branchStreet = new System.Windows.Forms.TextBox();
            this.branchName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.bankId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.branchNameDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.branchId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.branchCity);
            this.panel1.Controls.Add(this.branchStreet);
            this.panel1.Controls.Add(this.branchName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.bankId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 228);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(36, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Add new branch";
            // 
            // branchCity
            // 
            this.branchCity.Location = new System.Drawing.Point(210, 182);
            this.branchCity.Name = "branchCity";
            this.branchCity.Size = new System.Drawing.Size(168, 22);
            this.branchCity.TabIndex = 17;
            // 
            // branchStreet
            // 
            this.branchStreet.Location = new System.Drawing.Point(210, 142);
            this.branchStreet.Name = "branchStreet";
            this.branchStreet.Size = new System.Drawing.Size(168, 22);
            this.branchStreet.TabIndex = 16;
            // 
            // branchName
            // 
            this.branchName.Location = new System.Drawing.Point(210, 100);
            this.branchName.Name = "branchName";
            this.branchName.Size = new System.Drawing.Size(168, 22);
            this.branchName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Branch City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Branch Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Branch Name:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(303, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // bankId
            // 
            this.bankId.Location = new System.Drawing.Point(210, 55);
            this.bankId.Name = "bankId";
            this.bankId.Size = new System.Drawing.Size(168, 22);
            this.bankId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bank ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.branchNameDelete);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.branchId);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 228);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(29, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Delete branch";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(278, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // branchNameDelete
            // 
            this.branchNameDelete.Location = new System.Drawing.Point(185, 135);
            this.branchNameDelete.Name = "branchNameDelete";
            this.branchNameDelete.Size = new System.Drawing.Size(168, 22);
            this.branchNameDelete.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Branch Name:";
            // 
            // branchId
            // 
            this.branchId.Location = new System.Drawing.Point(185, 72);
            this.branchId.Name = "branchId";
            this.branchId.Size = new System.Drawing.Size(168, 22);
            this.branchId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Branch ID:";
            // 
            // ManageBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageBankForm";
            this.Text = "ManageBankForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox bankId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox branchCity;
        private System.Windows.Forms.TextBox branchStreet;
        private System.Windows.Forms.TextBox branchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox branchNameDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox branchId;
        private System.Windows.Forms.Label label7;
    }
}