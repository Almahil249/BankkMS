using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace BankkMS
{
    internal class DBHelper
    {
        static SqlConnection conn;

        public static void OpenConn()
        {
            string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
            conn = new SqlConnection(connString);
            conn.Open();
        }

        public static void CloseConn()
        {
            conn.Close();
        }

        public static DataTable readData(string query)
        {
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            table.Load(reader);
            return table;
        }

        public static void insertData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data has been successfully inserted");
            }
        }

        public static void deleteData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.AddWithValue("@id", id);
            //cmd.Parameters.AddWithValue("@BankName", bankName);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Data has been successfully deleted");
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        public static bool CheckExists(string query)
        {
            
            SqlCommand cmd = new SqlCommand(query, conn);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
