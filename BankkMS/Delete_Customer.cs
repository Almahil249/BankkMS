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

namespace BankkMS
{
    public partial class Delete_Customer : Form
    {
        public Delete_Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBHelper.OpenConn();
                string query = "delete  from Customers where Customer_SSN= '" + textBox1.Text+ "'" ;
                DBHelper.deleteData(query);

            }
            catch (Exception EXP)
            {
                MessageBox.Show(EXP.Message);

            }
        }

      



    }
}
