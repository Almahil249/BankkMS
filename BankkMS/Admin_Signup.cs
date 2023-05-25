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

    public partial class Admin_Signup : Form
    {
        public Admin_Signup()
        {
            InitializeComponent();
        }
        string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        private void Sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name_Read.Text != "" && SSN_Read.Text != ""
                    && User_read.Text != "" && Password_Read.Text != "")
                {
                    string querySSN_Usser = "Select count(*) from ADMINS where ADMIN_SSN = '" + SSN_Read.Text + "' OR Username = '" + User_read.Text + "'";
                    DBHelper.OpenConn();
                    int Is_ValidSSN = DBHelper.CheckExists(querySSN_Usser);
                    DBHelper.CloseConn();
                    if (Is_ValidSSN == 0)
                    {
                        using (SqlConnection connection = new SqlConnection(connString))
                        {
                            connection.Open();

                            SqlCommand command = new SqlCommand("Insert into ADMINS values('" + SSN_Read.Text + "','" + Name_Read.Text + "','" + User_read.Text + "','" + Password_Read.Text + "')", connection);

                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Register Succesfully");
                        }

                        Name_Read.Text = "";
                        SSN_Read.Text = "";
                        User_read.Text = "";
                        Password_Read.Text = "";
                        login_Page login_Page = new login_Page();
                        login_Page.Show();
                        this.Close();


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
            this.Close();
        }
    }
}
