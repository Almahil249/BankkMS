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


            // Set the properties of the child form
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add the child form to the panel's controls
            panelContent.Controls.Add(childForm);

            // Show the child form
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
    }
}
