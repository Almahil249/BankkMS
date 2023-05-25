using System;
using System.Collections;
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
    public partial class Withdrawal : Form
    {
        string SSN_fromPanle;
        public Withdrawal(string SSN_Panle)
        {
            InitializeComponent();
            SSN_fromPanle = SSN_Panle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string AmountUpdate = "UPDATE Accounts SET Acc_Balance = Acc_Balance - '" + Amount_Read.Text + "' Where Acc_Number = '" + Acc_read.Text + "'";
                string TransactionUpdate = "INSERT INTO Transactions(Transaction_Type, Transaction_Amount, Acc_Number)  Values('Withdrawal', '-" + Amount_Read.Text + "', '" + Acc_read.Text + "')";
                string AccCheck = "SELECT COUNT(*) FROM Accounts WHERE Acc_Number= '" + Acc_read.Text + "' AND Customer_SSN = '" + SSN_fromPanle + "'";
                DBHelper.OpenConn();
                int Is_AccValid = DBHelper.CheckExists(AccCheck);
                DBHelper.CloseConn();
                if (Is_AccValid == 1)
                {
                    string BalnceCheck = "SELECT Acc_Balance FROM Accounts WHERE Acc_Number= '" + Acc_read.Text + "' AND Customer_SSN = '" + SSN_fromPanle + "'";
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(BalnceCheck, conn);
                    float Balance = (float)Convert.ToDouble(cmd.ExecuteScalar());
                    conn.Close();

                    if (Convert.ToInt32(Amount_Read.Text) > 0)
                    {
                        
                        if (Balance >= (float)Convert.ToDouble(Amount_Read.Text))
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
                            string balance_is = Convert.ToString(Balance);
                            MessageBox.Show("Incefition balance on account!,Your balance ="+balance_is+" , try again");

                        }

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
