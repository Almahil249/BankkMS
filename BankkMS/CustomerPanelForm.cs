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
        public CustomerPanelForm()
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
            LoadChildFormIntoPanel(new OpenAccountForm());
        }
    }
}
