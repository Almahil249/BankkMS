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
    public partial class Edit_customer_detail_2 : Form
    {
        int  age;
        string city, street, phonenum, ssn;
        

        public Edit_customer_detail_2()
        {
            InitializeComponent();
        }
        
       public Edit_customer_detail_2(string ssn)
        {
            InitializeComponent();  
            this.ssn = ssn;

        } 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            phonenum = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            street = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            city = textBox4.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            age= Convert.ToInt32(textBox2.Text);
        }

      
        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection conn =  new SqlConnection(connString) ;
            conn.Open();
            SqlCommand command = new SqlCommand(@" UPDATE Customers SET Customer_Phone =" + phonenum + ", Street=" + street + "City=" + city + "Customer_Age =" + age + " where Customer_SSN=" + ssn);
            command.ExecuteNonQuery();
        }
        
    }
}
