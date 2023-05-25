using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankkMS
{
    public partial class creat_loan : Form
    {
        int BrId;
        int BnkID;
        public creat_loan(int BrFromPanle)
        {
            InitializeComponent();
            BrId = BrFromPanle;
            string scmnd = "SELECT Bnk_ID FROM Branchs  where Br_ID = '"+BrId+"'";
            DBHelper.OpenConn();
            BnkID = DBHelper.CheckExists(scmnd);
            DBHelper.CloseConn();

            }


        private void AddLoan_Click(object sender, EventArgs e)
        {
            if(Amount.Text !="" && Loan_type.Text !="" && interest.Text != "")
            {
              

                DBHelper.OpenConn();
                string command = "insert into Loans (Loan_Amount ,Loan_Interest ,Bnk_ID ,Br_ID,Loan_Type) values (" + Amount.Text + "," + interest.Text + "," + BnkID + "," + BrId + ",'" + Loan_type.Text + "')";
                DBHelper.insertData(command);
                DBHelper.CloseConn();
                this.Close();


            }
            else
            {
                MessageBox.Show("Fill in all The Blancks! ");

            }

        }

 
    
    }
}
