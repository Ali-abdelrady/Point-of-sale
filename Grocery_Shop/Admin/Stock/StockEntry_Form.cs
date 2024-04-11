using Grocery_Shop.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class StockEntry_Form : UserControl
    {
        //Database Connection
        private SqlConnection con;
        List<int>Vendor_Id = new List<int>();
        TextboxStyles textboxStyle = new TextboxStyles();
        public StockEntry_Form()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void StockEntry_Form_Load(object sender, EventArgs e)
        {
            Set_EmpName();
            LoadProductsTable();
            // Make The first index in combobox in appear
            Cmd_Combobox.SelectedIndex = 0;
        }
        public void Fill_ComboBox()
        {
            //First you have to leatr combobox
            Vendor_Cmbox.Items.Clear();
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
                if(Vendor_Cmbox.Items.Count == 0) Vendor_Cmbox.Items.Add("None");
                Vendor_Cmbox.SelectedIndex = 0;
            }
            catch 
            {
                //MessageBox.Show("Error In Filling Vendors Combobox");
            }
            finally
            {
                con.Close();
            }
        }
        private void Set_EmpName()
        {
            try
            {
                string query = "SELECT RTRIM(First_Name)+' '+RTRIM(Middle_Name)+' '+RTRIM(Last_Name) AS NAME  FROM Employees WHERE Emp_Id=@Emp_Id";
                con.Open();
                SqlCommand cmd = new SqlCommand( query, con);
                cmd.Parameters.AddWithValue("@Emp_Id",User.Emp_Id);
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
            //Check If There is Vendors In Combobox
            if (Vendor_Cmbox.Items.Count == 0)
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
        private void Save_Btn_Click(object sender, EventArgs e)
        {
            //Check If There Is Items In The Table
            if(Vendor_Cmbox.Text != "None" && StockIn_Table.Rows.Count > 0 && StockBy_txtbox.Text.Length != 0)
            {
                int vendor_id = Vendor_Id[Vendor_Cmbox.SelectedIndex];
                string date = Stock_Date.Value.Date.ToString();

                    //Insert Values In Stock Entry Table 
                    InsertInto_StockEntryTable(vendor_id,date);

                    //Iterate Threw Table And Add Items
                    foreach (DataGridViewRow row in StockIn_Table.Rows)
                    {
                        int product_id = int.Parse(row.Cells[0].Value.ToString());
                        int qty= int.Parse(row.Cells[2].Value.ToString());

                        //Insert Items in Stock Entry Items Table 

                        InsertInto_StockItemsTable(product_id,qty);

                        // Update Product Quantity In Products Table 

                        Update_ProductsTable(product_id, qty);

                    }
                    MessageBox.Show("Succssefully adding");
                    //Clear Table
                    StockIn_Table.Rows.Clear();
                    LoadProductsTable();
            }
            else
            {
                MessageBox.Show("Check Your Vendors And Admins List To Make This Operation ");
            }
        }
        private void InsertInto_StockEntryTable(int vendor_id,string date )
        {
            string query = "INSERT INTO \r\nStock_Entries\r\n(Vendor_Id,Emp_Id,Entry_Date)\r\nVALUES \r\n(@Vendor_Id,@Emp_Id,@Entry_Date);";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Vendor_Id", vendor_id);
                cmd.Parameters.AddWithValue("@Emp_Id", User.Emp_Id);
                cmd.Parameters.AddWithValue("@Entry_Date", date);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error on adding to stock entry table");
            }
            finally
            {
                con.Close();
            }
        }
        private void InsertInto_StockItemsTable(int product_id , int qty)
        {
            con.Open();
            string query2 = "INSERT INTO \r\nStockEntries_Items\r\n(Stock_Id,Product_Id,Quantity)\r\nVALUES\r\n(IDENT_CURRENT('Stock_Entries'),@Product_Id,@Quantity);";
            try
            {
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@Product_Id", product_id);
                cmd2.Parameters.AddWithValue("@Quantity", qty);
                cmd2.ExecuteNonQuery();

            }
            catch
            {
                MessageBox.Show("Error on adding to stock items table");
            }
            finally
            {
                con.Close();
            }
        }
        private void Update_ProductsTable(int product_id, int qty)
        {
            con.Open();
            string query3 = "UPDATE \r\nProducts\r\nSET\r\nCur_Amount = Cur_Amount + @qty\r\nWHERE \r\nProduct_Id=@product_id;";
            try
            {
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@qty", qty);
                cmd3.Parameters.AddWithValue("@product_id", product_id);
                cmd3.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error on  updating table");
            }
            finally
            {
                con.Close();
            }
        }
        //--------------------- Stock In History Form ------------------
        private void LoadRecord_Btn_Click(object sender, EventArgs e)
        {   DataTable dt= new DataTable();
            string start_date = Start_Date.Value.Date.ToString();
            string end_date = End_Date.Value.Date.ToString();
            string query = "SELECT\r\nstk_ent.Stock_Id ,\r\nstk_itm.Product_Id ,\r\np.Name AS Product_Name ,\r\nstk_itm.Quantity ,\r\nstk_ent.Entry_Date , \r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS StockBy , \r\nv.Name AS Vendor_Name \r\nFROM (((( Stock_Entries AS stk_ent \r\nINNER JOIN Vendors AS v ON stk_ent.Vendor_Id = v.Vendor_Id)\r\nINNER JOIN Employees AS e ON  stk_ent.Emp_Id = e.Emp_Id)\r\nINNER JOIN StockEntries_Items AS stk_itm ON stk_ent.Stock_Id = stk_itm.Stock_Id)\r\nINNER JOIN Products AS p ON p.Product_Id = stk_itm.Product_Id)\r\nWHERE stk_ent.Entry_Date BETWEEN '"+start_date+"' AND '"+end_date+"';\r\n";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                StockHistory_Table.DataSource = dt;
               // MessageBox.Show("Successfully Loading History ");
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

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(Search_Txtbox, " Search here");
        }
        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadProductsTable();
        }
        private void LoadProductsTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string product_name = Search_Txtbox.Text;
                string query1 = "SELECT Product_Id,Name,Price,Barcode,Category_Name,Brand_Name,Cur_Amount FROM Products p,Categories c,Brands b WHERE p.Category_Id=c.Category_Id and p.Brand_Id=b.Brand_Id and Name LIKE '%" + product_name + "%'";
                string query2 = "SELECT Product_Id,Name,Price,Barcode,Category_Name,Brand_Name,Cur_Amount FROM Products p,Categories c,Brands b WHERE p.Category_Id=c.Category_Id and p.Brand_Id=b.Brand_Id";
                string res_query = (product_name == " Search here") ? query2 : query1;

                con.Open();
                SqlCommand cmd = new SqlCommand(res_query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Products_Table.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error in querey");
            }
            finally
            {
                con.Close();
            }
        }

        private void Products_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check for the cell Coulmn Header
            if (Products_Table.Columns[e.ColumnIndex].DataPropertyName == "ADD")
            {
                //Check If There Is Rows To Delete
                if (Products_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Products_Table.Rows[e.RowIndex];
                    string product_id = row.Cells[1].Value.ToString();
                    string desc = row.Cells[2].Value.ToString();
                    string Cur_Amount = row.Cells[7].Value.ToString();  
                    // Set Textboxes
                    Pcode_Textbox.Text = product_id; 
                    Desc_Textbox.Text = desc;
                    Cur_Amount_Textbox.Text = Cur_Amount;
                }
            }
        }

        private void SaveAdjustment_Btn_Click(object sender, EventArgs e)
        {
            string newQty = Qty_Textbox.Text.ToString();
            string Curqty = Cur_Amount_Textbox.Text.ToString();
            int cmd = Cmd_Combobox.SelectedIndex;
            //Check If Any Textbox Is Empty
            if (Is_Vaild(newQty,Curqty,cmd))
            {
                Update_Inventory(int.Parse(newQty));
                LoadProductsTable();
            }
        }
        bool Is_Vaild(string newQty , string Curqty ,int cmd)
        {
            if (newQty == "" || Pcode_Textbox.Text.Length == 0)
            {
                MessageBox.Show("Fill The Empty textboxes");
                return false;
            }
            else if (newQty.Any(char.IsLetter))
            {
                MessageBox.Show("Enter A numeric Number");
                return false;
            }
            else if(cmd == 0 && int.Parse(newQty) > int.Parse(Curqty))
            {

                MessageBox.Show("Can't Remove This Quantity");
                return false;
            }
            return true;
        }
        void Update_Inventory(int newQty)
        {
            // index : 0 -> Remove // index : 1 -> Add 
            int command = Cmd_Combobox.SelectedIndex;
            int pcode = int.Parse(Pcode_Textbox.Text.ToString().TrimEnd());

            try
            {
                string query = (command == 0) ? "UPDATE Products SET Cur_Amount -= @newQty WHERE Product_Id = @pcode;" : "UPDATE Products SET Cur_Amount += @newQty WHERE Product_Id = @pcode;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@newQty", newQty);
                cmd.Parameters.AddWithValue("@pcode", pcode);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated");
            }
            catch
            {
                MessageBox.Show("Error In Updating Inventory");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
