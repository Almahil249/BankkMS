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
    public partial class login_Page : Form
    {
        public login_Page()
        {
            InitializeComponent();
        }
        int SELECTION = 0;
        private void Customer_CheckedChanged(object sender, EventArgs e)
        {
            SELECTION = 1;
        }

        private void Employee_CheckedChanged(object sender, EventArgs e)
        {
            SELECTION = 2;
        }
        private void Admin_CheckedChanged(object sender, EventArgs e)
        {
            SELECTION = 3;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string SSN_fromLogin;
            
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
            {
                if (SELECTION == 1)
                {
                    try
                    {
                        if (Username_Read.Text != "" && Password_Read.Text != "")
                        {
                            string query = "Select count(*) from Customers where UserName = '" + Username_Read.Text + "' AND  Password = '" + Password_Read.Text + "'";
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            int is_Valid = (int)command.ExecuteScalar();
                            string query1 = "Select Customer_SSN from Customers where UserName = '" + Username_Read.Text + "'";
                            SqlCommand Command1 = new SqlCommand(query1, connection);
                            SSN_fromLogin = (string)Command1.ExecuteScalar();
                            connection.Close();

                            if (is_Valid != 1)
                            {
                                MessageBox.Show("Error username Or password", "Error!");
                            }
                            else
                            {
                                this.Hide();
                                MessageBox.Show("Welcome!");
                                CustomerPanelForm customerPanelForm = new CustomerPanelForm(SSN_fromLogin);
                                customerPanelForm.ShowDialog();
                                this.Hide();
                                this.Close();


                            }
                       
                        }
                        else
                        {
                            MessageBox.Show("Enter Username and Password");
                        }


                    }
                    catch (Exception EXP)
                    {
                        MessageBox.Show(EXP.Message);
                    }
                }

                else if (SELECTION == 2)
                {
                    try
                    {
                        if (Username_Read.Text != "" && Password_Read.Text != "")
                        {
                            string query = "Select count(*) from Employees where Username = '" + Username_Read.Text + "' AND " +
                                " Password = '" + Password_Read.Text + "'";
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            int is_Valid = (int)command.ExecuteScalar();
                            connection.Close();

                            if (is_Valid != 1)
                            {
                                MessageBox.Show("Error username Or password", "Error!");
                            }
                            else
                            {
                                connection.Open();
                                string query1 = "Select Br_ID from Employees where Username = '" + Username_Read.Text + "'";
                                SqlCommand Command1 = new SqlCommand(query1, connection);
                                int BR_IDfromLogin = (int)Command1.ExecuteScalar();
                                connection.Close();

                                MessageBox.Show("Welcome!");
                                this.Hide();
                                Employee_panel employee_Panel = new Employee_panel(BR_IDfromLogin);
                                employee_Panel.ShowDialog();
                                this.Close();

                                this.Hide();
                            }
                 
                        }
                        else
                        {
                            MessageBox.Show("Enter Username and Password");
                        }


                    }
                    catch (Exception EXP)
                    {
                        MessageBox.Show(EXP.Message);
                    }
                }

                else if (SELECTION == 3)
                {
                    try
                    {
                        if (Username_Read.Text != "" && Password_Read.Text != "")
                        {
                            string query = "Select count(*) from ADMINS where Username = '" + Username_Read.Text + "' AND Password = '" + Password_Read.Text + "'";
                            DBHelper.OpenConn();

                            int is_Valid = DBHelper.CheckExists(query);
                            DBHelper.CloseConn();
                            if (is_Valid != 1)
                            {
                                MessageBox.Show("Error username Or password", "Error!");
                            }
                            else
                            {
                                this.Hide();
                                MessageBox.Show("Welcome!");
                                this.Hide();
                                AdminPanelForm adminPanelForm = new AdminPanelForm();
                                adminPanelForm.ShowDialog();
                                this.Close();




                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Enter Username and Password");
                        }


                    }
                    catch (Exception EXP)
                    {
                        MessageBox.Show(EXP.Message);
                    }
                }

                else
                {
                    MessageBox.Show("Error Select Account Type", "Error!");
                }
                
            }
        }

        private void newAccount_LNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup_menu signup_Menu = new Signup_menu();
            this.Hide();
            signup_Menu.ShowDialog();
            this.Close();

        }


    }
}
