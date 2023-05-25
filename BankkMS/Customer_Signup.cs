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
using System.Configuration;

namespace BankkMS
{
    public partial class Customer_Signup : Form
    {
        public Customer_Signup()
        {
            InitializeComponent();
        }
        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        private void Sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Read.Text != "" && SSN_Read.Text != "" && Phone_Read.Text != ""
                    && Street_Read.Text != "" && City_Read.Text != "" && Read_Age.Text != ""
                    && User_name_Read.Text != "" && Password_Read.Text != "")
                {
                    string query1 = "Select count(*) from Customers where UserName = '" + User_name_Read.Text + "' OR  Customer_SSN = '" + SSN_Read.Text + "'";
                    DBHelper.OpenConn();
                    int Is_ValidAcc = DBHelper.CheckExists(query1);
                    DBHelper.CloseConn();
                    MessageBox.Show(Convert.ToString(Is_ValidAcc));
                    if (Is_ValidAcc != 0)
                    {
                        MessageBox.Show("Error username Or SSN is used before", "Error!");
                    }
                    else
                    {



                        if (Convert.ToInt16(Read_Age.Text) >= 18)
                        {
                            using (SqlConnection connection = new SqlConnection(connString))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand("Insert into Customers values ('" + SSN_Read.Text + "','" + Name_Read.Text + "','" + Phone_Read.Text + "','" + Read_Age.Text + "','" + Street_Read.Text + "','" + City_Read.Text + "','" + User_name_Read.Text + "','" + Password_Read.Text + "')", connection);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Registered Successfully");
                                this.Close();

                            }
                            Name_Read.Text = "";
                            SSN_Read.Text = "";
                            Phone_Read.Text = "";
                            Street_Read.Text = "";
                            City_Read.Text = "";
                            Read_Age.Text = "";
                            User_name_Read.Text = "";
                            Password_Read.Text = "";
                            this.Hide();

                            login_Page login_Page = new login_Page();
                            login_Page.ShowDialog();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Your age MUST be 18+");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Fill in all the fields!");
                }

            }

            catch (Exception EXP)
            {
                MessageBox.Show(EXP.Message);
         
            }
        


        }

        private void Signin_lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login_Page login_Page = new login_Page();
            login_Page.ShowDialog();
            this.Hide();
        }

    }



 }