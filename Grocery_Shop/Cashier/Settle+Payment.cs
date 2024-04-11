using Grocery_Shop.Cashier;
using Grocery_Shop.Classes;
using Grocery_Shop.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Settle_Payment : Form
    {

        //Database Connection
        private SqlConnection con;

        Cashier_Mainform cashier;
        DataTable solditems;
        DataGridView Purchases_Table;
        List<int> products_id; 
        public Settle_Payment(Cashier_Mainform cashier, DataGridView dgv, List<int> products_id)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            this.cashier = cashier;
            this.products_id = products_id;
            Purchases_Table = dgv;
        }
        private void Settle_Payment_Load(object sender, EventArgs e)
        {
            Total_Price_Lbl.Text = cashier.Get_Total_Sales();
        }
        private void one_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("1");
        }   
        private void two_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("2");
        } 
        private void three_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("3");
        }
        private void four_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("4");
        }
        private void five_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("5");
        }
        private void six_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("6");
        }
        private void seven_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("7");
        }
        private void eight_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("8");
        }   
        private void nine_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("9");
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            Calc_Addition("0");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            string s = Paid_Lbl.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            Paid_Lbl.Text = s;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Paid_Lbl_TextChanged(object sender, EventArgs e)
        {
            float total = float.Parse(Total_Price_Lbl.Text.ToString());
            float paid = float.Parse(Paid_Lbl.Text.ToString());
            Remaining_Lbl.Text = (total - paid).ToString();
        }
        private void zero_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D0)
            {
                zero_btn.PerformClick();
            }
        }
        private void back_btn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {  

            // insert data into transaction table and get the transaction 
            InsertInto_Transaction_Table();

            //insert data into transaction item table 
            InsertInto_TransactionItems_Table();

            // Update Product Quantity
            Update_ProductQty();

            //Clear Table
            cashier.Clear_Purchases_Table();
            this.Close();
            //open Report Form
            Transaction_Report form = new Transaction_Report();
            form.ShowDialog();
            cashier.Calc_Final_Price();
        }

        private void enter_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enter_btn.PerformClick();
            }
        }

        private void Settle_Payment_KeyDown(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Enter:
                    enter_btn.PerformClick();
                    break;
                case Keys.Back:
                    back_btn.PerformClick();
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    zero_btn.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    one_btn.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    two_btn.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    three_btn.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    four_btn.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    five_btn.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    six_btn.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    seven_btn.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    eight_btn.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    nine_btn.PerformClick();
                    break;
            }

        }


        private void Settle_Paymet_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void nine_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.NumPad9)
            {
                nine_btn.PerformClick();
            }
        }
        void Calc_Addition(string num)
        {
            if (Paid_Lbl.Text == "0" && Paid_Lbl.Text != null)
            {
                Paid_Lbl.Text = num;
            }
            else
            {
                Paid_Lbl.Text = Paid_Lbl.Text + num;
            }
        }
        void InsertInto_Transaction_Table()
        {
            try
            {
                con.Open();
                string query1 = "INSERT INTO Transactions (Store_Id,Emp_Id,Transaction_Date) VALUES (1,@emp_id,@date)";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@emp_id", User.Emp_Id);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Added Succssefuly");
            }
            catch
            {
                MessageBox.Show(" Failed to add the transaction");
            }
            finally
            {
                con.Close();
            }
        }
        void InsertInto_TransactionItems_Table()
        {
            int pcode;
            int qty;
            float discount;
            float total;
            foreach (DataGridViewRow row in Purchases_Table.Rows)
            {
                pcode = products_id[row.Index];
                qty = int.Parse(row.Cells["QTY"].Value.ToString());
                discount = float.Parse(row.Cells["DISCOUNT"].Value.ToString());
                total = float.Parse(row.Cells["TOTAL"].Value.ToString());

                try
                {
                    con.Open();
                    string query = "INSERT INTO Transaction_Item (Transaction_Id,Product_Id,Quantity,Discount,Item_Total) VALUES (IDENT_CURRENT('Transactions'),@pcode,@qty,@discount,@total)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@discount", discount);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(" Failed to add the transaction");
                }
                finally
                {
                    con.Close();

                }
            }
        }
        void Update_ProductQty()
        {
            int pcode;
            int qty;
            foreach (DataGridViewRow row in Purchases_Table.Rows)
            {
                pcode = products_id[row.Index];
                qty = int.Parse(row.Cells["QTY"].Value.ToString());
                try
                {
                    con.Open();
                    string query = "UPDATE Products SET Cur_Amount-=@qty WHERE Product_Id = @pcode;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pcode", pcode);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show(" Failed to Update quantity");
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
