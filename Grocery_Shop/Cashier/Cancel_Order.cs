using Grocery_Shop.Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Cancel_Order : Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        SoldItem_Details item;
        public Cancel_Order(SoldItem_Details item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Order_Load(object sender, EventArgs e)
        {
            Load_SoldItem_Details();
            CancelBy_Textbox.Text = Global.Role;
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
            int product_qty = int.Parse(Qty_Textbox.Text.ToString());
            int cancel_qty = int.Parse(CancelQty_Textbox.Text.ToString());
            if(product_qty >= cancel_qty && cancel_qty != 0)
            {
                Order_Void form = new Order_Void(this);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cancel Quantity is bigger than product quantity");
            }
        }
        public void Store_CancelledOrder_Details()
        {   
            int transaction_id= int.Parse(Ref_Textbox.Text.ToString().TrimEnd());
            int pcode = int.Parse(Pcode_Textbox.Text.ToString().TrimEnd());
            int cancel_qty = int.Parse(CancelQty_Textbox.Text.ToString().TrimEnd());
            string cancelBy = CancelBy_Textbox.Text.ToString().TrimEnd();
            string voidBy = VoidBy_Textbox.Text.ToString().TrimEnd();
            string action = Action_cmbobox.Text.ToString().TrimEnd();
            string reason = Reason_Textbox.Text.ToString().TrimEnd();
            string date= DateTime.Now.ToString();
            /*            Console.WriteLine(transaction_id);
                        Console.WriteLine(pcode);
                        Console.WriteLine(cancel_qty);
                        Console.WriteLine(cancelBy);
                        Console.WriteLine(voidBy);
                        Console.WriteLine(action);
                        Console.WriteLine(reason);
                        Console.WriteLine(date);*/


            try
            {
                con.Open();
                string query = "INSERT INTO \r\nCancelled_Orders \r\n(Transaction_Id,Product_id,Cancelled_Qty,Cancelled_Date,Void_By,CancelledBy,Cancel_Reason,Action)\r\nVALUES\r\n(@Transaction_Id,@Product_id,@Cancelled_Qty,@Cancelled_Date,@Void_By,@CancelledBy,@Cancel_Reason,@Action);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Transaction_Id", transaction_id);
                cmd.Parameters.AddWithValue("@Product_id", pcode);
                cmd.Parameters.AddWithValue("@Cancelled_Qty", cancel_qty);
                cmd.Parameters.AddWithValue("@Cancelled_Date", date);
                cmd.Parameters.AddWithValue("@Void_By", voidBy);
                cmd.Parameters.AddWithValue("@CancelledBy", cancelBy);
                cmd.Parameters.AddWithValue("@Cancel_Reason", reason);
                cmd.Parameters.AddWithValue("@Action", action);
                cmd.ExecuteNonQuery();
                con.Close();
                Add_Product_To_Inventory(pcode, cancel_qty, action);
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
        public void Update_Transaction_Details()
        {

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

    }
}
