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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

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

        private void buttonShowData_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new ShowDataForm());
        }

        private void buttonAddBank_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new AddBankForm());
        }

        private void buttonManageBank_Click(object sender, EventArgs e)
        {
            LoadChildFormIntoPanel(new ManageBankForm());
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

        private void labelTitle_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

        }
    }
}

