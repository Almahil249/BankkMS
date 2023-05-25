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
    public partial class Show_Transaction : Form
    {
        int Br_Id;

        public Show_Transaction(int BrId)
        {
            InitializeComponent();
            Br_Id = BrId;
        }

 

        private void Show_Transaction_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT t.Transaction_ID, t.Transaction_Type, t.Transaction_Amount, t.Acc_Number,b.Br_ID  FROM Transactions t JOIN Accounts a ON t.Acc_Number = a.Acc_Number JOIN Branchs b ON a.Br_ID = b.Br_ID AND a.Bnk_ID = b.Bnk_ID WHERE b.Br_ID = '" + Br_Id + "'";
            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;

        }
    }
}
