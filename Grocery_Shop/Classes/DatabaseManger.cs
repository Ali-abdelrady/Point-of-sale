using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop.Classes
{
    public class DatabaseManger
    {
        private static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
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
    }
}
