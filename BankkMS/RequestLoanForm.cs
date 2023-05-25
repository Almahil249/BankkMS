using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BankkMS
{
    public partial class RequestLoanForm : Form
    {
        public RequestLoanForm()
        {
            InitializeComponent();
        }

        //private void submitButton_Click(object sender, EventArgs e)
        //{

        //    DBHelper.OpenConn();
        //    string queryCheck = "SELECT COUNT(*) FROM [dbo].[Loans] WHERE Bnk_ID = '" + accountId.Text + "'";
        //    int bankCount = DBHelper.CheckExists(queryCheck);
        //    int branchCount = DBHelper.CheckExists(queryCheck);
        //    if (bankCount > 0 && branchCount > 0)
        //    {
        //        string selectedValue = string.Empty;

        //        if (personal.Checked)
        //        {
        //            selectedValue = personal.Name;
        //        }
        //        else if (industry.Checked)
        //        {
        //            selectedValue = personal.Name;
        //        }
        //        else if (commercial.Checked)
        //        {
        //            selectedValue = commercial.Name;
        //        }
        //        string query = "INSERT INTO [dbo].[Loans_Requests]([Loan_ID],[Acc_Number])VALUES('" + loanId.Text + "', '" + accountId.Text + "')";
        //        DBHelper.OpenConn();
        //        DBHelper.insertData(query);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bank ID not found");
        //    }
        //    DBHelper.CloseConn();
        //    ClearText();
        //}

        private void submitButton_Click(object sender, EventArgs e)
        {

            DBHelper.OpenConn();
            string queryCheck = "SELECT COUNT(*) FROM [dbo].[Loans] WHERE Loan_ID = '" + loanId.Text + "'";
            string queryCheck1 = "SELECT COUNT(*) FROM [dbo].[Accounts] WHERE Acc_Number = '" + accountId.Text + "'";
            int loanCount = DBHelper.CheckExists(queryCheck);
            int accountCount = DBHelper.CheckExists(queryCheck1);
            if (loanCount > 0 && accountCount > 0)
            {
                string queryCheck2 = "SELECT COUNT(*) FROM Loans l JOIN Branchs b ON l.Br_ID = b.Br_ID  JOIN Accounts a ON a.Br_ID = b.Br_ID WHERE l.Loan_ID = '"+ loanId.Text+ "' AND a.Acc_Number = '"+ accountId.Text+ "'";
                int IsLoanInAccBr = DBHelper.CheckExists(queryCheck2);
                if (IsLoanInAccBr == 1)
                {
                    string query = "INSERT INTO [dbo].[Loans_Requests]([Loan_ID],[Acc_Number],[Loan_State])VALUES('" + loanId.Text + "', '" + accountId.Text + "','PENDING')";
                    DBHelper.insertData(query);
                }
                else
                {
                    MessageBox.Show("This Loan Offer in Not in Account Branch, try again");


                }

            }
            else
            {
                MessageBox.Show("Loan ID or Account ID not found, try again");
            }
            DBHelper.CloseConn();
            ClearText();
        }

        private void ClearText()
        {
            accountId.Clear();
            loanId.Clear();
        }

        private void RequestLoanForm_Load(object sender, EventArgs e)
        {
            string query1 = "select * from Loans";
            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;
        }
    }
}
