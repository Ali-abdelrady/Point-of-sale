using Grocery_Shop.Classes;
using Grocery_Shop.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Daily_Sales : Form
    {
        //Database Connection
        private SqlConnection con;
        SoldItem_Details item=new SoldItem_Details();
        List<int>emp_ids = new List<int>();
        public Daily_Sales()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }
        private void Daily_Sales_Load(object sender, EventArgs e)
        {
            SoldItems_StartDate.Value = DateTime.Today;
            SoldItems_EndDate.Value = DateTime.Today;
            Fill_EmpCombobox();
            Load_DailySales_Table();
            Show_TotalSales();
        }
        private void Preview_SoldItems_Click(object sender, EventArgs e)
        {
            int emp_id = emp_ids[Emp_Combobox.SelectedIndex];
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            SoldItems_Reports Form = new SoldItems_Reports(start_date, end_date,emp_id);
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
                    Cancel_Order form = new Cancel_Order(item,this);
                    form.ShowDialog();
                }
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
            item.Total= Decimal.Parse(DailySales_Table.Rows[e.RowIndex].Cells["TOTAL_SALES"].Value.ToString());
        }

        private void Load_Data_Click(object sender, EventArgs e)
        {
            Load_DailySales_Table();
            Show_TotalSales();
        }
        public void Load_DailySales_Table()
        {
            int emp_id = emp_ids[Emp_Combobox.SelectedIndex];
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                
                string query = (emp_id != -1) 
                    ? "SELECT\r\n  t.Transaction_Id AS REF,\r\n  p.Product_Id AS PCODE,\r\n  p.Name AS DESCRIPTION,\r\n  p.Price AS PRICE,\r\n  SUM(items.Discount) AS DISCOUNT,\r\n  SUM(items.Quantity) AS QTY,\r\n  SUM(items.Item_Total) AS TOTAL_SALES\r\nFROM\r\n  (\r\n    (Products AS p\r\n    INNER JOIN Transaction_Item AS items ON p.Product_Id = items.Product_Id)\r\n    INNER JOIN Transactions AS t ON t.Transaction_Id = items.Transaction_Id\r\n\tINNER JOIN Employees AS e ON e.Emp_Id = t.Emp_Id\r\n  )\r\nWHERE\r\n  t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "' AND e.Emp_Id = '"+emp_id+"' \r\nGROUP BY\r\n  p.Product_Id, p.Name, p.Price, t.Transaction_Id\r\nORDER BY\r\n  p.Name DESC;\r\n"
                    : "SELECT\r\n  t.Transaction_Id AS REF,\r\n  p.Product_Id AS PCODE,\r\n  p.Name AS DESCRIPTION,\r\n  p.Price AS PRICE,\r\n  SUM(items.Discount) AS DISCOUNT,\r\n  SUM(items.Quantity) AS QTY,\r\n  SUM(items.Item_Total) AS TOTAL_SALES\r\nFROM\r\n  (\r\n    (Products AS p\r\n    INNER JOIN Transaction_Item AS items ON p.Product_Id = items.Product_Id)\r\n    INNER JOIN Transactions AS t ON t.Transaction_Id = items.Transaction_Id\r\n\tINNER JOIN Employees AS e ON e.Emp_Id = t.Emp_Id\r\n  )\r\nWHERE\r\n  t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "' \r\nGROUP BY\r\n  p.Product_Id, p.Name, p.Price, t.Transaction_Id\r\nORDER BY\r\n  p.Name DESC;\r\n";
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
        void Fill_EmpCombobox()
        {
            string query;
            if (User.Role == "Admin")
            {
                query = "SELECT RTRIM(First_Name)+' '+RTRIM(Last_Name) AS NAME , Emp_Id  FROM Employees WHERE Emp_Id != @Emp_Id";
            }
            else
            {

                query = "SELECT RTRIM(First_Name)+' '+RTRIM(Last_Name) AS NAME , Emp_Id FROM Employees WHERE Emp_Id=@Emp_Id";
                Emp_Combobox.Enabled = false;
            }
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Emp_Id", User.Emp_Id);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp_ids.Add(int.Parse(dr["Emp_Id"].ToString().TrimEnd()));
                    Emp_Combobox.Items.Add(dr["NAME"].ToString().TrimEnd());
                }
                emp_ids.Add(-1);
                Emp_Combobox.Items.Add("ALL");
                Emp_Combobox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Error On Filling Employees Combobox");
            }
            finally
            {
                con.Close();
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
    }
}
