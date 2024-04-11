using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Grocery_Shop.Classes
{
    public class DatabaseManger
    {

       /* private static string path = Path.GetFullPath(Environment.CurrentDirectory);
        private static string exeFolder = AppDomain.CurrentDomain.BaseDirectory;
        private static string databasePath = System.IO.Path.Combine(exeFolder, "PosDb.mdf");*/
        //private static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        //private static string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ databasePath + ";Integrated Security=True;Connect Timeout=30";
        private static string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\PosDb.mdf;Integrated Security=True;Connect Timeout=30";
        //private static string sql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path+ @"\Shop.mdf;Integrated Security=True;";
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(sql);
        }
        public DataTable getDataTableFromUserQuery(string query)
        {
            SqlConnection con = CreateConnection();   
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con) ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public void SeedData()
        {
            SqlConnection con = CreateConnection();
            if (!DoesDataExist(con))
            {
                SeedUsers(con);
                SeedStoreInfo(con);
            }
        }
        private void SeedUsers(SqlConnection con)
        {
            try
            {
                string query = "INSERT INTO Employees (First_Name,Middle_Name,Last_Name,Salary,Address,Phone_Number) VALUES ('admin','admin','admin',1000,'admin','01007788459');\r\nINSERT INTO UserAccounts (Emp_Id,Username,Password,Role) VALUES ((SELECT SCOPE_IDENTITY()),'admin','admin','Admin');\r\nINSERT INTO Employees (First_Name,Middle_Name,Last_Name,Salary,Address,Phone_Number) VALUES ('cashier','cashier','cashier',1000,'cashier','01007788459');\r\nINSERT INTO UserAccounts (Emp_Id,Username,Password,Role) VALUES ((SELECT SCOPE_IDENTITY()),'cashier','cashier','Cashier');";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error On Adding Default Account");
            }
            finally
            {
                con.Close();
            }
        }
        private void SeedStoreInfo(SqlConnection con)
        {
            try
            {
                string query = "INSERT INTO Store_Details (Name,Address,Phone_Number) VALUES ('store','store','12345678910');";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error On Adding Default Store Info");
            }
            finally
            {
                con.Close();
            }
        }
        private bool DoesDataExist(SqlConnection con)
        {
            int userCount = 0;
            try
            {
                string query = "SELECT COUNT(*)  AS cnt FROM UserAccounts";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userCount = int.Parse(reader["cnt"].ToString());
                }
            }
            catch
            {
                //MessageBox.Show("Error In Count UserAccounts");
            }
            finally
            {
                con.Close() ;
            }
            return userCount > 0;   

        }
    }
}
