using Grocery_Shop.Classes;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Cancel_Order : Form
    {
        //Database Connection
        private SqlConnection con;
        SoldItem_Details item;
        Daily_Sales daily_Sales;
        public Cancel_Order(SoldItem_Details item , Daily_Sales daily_Sales)
        {
            InitializeComponent();
            this.item = item;
            this.daily_Sales = daily_Sales;
            con = DatabaseManger.CreateConnection();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Order_Load(object sender, EventArgs e)
        {
            Load_SoldItem_Details();
            CancelBy_Textbox.Text = User.Role;
        }

        private void Load_SoldItem_Details()
        {
            Ref_Textbox.Text = item.Transaction_Id.ToString();
            Pcode_Textbox.Text = item.Product_Id.ToString();
            Description_Textbox.Text = item.Product_Name.ToString();
            Price_Textbox.Text = item.Price.ToString();
            Qty_Textbox.Text = item.Quantity.ToString(); 
            Discount_TextBox.Text= item.Discount.ToString();
            Total_Textbox.Text = item.Total.ToString();

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            string product_qty = Qty_Textbox.Text.ToString();
            string cancel_qty = CancelQty_Textbox.Text.ToString();
            string reason = Reason_Textbox.Text.ToString();
            //Check For Textboxes Validaiton
            if(Is_Vaild(cancel_qty,product_qty,reason))
            {
                Store_CancelledOrder_Details();
            }
                
        }
        public void Store_CancelledOrder_Details()
        {   
            int transaction_id= int.Parse(Ref_Textbox.Text.ToString().TrimEnd());
            int pcode = int.Parse(Pcode_Textbox.Text.ToString().TrimEnd());
            int cancel_qty = int.Parse(CancelQty_Textbox.Text.ToString().TrimEnd());
            int product_qty = int.Parse(Qty_Textbox.Text.ToString().TrimEnd());
            string cancelBy = CancelBy_Textbox.Text.ToString().TrimEnd();
            string action = Action_cmbobox.Text.ToString().TrimEnd();
            string reason = Reason_Textbox.Text.ToString().TrimEnd();
            string date= DateTime.Now.ToString();

            Insert_CancelledOrderes(transaction_id, pcode, cancel_qty, date, cancelBy, reason, action);
            Update_Quantity(transaction_id, cancel_qty, product_qty, pcode);
            Add_Product_To_Inventory(pcode, cancel_qty, action);
            Update_OrderDetails(cancel_qty);
            daily_Sales.Load_DailySales_Table();
        }
        void Delete_Item(int transaction_id,int pcode)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Transaction_Item WHERE Transaction_Id = @Transaction_Id AND Product_Id = @pcode;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Transaction_Id",transaction_id);
                cmd.Parameters.AddWithValue("@pcode", pcode);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error On Deleting Item");
            }
            finally
            {
                con.Close();
            }
        }
        void Delete_Transaction(int transaction_id)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Transactions WHERE Transaction_Id = @Transaction_Id ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Transaction_Id", transaction_id);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error On Deleting Trasnaction");
            }
            finally
            {
                con.Close();
            }
        }
        void Add_Product_To_Inventory(int pcode,int qty,string action)
        {
            if(action == "Yes")
            {
                Console.WriteLine(pcode);
                Console.WriteLine(qty);
                Console.WriteLine(action);
                try
                {
                    con.Open();
                    string query = "UPDATE\r\nProducts\r\nSET\r\nCur_Amount+=@qty \r\nWHERE Product_Id=@pcode ;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Can't Return Product to inventory");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        void Insert_CancelledOrderes(int transaction_id , int pcode , int cancel_qty, string date ,string cancelBy , string reason ,string action)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO \r\nCancelled_Orders \r\n(Transaction_Id,Product_id,Cancelled_Qty,Cancelled_Date,CancelledBy,Cancel_Reason,Action)\r\nVALUES\r\n(@Transaction_Id,@Product_id,@Cancelled_Qty,@Cancelled_Date,@CancelledBy,@Cancel_Reason,@Action);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Transaction_Id", transaction_id);
                cmd.Parameters.AddWithValue("@Product_id", pcode);
                cmd.Parameters.AddWithValue("@Cancelled_Qty", cancel_qty);
                cmd.Parameters.AddWithValue("@Cancelled_Date", date);
                cmd.Parameters.AddWithValue("@CancelledBy", cancelBy);
                cmd.Parameters.AddWithValue("@Cancel_Reason", reason);
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Cancelled");

            }
            catch
            {
                MessageBox.Show("Cancel Quantity is bigger than product quantity");
            }
            finally
            {
                con.Close();
            }
        }
        void Update_Quantity(int transaction_id , int cancel_qty,int product_qty,int pcode)
        {
            //Check If cancel_qty is equal to product_qty  
            if (cancel_qty == product_qty)
            {
                int items_cnt = Count_Transaction_Items(transaction_id);
                Console.WriteLine("items_cnt : " + items_cnt);
                Delete_Item(transaction_id,pcode);
                if (items_cnt == 1 && items_cnt != -1)
                {
                    Delete_Transaction(transaction_id);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Transaction_Item SET Quantity -= @Cancelled_Qty , Item_Total = Quantity * (SELECT p.Price FROM Products p WHERE p.Product_Id = @pcode) \r\nWHERE Transaction_Id = @Transaction_Id;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Transaction_Id", transaction_id);
                    cmd.Parameters.AddWithValue("@Cancelled_Qty", cancel_qty);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Product Successfully Cancelled");
                }
                catch
                {
                    MessageBox.Show("Error in Update Cancelled quantity");
                }
                finally
                {
                    con.Close();
                }
            }
        }
        void Update_OrderDetails(int cancel_qty)
        {
            int current_qty = int.Parse(Qty_Textbox.Text.ToString());
            int newQty =  current_qty - cancel_qty ;
            float price = item.Price;
            Qty_Textbox.Text = newQty.ToString();
            Total_Textbox.Text = (price * newQty).ToString();
        }
        bool Is_Vaild(string cancel_qty, string product_qty, string reason)
        {
            //Check Empty Textboxes
            if (cancel_qty == "" || reason == "")
            {
                MessageBox.Show("Fill The Empty Boxes");
                return false;
            }
            //Check The invaild qty input
            else if (cancel_qty.Any(char.IsLetter))
            {
                MessageBox.Show("Enter a numeric number");
                return false;
            }
            //check for product_qty comapre to cancelled_qty 
            else if (int.Parse(product_qty) < int.Parse(cancel_qty) || int.Parse(cancel_qty) == 0)
            {
                MessageBox.Show("Cancel Quantity is bigger than product quantity");
                return false;
            }
            return true;
        }
        int Count_Transaction_Items(int transaction_id)
        {
            int cnt = -1;
            try
            {
                con.Open();
                string query = "SELECT \r\nCOUNT(Item_Id) AS cnt\r\nFROM Transaction_Item \r\nWHERE Transaction_Id = @Transaction_Id;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Transaction_Id", transaction_id);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cnt = int.Parse(dr["cnt"].ToString().TrimEnd());
                }
            }
            catch
            {
                MessageBox.Show("Error in Update Cancelled quantity");
            }
            finally
            {
                con.Close();
            }
            return cnt;
        }
    }
}
