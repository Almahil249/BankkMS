namespace BankkMS
{
    partial class OpenAccountForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.ssn = new System.Windows.Forms.TextBox();
            this.accountBalance = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.branchId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bankId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(49, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Open New Account";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(474, 332);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(107, 56);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Open Account";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(188, 196);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(168, 22);
            this.ssn.TabIndex = 13;
            // 
            // accountBalance
            // 
            this.accountBalance.Location = new System.Drawing.Point(188, 143);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(168, 22);
            this.accountBalance.TabIndex = 12;
            // 
            // accountType
            // 
            this.accountType.Location = new System.Drawing.Point(188, 93);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(168, 22);
            this.accountType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SSN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Type:";
            // 
            // branchId
            // 
            this.branchId.Location = new System.Drawing.Point(188, 249);
            this.branchId.Name = "branchId";
            this.branchId.Size = new System.Drawing.Size(168, 22);
            this.branchId.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Branch ID:";
            // 
            // bankId
            // 
            this.bankId.Location = new System.Drawing.Point(188, 298);
            this.bankId.Name = "bankId";
            this.bankId.Size = new System.Drawing.Size(168, 22);
            this.bankId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bank ID:";
            // 
            // OpenAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bankId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.branchId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ssn);
            this.Controls.Add(this.accountBalance);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpenAccountForm";
            this.Text = "OpenAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.TextBox accountBalance;
        private System.Windows.Forms.TextBox accountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox branchId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bankId;
        private System.Windows.Forms.Label label6;
    }
}