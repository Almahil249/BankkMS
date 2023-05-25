using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankkMS
{
    public partial class ManageBankForm : Form
    {
        public ManageBankForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DBHelper.OpenConn();
            string queryCheck = "SELECT COUNT(*) FROM [dbo].[Banks] WHERE Bnk_ID = '" + bankId.Text + "'";
            if (DBHelper.CheckExists(queryCheck)>0)
            {
                string query = "INSERT INTO [dbo].[Branchs]([Br_Street],[Br_City],[Br_Name],[Bnk_ID]) VALUES('" + branchStreet.Text + "', '" + branchCity.Text + "', '" + branchName.Text + "', '" + bankId.Text + "')";
                DBHelper.insertData(query);
            }
            else
            {
                MessageBox.Show("Bank ID not found");
            }
            DBHelper.CloseConn();
            ClearText();
        }

        private void ClearText()
        {
            bankId.Clear();
            branchCity.Clear();
            branchName.Clear();
            branchStreet.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [dbo].[Branchs] WHERE Br_ID = '"+branchId.Text+"' AND Br_Name = '"+branchNameDelete.Text+"'";
            DBHelper.OpenConn();
            DBHelper.deleteData(query);
            DBHelper.CloseConn();
            ClearText();
        }
    }
}
