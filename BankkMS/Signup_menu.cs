using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankkMS
{
    public partial class Signup_menu : Form
    {
        public Signup_menu()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Signup customer_Signup = new Customer_Signup();
            customer_Signup.ShowDialog();
            this.Close();

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Signup employee_Signup = new Employee_Signup();
            employee_Signup.ShowDialog();
            this.Close();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Signup admin_Signup = new Admin_Signup();
            admin_Signup.ShowDialog();
            this.Close();
        }



    }
}
