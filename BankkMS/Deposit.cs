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
    public partial class Deposit : Form
    {
        string SSN_fromPanle;
        public Deposit(string SSN_fromCpanle)
        {
            InitializeComponent();
            SSN_fromPanle = SSN_fromCpanle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string AmountUpdate = "UPDATE Accounts SET Acc_Balance = Acc_Balance + '" + Amount_Read.Text + "' Where Acc_Number = '" + Acc_read.Text + "'";
                string TransactionUpdate = "INSERT INTO Transactions(Transaction_Type, Transaction_Amount, Acc_Number)  Values('Deposite', '" + Amount_Read.Text + "', '" + Acc_read.Text + "')";
                string AccCheck = "SELECT COUNT(*) FROM Accounts WHERE Acc_Number= '" + Acc_read.Text + "' AND Customer_SSN = '" + SSN_fromPanle + "'";
                DBHelper.OpenConn();
                int Is_AccValid = DBHelper.CheckExists(AccCheck);
                DBHelper.CloseConn();
                if (Is_AccValid == 1)
                {

                   if(Convert.ToInt32(Amount_Read.Text) > 0)
                    {
                        DBHelper.OpenConn();
                        DBHelper.insertData(AmountUpdate);
                        DBHelper.CloseConn();
                        DBHelper.OpenConn();
                        DBHelper.insertData(TransactionUpdate);
                        DBHelper.CloseConn();
                    }
                   else
                    {
                        MessageBox.Show("Invalid Amount!, try again");

                    }
                }
                else
                {
                    MessageBox.Show("Account Not Found, try again");
                }


            }
            catch (Exception EXP)
            {
                MessageBox.Show(EXP.Message);
            }
        }
    }
}
