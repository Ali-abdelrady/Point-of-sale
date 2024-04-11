using Grocery_Shop.Classes;
using Grocery_Shop.Reports;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Records_Form : UserControl
    {
        //Database Connection
        private SqlConnection con;

        public Records_Form()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Load_Data_Btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string start_date = Start_Date.Value.Date.ToString();
            string end_date = End_Date.Value.Date.ToString();

            string query = "SELECT\r\nstk_ent.Stock_Id ,\r\nstk_itm.Product_Id  ,\r\np.Name AS Product_Name ,\r\nstk_itm.Quantity , \r\nstk_ent.Entry_Date , \r\ne.First_Name AS StockBy , \r\nv.Name AS Vendor_Name \r\nFROM (((( Stock_Entries AS stk_ent \r\nINNER JOIN Vendors AS v ON stk_ent.Vendor_Id = v.Vendor_Id)\r\nINNER JOIN Employees AS e ON  stk_ent.Emp_Id = e.Emp_Id)\r\nINNER JOIN StockEntries_Items AS stk_itm ON stk_ent.Stock_Id = stk_itm.Stock_Id)\r\nINNER JOIN Products AS p ON p.Product_Id = stk_itm.Product_Id)\r\nWHERE stk_ent.Entry_Date BETWEEN '" + start_date + "' AND '" + end_date + "';";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                StockHistory_Table.DataSource = dt;
                //MessageBox.Show("Successfully Loading History ");
            }
            catch
            {
                MessageBox.Show("Error In Loading Stock Entry History");
            }
            finally
            {
                con.Close();
            }
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Load_SoldItems_Click(object sender, EventArgs e)
        {
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT\r\np.Product_Id AS PCODE ,\r\np.Name AS DESCRIPTION , \r\np.Price AS PRICE,\r\nSUM(items.Discount) AS DISCOUNT,\r\nSUM(items.Quantity) AS QTY,\r\nSUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((\r\nProducts AS p \r\nINNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id)\r\nINNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "'\r\nGROUP BY p.Product_Id,p.Name,p.Price\r\nORDER BY p.Name ASC  ;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                SoldItems_Table.DataSource = dt;
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
        private void Load_TopSales_Click(object sender, EventArgs e)
        {
            string start_date = tsStartDate.Value.Date.ToString();
            string end_date = tsEndDate.Value.Date.ToString();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT\r\np.Product_Id AS PCODE ,\r\np.Name AS DESCRIPTION , \r\nSUM(items.Quantity) AS QTY,\r\nSUM(items.Item_Total) AS TOTAL_SALES\r\nFROM((\r\nProducts AS p \r\nINNER JOIN Transaction_Item AS items ON p.Product_Id=items.Product_Id)\r\nINNER JOIN Transactions AS t ON t.Transaction_Id=items.Transaction_Id)\r\nWHERE t.Transaction_Date BETWEEN '" + start_date + "' AND '" + end_date + "'\r\nGROUP BY p.Product_Id,p.Name ;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                TopSales_Table.DataSource = dt;
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
        private void Preview_Inventroy_Click(object sender, EventArgs e)
        {
            Inventory_Report Form = new Inventory_Report();
            Form.ShowDialog();
        }

        private void Preivew_Stock_Click(object sender, EventArgs e)
        {
            string start_date = Start_Date.Value.Date.ToString();
            string end_date = End_Date.Value.Date.ToString();
            StockIn_Report Form = new StockIn_Report(start_date, end_date);
            Form.ShowDialog();
        }

        private void Preview_SoldItems_Click(object sender, EventArgs e)
        {
            string start_date = SoldItems_StartDate.Value.Date.ToString();
            string end_date = SoldItems_EndDate.Value.Date.ToString();
            SoldItems_Reports Form =new SoldItems_Reports(start_date, end_date,-1);
            Form.ShowDialog();
        }

        private void Preview_TopSelling_Items_Click(object sender, EventArgs e)
        {
            string start_date = tsStartDate.Value.Date.ToString();
            string end_date = tsEndDate.Value.Date.ToString();
            TopSelling_Report Form = new TopSelling_Report(start_date, end_date);
            Form.ShowDialog();
        }


        private void CriticalItems_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Preview_CriticalItems_Click(object sender, EventArgs e)
        {
            Critical_Items_Report form =new Critical_Items_Report();
            form.ShowDialog();
        }

        private void Load_CanceledOrders_Click(object sender, EventArgs e)
        {
            string start_date = Canceled_StartDate.Value.Date.ToString();
            string end_date = Canceled_EndDate.Value.Date.ToString();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT \r\nTransaction_Id,\r\nName AS DES,\r\nPrice ,\r\nCancelled_Qty,\r\nCancelled_Date,\r\nCancelledBy,\r\nCancel_Reason,\r\nAction\r\nFROM Cancelled_Orders c INNER JOIN Products p ON p.Product_Id = c.Product_Id WHERE Cancelled_Date BETWEEN '" + start_date + "' AND '"+ end_date + "';";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                CancelledOrders_Table.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error To Load Canceled Orders ");
            }
            finally
            {
                con.Close();
            }
        }

        private void Preview_CancelledOrders_Click(object sender, EventArgs e)
        {
            string start_date = Canceled_StartDate.Value.Date.ToString();
            string end_date = Canceled_EndDate.Value.Date.ToString();
            Cancelled_Items_Report form = new Cancelled_Items_Report(start_date,end_date);
            form.ShowDialog();
        }

        void Load_Criticalitems()
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT p.Product_Id, p.Name, p.Barcode, p.Price, c.Category_Name, b.Brand_Name, p.Cur_Amount\r\nFROM ((Products AS p\r\nINNER JOIN Categories AS c ON p.Category_Id = c.Category_Id)\r\nINNER JOIN Brands AS b ON p.Brand_Id = b.Brand_Id)\r\nWHERE p.Cur_Amount =0;";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                CriticalItems_Table.DataSource = dt;
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
        void Load_InvetoryList()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT \r\np.Product_Id ,\r\np.Name ,\r\np.Barcode ,\r\np.Price ,\r\nc.Category_Name ,\r\nb.Brand_Name ,\r\np.Cur_Amount\r\nFROM ((Products AS p\r\nINNER JOIN Categories AS c ON p.Category_Id=c.Category_Id)\r\nINNER JOIN Brands AS b ON p.Brand_Id=b.Brand_Id);";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Inventory_List.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error in LoadUSer Table");
            }
            finally
            {
                con.Close();
            }
        }
        public void Records_Form_Load(object sender, EventArgs e)
        {
            Load_CanceledOrders_Click(sender, e);
            Load_Criticalitems();
            Load_InvetoryList();
            Load_SoldItems_Click(sender, e);
            Load_Data_Btn_Click(sender, e);
            Load_TopSales_Click(sender, e);
        }
    }
}
