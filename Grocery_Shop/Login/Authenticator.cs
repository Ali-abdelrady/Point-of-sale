using Grocery_Shop.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grocery_Shop.Login
{
    // Calss responsible for handling user athentication 
    public class Authenticator
    {
        private readonly SqlConnection con;
        public Authenticator() 
        {
            con = DatabaseManger.CreateConnection();
        }
        public bool AuthenticateUser(string Username , string Password )
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM UserAccounts WHERE Username=@Username AND Password=@Password ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                User.Role = dt.Rows[0]["Role"].ToString().TrimEnd();
                User.Emp_Id = int.Parse(dt.Rows[0]["Emp_Id"].ToString());
                if (dt.Rows.Count > 0) // if the user exsit
                {
                    return true; 
                }
                return false;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
