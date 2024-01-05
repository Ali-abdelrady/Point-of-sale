using Grocery_Shop.Classes;
using Grocery_Shop.Reports;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Daily_Sales : Form
    {
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        SoldItem_Details item=new SoldItem_Details();
        public Daily_Sales()
        {
            InitializeComponent();
        }
        private void Daily_Sales_Load(object sender, EventArgs e)
        {
            SoldItems_StartDate.Value = DateTime.Today;
            SoldItems_EndDate.Value = DateTime.Today;
            Load_DailySales_Table();
            Show_TotalSales();
        }
        private void Preview_SoldItems_Click(object sender, EventArgs e)
        {
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            SoldItems_Reports Form = new SoldItems_Reports(start_date, end_date);
            Form.ShowDialog();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DailySales_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DailySales_Table.Columns[e.ColumnIndex].DataPropertyName == "Cancel_Order")
            {
                if (DailySales_Table.Rows.Count > 0)
                {
                    Set_Product_Details(e);
                    Cancel_Order form = new Cancel_Order(item);
                    form.ShowDialog();
                }
            }
        }
        void Show_TotalSales()
        {
            decimal total_sales = 0;
            foreach (DataGridViewRow row in DailySales_Table.Rows)
            {
                total_sales += decimal.Parse(row.Cells[7].Value.ToString());
            }
            TotalSales_Lbl.Text =total_sales.ToString();
        }
        void Load_DailySales_Table()
        {
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT\r\n t.Transaction_Id AS REF,\r\n p.Product_Id AS PCODE ,\r\np.Name AS DESCRIPTION , \r\np.Price AS PRICE,\r\nSUM(items.Discount) AS DISCOUNT,\r\nSUM(items.Quantity) AS QTY,\r\nSUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((\r\nProducts AS p \r\nINNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id)\r\nINNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "'\r\nGROUP BY p.Product_Id,p.Name,p.Price,t.Transaction_Id\r\nORDER BY p.Name DESC  ;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DailySales_Table.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error To Load The Table");
            }
            finally
            {
                con.Close();
            }
        }
        void Set_Product_Details(DataGridViewCellEventArgs e)
        {
            item.Transaction_Id = int.Parse(DailySales_Table.Rows[e.RowIndex].Cells["REF"].Value.ToString());
            item.Product_Id = int.Parse(DailySales_Table.Rows[e.RowIndex].Cells["PCODE"].Value.ToString()) ;
            item.Product_Name = DailySales_Table.Rows[e.RowIndex].Cells["DESCRIPTION"].Value.ToString();
            item.Price = float.Parse(DailySales_Table.Rows[e.RowIndex].Cells["PRICE"].Value.ToString()) ;
            item.Discount = float.Parse(DailySales_Table.Rows[e.RowIndex].Cells["DISCOUNT"].Value.ToString()) ;
            item.Quantity = int.Parse(DailySales_Table.Rows[e.RowIndex].Cells["QTY"].Value.ToString()) ;
            item.Total= Decimal.Parse(DailySales_Table.Rows[e.RowIndex].Cells["TOTAL_SALES"].Value.ToString()) ;
        }

        private void Load_Data_Click(object sender, EventArgs e)
        {
            Load_DailySales_Table();
            Show_TotalSales();
        }
    }
}
