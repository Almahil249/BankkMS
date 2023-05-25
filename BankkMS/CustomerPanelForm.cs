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
    public partial class CustomerPanelForm : Form
    {
        string SSN_FromLogin;
        public CustomerPanelForm(string Customer_LoginSSN)
        {
            SSN_FromLogin= Customer_LoginSSN;

            InitializeComponent();
        }
     
        private void LoadChildFormIntoPanel(Form childForm)
        {
            panelContent.Controls.Clear();


            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(childForm);

            childForm.Show();
        }


        private void buttonTransactions_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new AddBankForm());
        }

        private void buttonLoanRequest_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new RequestLoanForm());
        }

        private void openAccount_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new OpenAccountForm(SSN_FromLogin));
        }

        private void CustomerPanelForm_Load(object sender, EventArgs e)
        {
            string query1 = "select Acc_Number,Acc_Type,Acc_Balance,Br_ID from Accounts where Customer_SSN = '" + SSN_FromLogin+"'";
            string query2 = "select Customer_SSN,Customer_Name,Customer_Phone,City,Street from Customers where Customer_SSN = '" + SSN_FromLogin + "'";

            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DataTable dtTable2 = DBHelper.readData(query2);

            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;
            dataGridView2.DataSource = dtTable2;

        }

    

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            panelContent.Controls.Clear();

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login_Page login_Page = new login_Page();
            login_Page.ShowDialog();
            this.Close();
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new Deposit(SSN_FromLogin));
        }

        private void withdrawal_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new Withdrawal(SSN_FromLogin));
        }
    }
}
