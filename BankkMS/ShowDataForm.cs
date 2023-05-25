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
    public partial class ShowDataForm : Form
    {
        public ShowDataForm()
        {
            InitializeComponent();
        }

        private void ShowDataForm_Load(object sender, EventArgs e)
        {
            string query1 = "select * from Branchs";
            string query2 = "select * from Employees";
            string query3 = "select * from Loans";
            string query4 = "select * from Customers";
            string query5 = "select * from Banks";
            DBHelper.OpenConn();
            DataTable dtTable1 = DBHelper.readData(query1);
            DataTable dtTable2 = DBHelper.readData(query2);
            DataTable dtTable3 = DBHelper.readData(query3);
            DataTable dtTable4 = DBHelper.readData(query4);
            DataTable dtTable5 = DBHelper.readData(query5);
            DBHelper.CloseConn();
            dataGridView1.DataSource = dtTable1;
            dataGridView2.DataSource = dtTable2;
            dataGridView3.DataSource = dtTable3;
            dataGridView4.DataSource = dtTable4;
            dataGridView5.DataSource = dtTable5;
        }

      
    }
}
