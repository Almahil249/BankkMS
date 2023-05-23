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
    public partial class AddBankForm : Form
    {
        public AddBankForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO [dbo].[Banks]([Bnk_Name],[Bnk_Street],[Bnk_City]) VALUES('"+bankName.Text+"', '"+bankStreet.Text+"', '"+bankCity.Text+"')";
            DBHelper.OpenConn();
            DBHelper.insertData(query);
            DBHelper.CloseConn();
            ClearText();
        }

        private void ClearText()
        {
            bankName.Clear();
            bankStreet.Clear();
            bankCity.Clear();
        }
    }
}
