using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankkMS
{
    public partial class Edit_customer_detail : Form
    {
        string ssn;
        public Edit_customer_detail()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Employee_panel c = new Employee_panel();
            c.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ssn = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Edit_customer_detail_2 s = new Edit_customer_detail_2(ssn);
            s.Show();
            this.Close();
        }
    }
}
