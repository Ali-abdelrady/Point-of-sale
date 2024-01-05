using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class StockEntry_Form : UserControl
    {
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        List<int>Vendor_Id = new List<int>();
        int emp_id = 0 ;

        public StockEntry_Form()
        {
            InitializeComponent();

        }

        private void StockEntry_Form_Load(object sender, EventArgs e)
        {
            Fill_ComboBox();
            Set_EmpName();
        }
        void Fill_ComboBox()
        {
            try
            {
                string query = "SELECT Vendor_Id,Name FROM Vendors";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Vendor_Id.Add(int.Parse(dr["Vendor_Id"].ToString()));
                    Vendor_Cmbox.Items.Add(dr["Name"].ToString().TrimEnd());
                }
                Vendor_Cmbox.SelectedIndex = 0;
            }
            catch 
            {
                MessageBox.Show("Error In Filling Combobox");
            }
            finally
            {
                con.Close();
            }
        }
        void Set_EmpName()
        {
            try
            {
                string query = "SELECT RTRIM(First_Name)+' '+RTRIM(Middle_Name)+' '+RTRIM(Last_Name) AS NAME  FROM Employees WHERE User_Id=@User_Id";
                con.Open();
                SqlCommand cmd = new SqlCommand( query, con);
                cmd.Parameters.AddWithValue("@User_Id",Global.User_Id);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    StockBy_txtbox.Text=dr.GetString(0);
                }
            }
            catch
            {
                MessageBox.Show("Error in filling employee name");
            }
            finally
            {
                con.Close();
            }
        }
        private void Browse_Btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Vendor_Cmbox.Items.Count == 0 || StockBy_txtbox.Text == "")
            {
                MessageBox.Show("Fill Textboxes first");
            }
            else
            {
                Product_List form = new Product_List(this);
                form.ShowDialog();
            }
        }
        public void Add_Rows_On_Table(int product_id,string name)
        {
            StockIn_Table.Rows.Add(product_id, name, 0, Stock_Date.Value, StockBy_txtbox.Text, Vendor_Cmbox.Text);
            Console.WriteLine(Stock_Date.Value);
        } 
        private void Stock_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if(Vendor_Cmbox.Text.Length > 0 && StockIn_Table.Rows.Count > 0)
            {
                int vendor_id = Vendor_Id[Vendor_Cmbox.SelectedIndex];
                string date = Stock_Date.Value.Date.ToString();
                try
                {
                    //Insert Values In Stock Entry Table 
                    string query = "INSERT INTO \r\nStock_Entries\r\n(Vendor_Id,User_Id,Entry_Date)\r\nVALUES \r\n(@Vendor_Id,@User_Id,@Entry_Date);";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Vendor_Id",vendor_id);
                    cmd.Parameters.AddWithValue("@User_Id",Global.User_Id);
                    cmd.Parameters.AddWithValue("@Entry_Date",date);
                    cmd.ExecuteNonQuery();
                    
                    foreach (DataGridViewRow row in StockIn_Table.Rows)
                    {
                        int product_id = int.Parse(row.Cells[0].Value.ToString());
                        int qty= int.Parse(row.Cells[2].Value.ToString());
                        //Insert Items in Stock Entry Items Table 
                        string query2 = "INSERT INTO \r\nStockEntries_Items\r\n(Stock_Id,Product_Id,Quantity)\r\nVALUES\r\n(IDENT_CURRENT('Stock_Entries'),@Product_Id,@Quantity);";
                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@Product_Id",product_id);
                        cmd2.Parameters.AddWithValue("@Quantity", qty);
                        cmd2.ExecuteNonQuery();

                        // Update Product Quantity In Products Table 
                        string query3 = "UPDATE \r\nProducts\r\nSET\r\nCur_Amount = Cur_Amount + @qty\r\nWHERE \r\nProduct_Id=@product_id;";
                        SqlCommand cmd3 = new SqlCommand(query3, con);
                        cmd3.Parameters.AddWithValue("@qty", qty);
                        cmd3.Parameters.AddWithValue("@product_id", product_id);
                        cmd3.ExecuteNonQuery();
                    }
                    MessageBox.Show("Succssefully adding");
                }
                catch
                {
                    MessageBox.Show("Error in Adding in the stock");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("There is no vendors to select");
            }
        }

        private void LoadRecord_Btn_Click(object sender, EventArgs e)
        {   DataTable dt= new DataTable();
            string start_date = Start_Date.Value.Date.ToString();
            string end_date = End_Date.Value.Date.ToString();
            string query = "SELECT\r\nstk_ent.Stock_Id ,\r\nstk_itm.Product_Id ,\r\np.Name AS Product_Name ,\r\nstk_itm.Quantity ,\r\nstk_ent.Entry_Date , \r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS StockBy , \r\nv.Name AS Vendor_Name \r\nFROM (((( Stock_Entries AS stk_ent \r\nINNER JOIN Vendors AS v ON stk_ent.Vendor_Id = v.Vendor_Id)\r\nINNER JOIN Employees AS e ON  stk_ent.User_Id = e.User_Id)\r\nINNER JOIN StockEntries_Items AS stk_itm ON stk_ent.Stock_Id = stk_itm.Stock_Id)\r\nINNER JOIN Products AS p ON p.Product_Id = stk_itm.Product_Id)\r\nWHERE stk_ent.Entry_Date BETWEEN '"+start_date+"' AND '"+end_date+"';\r\n";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                StockHistory_Table.DataSource = dt;
                MessageBox.Show("Successfully Loading History ");
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

        private void StockHistory_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockIn_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockIn_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (StockIn_Table.Rows.Count > 0)
                {
                    StockIn_Table.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
