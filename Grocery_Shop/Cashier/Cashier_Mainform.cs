using Grocery_Shop.Classes;
using Grocery_Shop.Login;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Cashier_Mainform : Form
    {   //Database Connection
        private SqlConnection con;

        public List<int> Products_Ids = new List<int>();
        //My Classes
        TextboxStyles textboxStyle = new TextboxStyles();
        Authenticator authenticator = new Authenticator();
        Product product = new Product();
        public Cashier_Mainform()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }
        private void logout_bnt_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form form = new login_form(authenticator);
            form.Show();
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            Textboxes_PlaceHolders();
            Get_Next_TransactionId();
            Button_Event_Handler();
            transaction_date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void change_pass_btn_Click(object sender, EventArgs e)
        {
            Change_Password Form = new Change_Password();
            Form.ShowDialog();
        }

        private void clear_cart_btn_Click(object sender, EventArgs e)
        {
            Purchases_Table.Rows.Clear();
            clear_cart_btn.FlatAppearance.BorderSize = 0;
        }

        private void Discount_Btn_Click(object sender, EventArgs e)
        {
            //Check rows availability
            if (Purchases_Table.Rows.Count > 0)
            {
                //Select row to set discount
                if (Purchases_Table.CurrentRow.Selected)
                {
                    Discount_Form form = new Discount_Form(this);
                    form.Row_Index = Purchases_Table.CurrentRow.Index;
                    form.Total_Price = float.Parse(Purchases_Table.CurrentRow.Cells[4].Value.ToString());
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Row is Selected", "Error");
                }
            }
            else
            {
                MessageBox.Show("Select Product To Put Discount On", "Error");
            }
        }
        private void Settle_Payment_Btn_Click(object sender, EventArgs e)
        {
            if(Purchases_Table.Rows.Count == 0)
            {
                MessageBox.Show("There Is No Porducts In Table");
            }
            else
            {
                Settle_Payment form = new Settle_Payment(this, Purchases_Table, Products_Ids);
                form.ShowDialog();
            }
        }

        private void NewTransaction_Btn_Click(object sender, EventArgs e)
        { 
            clear_cart_btn.PerformClick();   //Clear the puraches table
            Get_Next_TransactionId();        
        }

        //---------------------CASHIER MAIN FORM----------------------
        private void Add_btn_Click(object sender, EventArgs e)
        {
            Get_Product_Details();
        }

        private void Purchases_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Delete Row
            if (Purchases_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (Purchases_Table.Rows.Count > 0)
                {
                    Products_Ids.RemoveAt(e.RowIndex);
                    Purchases_Table.Rows.RemoveAt(e.RowIndex);
                    Calc_Final_Price();
                    Console.WriteLine("------------------------------");
                    foreach (int id in Products_Ids)
                    {
                        Console.WriteLine(id);
                    }
                    Console.WriteLine("------------------------------");
                }
            }
        }

        private void barcode_search_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add_btn.PerformClick();
            }
        }

        //-------------------------------------PRODUT LIST CODE-------------------------------------

        private void Products_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if cell is Add icon
            if (Products_Table.Columns[e.ColumnIndex].DataPropertyName == "Add")
            {
                // Check If Product in stock 
                int curAmount = int.Parse(Products_Table.Rows[e.RowIndex].Cells[8].Value.ToString());
                if(Products_Table.Rows[e.RowIndex].Cells[8].Value.ToString() == "0")
                {
                    MessageBox.Show("This Product Is Out Of Stock");
                }
                else
                {
                    // Get product Details And add to the class
                    string name = Products_Table.Rows[e.RowIndex].Cells[3].Value.ToString();
                    int id = int.Parse(Products_Table.Rows[e.RowIndex].Cells[2].Value.ToString());
                    float price = float.Parse(Products_Table.Rows[e.RowIndex].Cells[4].Value.ToString());
                    product.Product_Id=id;
                    product.Product_Name = name;
                    product.Price = price;
                    product.Cur_Amount = curAmount;
                    int currentQuantity = 0;
                    if (Products_Ids.IndexOf(product.Product_Id) != -1)
                    {
                        int row_index = Products_Ids.IndexOf(product.Product_Id);
                        currentQuantity = int.Parse(Purchases_Table.Rows[row_index].Cells["QTY"].Value.ToString());
                    }
                    //Calculate The Quantity Of Product
                    Quantity_form form = new Quantity_form(this, product, currentQuantity);
                    form.ShowDialog();
                }
            }
        }
        private void Search_Product_txtbox_TextChanged(object sender, EventArgs e)
        {
            GetProductByName();
            //highlight out of stock producrs 
            Highlight_OutStock();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Product_txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Product_txtbox, " Search here");
        }

        private void Search_Product_txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(Search_Product_txtbox, " Search here");
        }

        private void barcode_search_txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(barcode_search_txtbox, " Search Barcode Here");
        }

        private void barcode_search_txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(barcode_search_txtbox, " Search Barcode Here");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer_Lbl.Text = DateTime.Now.ToString("T");
        }

        private void Left_Frame_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = System.Drawing.Color.FromArgb(23, 167, 255);
            }
        }

        private void Left_Frame_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = System.Drawing.Color.FromArgb(40,45,50);
            }
        }
        private void Button_Event_Handler()
        {
/*            //Transaction
            NewTransaction_Btn.MouseEnter += Left_Frame_MouseEnter;
            NewTransaction_Btn.MouseLeave += Left_Frame_MouseLeave;*/

            //Cart
            clear_cart_btn.MouseEnter += Left_Frame_MouseEnter;
            clear_cart_btn.MouseLeave += Left_Frame_MouseLeave;

            //Discount
            Discount_Btn.MouseEnter += Left_Frame_MouseEnter;
            Discount_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Settle Payment
            Settle_Payment_Btn.MouseEnter += Left_Frame_MouseEnter;
            Settle_Payment_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Password
            change_pass_btn.MouseEnter += Left_Frame_MouseEnter;
            change_pass_btn.MouseLeave += Left_Frame_MouseLeave;

            //Daily Sales
            DailySales_Btn.MouseEnter += Left_Frame_MouseEnter;
            DailySales_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Logout
            logout_bnt.MouseEnter += Left_Frame_MouseEnter;
            logout_bnt.MouseLeave += Left_Frame_MouseLeave;
        }

        //---------------- Methods----------------
        void Highlight_OutStock()
        {
            foreach (DataGridViewRow row in Products_Table.Rows)
            {
                if (row.Cells[8].Value.ToString().TrimEnd() == "0")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
        public void Calc_Final_Price()
        {
            float fullPrice = 0;
            double discount = 0.0;
            foreach (DataGridViewRow row in Purchases_Table.Rows)
            {
                fullPrice += float.Parse(row.Cells["PRICE"].Value.ToString()) * int.Parse(row.Cells["QTY"].Value.ToString()) ;
                discount += double.Parse(row.Cells["DISCOUNT"].Value.ToString());
            }
            FullPrice_Lbl.Text = fullPrice.ToString();
            Discount_Lbl.Text = discount.ToString();
            FinalPrice_Lbl.Text = (fullPrice - discount).ToString();
        }
        void Textboxes_PlaceHolders()
        {
            Search_Product_txtbox.Text = " Search here";
            Search_Product_txtbox.ForeColor = Color.Gray;
            barcode_search_txtbox.Text = " Search Barcode Here";
            barcode_search_txtbox.ForeColor = Color.Gray;
        }
        void Get_Product_Details()
        {
            string barcode;
            barcode = barcode_search_txtbox.Text;
            int pcode;
            string query = "SELECT Product_Id,Name,Price,Cur_Amount FROM Products WHERE Barcode='" + barcode + "'";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    product.Product_Id = int.Parse(dr["Product_Id"].ToString());
                    product.Product_Name = dr["Name"].ToString();
                    product.Price = float.Parse(dr["Price"].ToString());
                    product.Cur_Amount = int.Parse(dr["Cur_Amount"].ToString());

                    if(product.Cur_Amount == 0)
                    {
                        MessageBox.Show("This Product Is out of stock");
                        barcode_search_txtbox.Clear();
                    }
                    else
                    {
                        int currentQuantity = 0;
                        if (Products_Ids.IndexOf(product.Product_Id) != -1)
                        {
                            int row_index = Products_Ids.IndexOf(product.Product_Id);
                            currentQuantity = int.Parse(Purchases_Table.Rows[row_index].Cells["QTY"].Value.ToString());
                        }
                        //Calculate The Quantity Of Product
                        Quantity_form form = new Quantity_form(this, product , currentQuantity);  
                        form.ShowDialog();
                        barcode_search_txtbox.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No Product With This Barcode");
                    barcode_search_txtbox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error to get product details");
            }
            finally
            {
                con.Close();
            }
        }
        void Get_Next_TransactionId()
        {
            DataTable dt = new DataTable();
            string query = "SELECT IDENT_CURRENT('Transactions')";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                transaction_num.Text = (int.Parse(dt.Rows[0][0].ToString()) + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Error on getinng transction number");
            }
            finally
            {
                con.Close();
            }
        }
        public void AddTo_Purchases_Table(int newQuantity)
        {
            float newTotalPrice = newQuantity * product.Price;
            int pcode = product.Product_Id;
/*            Console.WriteLine(pcode);
*/
            if (Products_Ids.IndexOf(pcode) != -1)
            {
                //Update QTY And Total in table
                int row_index = Products_Ids.IndexOf(pcode);
                int currentQuantity = int.Parse(Purchases_Table.Rows[row_index].Cells[2].Value.ToString());
                float currentTotalPrice = float.Parse(Purchases_Table.Rows[row_index].Cells[4].Value.ToString());
                Purchases_Table.Rows[row_index].Cells["QTY"].Value = (currentQuantity + newQuantity).ToString();
                Purchases_Table.Rows[row_index].Cells["TOTAL"].Value = (currentTotalPrice + newTotalPrice).ToString();
                //Console.WriteLine("This proucts exist");
            }
            else
            {
                Products_Ids.Add(pcode);
                Purchases_Table.Rows.Add(product.Product_Name, product.Price, newQuantity, 0, newTotalPrice);

            }
            Calc_Final_Price();
                
                Console.WriteLine("------------------------------");
                foreach (int id in Products_Ids)
                {
                    Console.WriteLine(id);
                }
                Console.WriteLine("------------------------------");
            
        }
        public string Get_Total_Sales()
        {
            float total_sales = 0;
            foreach (DataGridViewRow row in Purchases_Table.Rows)
            {
                total_sales += float.Parse(row.Cells[4].Value.ToString());
            }
            return total_sales.ToString();
        }
        public void SetProductDiscount(int row_index, float discount, float total_price)
        {
            Purchases_Table.Rows[row_index].Cells[3].Value = discount.ToString();
            Purchases_Table.Rows[row_index].Cells[4].Value = total_price.ToString();
            Calc_Final_Price();
        }
        private void DailySales_Btn_Click(object sender, EventArgs e)
        {
            Daily_Sales form = new Daily_Sales();
            form.ShowDialog();
        }
        private void GetProductByName()
        {
            try
            {
                string product_name = Search_Product_txtbox.Text;
                DataTable dt = new DataTable();
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
                MessageBox.Show("Error To Load Products");
            }
            finally
            {
                con.Close();
            }
        }
        private void Purchases_Table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Purchases_Table.Columns[e.ColumnIndex].DataPropertyName == "QTY")
            {
                /*Console.WriteLine("QTY CELL Changed");*/
            }
        }

        private void FinalPrice_Lbl_Click(object sender, EventArgs e)
        {

        }
        public void Clear_Purchases_Table()
        {
            Purchases_Table.Rows.Clear();
        }
    }
}
