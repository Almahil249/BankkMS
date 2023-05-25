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
    public partial class branch_report : Form
    {
        int Br_Id;//br id
        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public branch_report()
        {
            InitializeComponent();
        }
        public branch_report(int BR_ID)
        {
            InitializeComponent();
            this.Br_Id = BR_ID;
        }



        private void branch_report_Load(object sender, EventArgs e)
        {

            string query1 = "select * from Accounts where Br_ID = '" + Br_Id + "'";
            string query2 = "select * from Employees where Br_ID = '" + Br_Id + "'";
            string query3 = "select * from Loans where Br_ID = '" + Br_Id + "'";
            string query4 = "select Loans_Requests.Loan_Number, Loans.Loan_Amount ,Loans_Requests.Acc_Number, Loans_Requests.Loan_ID,  Loans_Requests.Loan_State from Loans_Requests , Loans where Loans.Loan_ID = Loans_Requests.Loan_ID AND Loans.Br_ID = '" + Br_Id + "'";
            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DataTable dtTable2 = DBHelper.readData(query2);
            DataTable dtTable3 = DBHelper.readData(query3);
            DataTable dtTable4 = DBHelper.readData(query4);
            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;
            dataGridView2.DataSource = dtTable2;
            dataGridView3.DataSource = dtTable3;
            dataGridView4.DataSource = dtTable4;
        }
    }
}
