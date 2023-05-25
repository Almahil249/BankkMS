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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankkMS
{
    public partial class loan_requests : Form
    {
        int BrID;
        public loan_requests()
        {
            InitializeComponent();

        }
        public loan_requests(int BridFomEmp)
        {
            InitializeComponent();
            this.BrID = BridFomEmp;
        }

      

        private void loan_requests_Load(object sender, EventArgs e)
        {
            string query1 = "SELECT lr.Loan_Number,lr.Acc_Number,lr.Loan_ID,lr.Loan_State FROM Loans_Requests lr JOIN Loans l ON lr.Loan_ID = l.Loan_ID WHERE l.Br_ID = '"+BrID+"'";
            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;

        }

        private void Approve_Click(object sender, EventArgs e)
        {/*
            try
            {
                string query1 = "select count(*) from Loans_Requests where";

            }
            catch (Exception EXP)
            {
                MessageBox.Show(EXP.Message);

            }*/
        }
    }
}
