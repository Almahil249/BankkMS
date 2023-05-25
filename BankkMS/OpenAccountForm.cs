using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankkMS
{
    public partial class OpenAccountForm : Form
    {
        string SSN_User;

        public OpenAccountForm(string SSN_fromUserPanel)
        {
            SSN_User = SSN_fromUserPanel;

            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DBHelper.OpenConn();
            string queryCheck = "SELECT COUNT(*) FROM [dbo].[Customers] WHERE Customer_SSN = '" + SSN_User+ "'";
            string queryCheck1 = "SELECT COUNT(*) FROM [dbo].[Branchs] WHERE Br_ID = '" + branchId.Text + "' AND Bnk_ID = '" + bankId.Text + "'";
            int customerCount = DBHelper.CheckExists(queryCheck);
            int branchCount = DBHelper.CheckExists(queryCheck1);
            if (customerCount > 0 && branchCount > 0)
            {
                string query = "INSERT INTO [dbo].[Accounts]([Acc_Type],[Acc_Balance],[Customer_SSN],[Br_ID],[Bnk_ID]) VALUES ('" + accountType.Text + "', '" + accountBalance.Text + "', '" + SSN_User+ "', '" + branchId.Text + "', '" + bankId.Text + "')";
                DBHelper.insertData(query);
                ClearText();
            }
            else
            {
                MessageBox.Show("SSN or branch not found, try again");
            }
            DBHelper.CloseConn();
            
        }

        private void ClearText()
        {
            accountType.Clear();
            accountBalance.Clear();
            branchId.Clear();
            bankId.Clear();
        }



      
    }
}
