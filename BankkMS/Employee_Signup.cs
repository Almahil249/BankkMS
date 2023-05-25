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
    public partial class Employee_Signup : Form
    {
        public Employee_Signup()
        {
            InitializeComponent();
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Read.Text != "" && SSN_Read.Text != "" && BankID_Read.Text != ""
                    && BranchID_Read.Text != "" && User_read.Text != "" && Password_Read.Text != "")
                {
                    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                    {
                        string querySSN_Usser = "Select count(*) from Employees where Emp_SSN = '" + SSN_Read.Text + "' OR Username = '" + User_read.Text + "'";
                        string queryBrChech = "Select count(*) from FROM Branchs WHERE Br_ID = '" + BranchID_Read.Text + "' AND Bnk_ID = '" + BankID_Read.Text + "'";
                        DBHelper.OpenConn();
                        int Is_ValidSSN = DBHelper.CheckExists(querySSN_Usser);
                        DBHelper.CloseConn();
                        DBHelper.OpenConn();
                        int Is_ValidBr = DBHelper.CheckExists(queryBrChech);
                        DBHelper.CloseConn();
                        if (Is_ValidSSN == 0)
                        {
                            if (Is_ValidBr == 1)
                            {

                                connection.Open();
                                SqlCommand command = new SqlCommand("Insert into Employees values ('" + SSN_Read.Text +
                                    "','" + Name_Read.Text + "','" + User_read.Text + "','" + Password_Read.Text + "','" +
                                    BranchID_Read.Text + "','" + BankID_Read.Text + "')", connection);
                                command.ExecuteNonQuery();
                                MessageBox.Show("Register Succesfully");


                                Name_Read.Text = "";
                                SSN_Read.Text = "";
                                User_read.Text = "";
                                Password_Read.Text = "";
                                BranchID_Read.Text = "";
                                BankID_Read.Text = "";
                                login_Page login_Page = new login_Page();
                                login_Page.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Branch Not Found!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You are already registered or username is used before!");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Fill in all the fields!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Signin_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            login_Page login_Page = new login_Page();
            login_Page.ShowDialog();
        }
    }
}
