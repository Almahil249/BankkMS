using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankkMS
{
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=A-ALMAHIL-LAP\\GMSSQLSERVER;Initial Catalog=BankMS;Integrated Security=True") ;


        private void Sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                if(Name_Read.Text !="" && SSN_Read.Text!="" && Phone_Read.Text!=""
                    && Street_Read.Text!="" && City_Read.Text != "" && Read_Age.Text != ""
                    && User_name_Read.Text != "" && Password_Read.Text != "")
                {
                    int R = check(SSN_Read.Text, User_name_Read.Text);
                    if (R == 0)
                    {

                        connection.Open();
                        SqlCommand command = new SqlCommand("Insert into Customers calues(@Customer_Name,@Customer_SSN,@Customer_Phone,@Street,@City,@Customer_Age,@UserName,@Password", connection);
                        command.Parameters.AddWithValue("@Customer_Name", Name_Read.Text);
                        command.Parameters.AddWithValue("@Customer_SSN", Convert.ToInt16(SSN_Read.Text));
                        command.Parameters.AddWithValue("@Customer_Phone", Phone_Read.Text);
                        command.Parameters.AddWithValue("@Street", Street_Read.Text);
                        command.Parameters.AddWithValue("@City", City_Read.Text);
                        command.Parameters.AddWithValue("@Customer_Age", Convert.ToInt16(Read_Age.Text));
                        command.Parameters.AddWithValue("@UserName", User_name_Read.Text);
                        command.Parameters.AddWithValue("@Password", Password_Read.Text);
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Register Succesfully");
                        Name_Read.Text = "";
                        SSN_Read.Text = "";
                        Phone_Read.Text = "";
                        Street_Read.Text = "";
                        City_Read.Text = "";
                        Read_Age.Text = "";
                        User_name_Read.Text = "";
                        Password_Read.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Your are already Registered Or username is used before!");
                    }

                }
                else
                {
                    MessageBox.Show("Fill in all The Blancks! ");
                }

            }

            catch(Exception EXP)
            {
                MessageBox.Show(EXP.Message);
            }
        }

        int check(string SSN, string UserN)
        {
            connection.Open();
            string query = "Select count(*) from Customers where Customer_SSN = '" + SSN+"'";
            string query2 = "Select count(*) from Customers where UserName = '" + UserN + "'";
            SqlCommand SSNcommand = new SqlCommand(query, connection);
            SqlCommand UserNcommand = new SqlCommand(query2, connection);
            int S = (int)SSNcommand.ExecuteNonQuery();
            int N = (int)UserNcommand.ExecuteNonQuery();
            int R = S + N;
            connection.Close();
            return R;

        }

        private void Signin_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void User_name_Read_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
