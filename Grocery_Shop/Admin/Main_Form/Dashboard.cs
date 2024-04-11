using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Grocery_Shop.Classes;

namespace Grocery_Shop
{
    public partial class Dashboard : UserControl
    {
        //Database Connection
        private SqlConnection con;
        public Dashboard()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
            Load_Daily_Sales();
            Load_Critical_Items();
            Load_Available_Stock();
            Load_Vendors();
            Load_Dashboard_Chart();
        }
        void Load_Daily_Sales()
        {
            int cnt =0;
            try
            {
                string query = "SELECT\r\nSUM(i.Item_Total) AS DAILY_SALES \r\nFROM \r\nTransaction_Item i \r\nINNER JOIN Transactions AS t ON t.Transaction_Id = i.Transaction_Id \r\nWHERE\r\nYEAR(t.Transaction_Date) = YEAR(GETDATE())\r\nAND \r\nMONTH(t.Transaction_Date) = MONTH(GETDATE()) ;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["DAILY_SALES"].GetType().ToString() == "System.DBNull")break;
                    cnt = int.Parse(dr["DAILY_SALES"].ToString());
                }
                Sales_Lbl.Text = cnt.ToString();
            }
            catch
            {
                MessageBox.Show("Error in loading daily sales ");
            }
            finally
            {
                con.Close();    
            }
        }
        void Load_Critical_Items()
        {
            int cnt = 0;
            try
            {
                string query = "SELECT \r\nCOUNT(Product_Id) AS cnt\r\nFROM \r\nProducts\r\nWHERE \r\nCur_Amount < 3";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cnt = int.Parse(dr["cnt"].ToString());
                }
                CriticalItems_Lbl.Text = cnt.ToString();
            }
            catch
            {
                MessageBox.Show("Error in loading daily sales ");
            }
            finally
            {
                con.Close();
            }
        }
        void Load_Available_Stock()
        {
            try
            {
                int cnt = 0;
                string query = "SELECT \r\nSUM(Cur_Amount) AS STOCK_ON_HAND\r\nFROM \r\nProducts;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cnt = int.Parse(dr["STOCK_ON_HAND"].ToString());
                }
                Stock_Lbl.Text = cnt.ToString();
            }
            catch
            {
                MessageBox.Show("Error in loading daily sales ");
            }
            finally
            {
                con.Close();
            }
        }
        void Load_Vendors()
        {
            int cnt = 0;
            try
            {
                string query = "SELECT COUNT(Vendor_Id) AS Count\r\nFROM\r\nVendors;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cnt = int.Parse(dr["Count"].ToString());
                }
                Vendor_lbl.Text = cnt.ToString();
            }
            catch
            {
                MessageBox.Show("Error in Number of Vendors ");
            }
            finally
            {
                con.Close();
            }
        }

        void Fill_Sales_Chart(DataTable dt)
        {
            Profits_Chart.DataSource = dt;
            Profits_Chart.Series["Profit"].XValueMember = "Year";
            Profits_Chart.Series["Profit"].YValueMembers = "Profit";
            Profits_Chart.Series["Profit"].IsValueShownAsLabel = true;
            Profits_Chart.Series["Profit"].LabelFormat = "C";
            Profits_Chart.DataBind();

        }
        public void Load_Dashboard_Chart()
        {
            try
            {
                // Create a DataTable to hold the data
                DataTable dt = new DataTable();
                string query = "SELECT\r\nYEAR(t.Transaction_Date) AS Year,\r\nSUM(items.Item_Total) AS Profit\r\nFROM Transactions t\r\nINNER JOIN Transaction_Item items ON t.Transaction_Id = items.Transaction_Id\r\nGROUP BY YEAR(t.Transaction_Date);";
                con.Open();
                SqlCommand cmd =new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Fill_Sales_Chart(dt);
            }
            catch
            {
                MessageBox.Show("Error in load dashboard chart");
            }
            finally
            {
                con.Close();
            }   

        }
    }
}
