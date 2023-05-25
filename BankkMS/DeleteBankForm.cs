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
    public partial class DeleteBankForm : Form
    {
        public DeleteBankForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string BankId = bankId.Text.Trim();
            int id;
            string BankName = bankName.Text.Trim();
            if (int.TryParse(BankId, out id))
            {
                string query = "DELETE FROM [dbo].[Banks] WHERE Bnk_ID = @id AND Bnk_Name = @BankName";
                DBHelper.OpenConn();
                DBHelper.deleteData(query);
                DBHelper.CloseConn();
            }
            else
            {
                MessageBox.Show("Enter a valid Bank ID");
            }
            ClearText();
        }
        private void ClearText()
        {
            bankName.Clear();
            bankId.Clear();
        }
    }
}
