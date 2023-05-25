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
    public partial class Employee_panel : Form
    {
        int BrID_fromLogin;
        public Employee_panel(int BrIDFromLogin)
        {
            InitializeComponent();
            BrID_fromLogin = BrIDFromLogin;
        }
        public Employee_panel()
        {
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

        private void labelTitle_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();


        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
            panelContent.Controls.Clear();

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_Page login_Page = new login_Page();
            login_Page.ShowDialog();
            this.Close();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new Customer_Signup());
          

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new branch_report(BrID_fromLogin));

        }

        private void TransactiosRprt_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new Show_Transaction(BrID_fromLogin));
        }

        private void CreatLoan_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new creat_loan(BrID_fromLogin));
        }

        private void ShowLoansReq_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new Delete_Customer());
        }
    }
}
