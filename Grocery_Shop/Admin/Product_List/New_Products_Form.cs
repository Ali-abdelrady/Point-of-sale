using Grocery_Shop.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class New_Products_Form : Form
    {   
        //Database Connection
        private SqlConnection con;

        //Initalize My Classes
        ProductList_Form ProductList;
        Product product;
        Validations validations = new Validations();

        //Brands_Categoires Ids List
        List<int> Brand_Id = new List<int>();
        List<int> Category_Id = new List<int>();
        public New_Products_Form(ProductList_Form form,Product p)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            ProductList = form;
            product = p;
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Products_Form_Load(object sender, EventArgs e)
        {
            Fill_Brand_Combobox();
            Fill_Category_Combobox();
            if(SaveUpdate_Btn.Text == "UPDATE")
            {
                Load_DataFor_Edit();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveUpdate_Btn_Click(object sender, EventArgs e)
        {
            //Get Product Details
            int product_id = product.Product_Id;
            string product_name = ProductName_txtbox.Text.ToString();
            string barcode = Barcode_Txtbox.Text.ToString();
            int brand_id = Brand_Id[Brand_Combox.SelectedIndex];
            int category_id = Category_Id[Category_Combox.SelectedIndex];
            string price = Price_Txtbox.Text.ToString();
            if(Is_Empty(product_name,barcode, Price_Txtbox.Text.ToString()))
            {
                MessageBox.Show("Fill All Empty Boxes");
            }
            else if(Price_Txtbox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Enter a numric value");
                Price_Txtbox.Clear();
            }
            else
            {
                //Check If the btn iS Save Or Update
                if (SaveUpdate_Btn.Text == "SAVE")
                {
                    SaveProduct(product_name, barcode, brand_id, category_id, float.Parse(price));
                }
                else
                {
                    UpdateProduct(product_id,product_name, barcode, brand_id, category_id, float.Parse(price));
                }
            }
        }
        //-----------------------------ADDTIONAL FUNCTIONS--------------------------
        public void Set_Btn_Txt(string name)
        {
            SaveUpdate_Btn.Text = name;
        }
        void Fill_Brand_Combobox()
        {
            string query = "SELECT * FROM Brands";
            try
            {

                con.Open();
                SqlCommand cmd2 = new SqlCommand(query, con);
                SqlDataReader rd = cmd2.ExecuteReader();
                while (rd.Read())
                {
                    Brand_Id.Add(int.Parse(rd["Brand_Id"].ToString().TrimEnd()));
                    Brand_Combox.Items.Add(rd["Brand_Name"].ToString().TrimEnd());
                }
                Brand_Combox.SelectedIndex = 0;
                //MessageBox.Show("sucees on Filling Combobox");
            }
            catch 
            {
                MessageBox.Show("Error on Filling Brands Combobox");
            }
            finally 
            { 
                con.Close();
            }    
        }
        void Fill_Category_Combobox()
        {
            string query = "SELECT * FROM Categories";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    //string StrName=reader.GetString(0);
                    Category_Id.Add(int.Parse(rd["Category_Id"].ToString().TrimEnd()));
                    Category_Combox.Items.Add(rd["Category_Name"].ToString().TrimEnd());
                }
                Category_Combox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Error on Filling Brands Combobox");
            }
            finally
            {
                con.Close();
            }
        }
        void Load_DataFor_Edit()
        {
            ProductName_txtbox.Text = product.Product_Name;
            Barcode_Txtbox.Text = product.Barcode;
            Price_Txtbox.Text = product.Price.ToString();
            Brand_Combox.Text = product.Brand;
            Category_Combox.Text = product.Category;
        }
        void Reset_TextBoxes()
        {
            ProductName_txtbox.Clear();
            Barcode_Txtbox.Clear();
            Price_Txtbox.Clear();
            Brand_Combox.Text = "";
            Category_Combox.Text = "";
        }
        void SaveProduct(string product_name, string barcode, int brand_id, int category_id, float price)
        {
            string query = "INSERT INTO Products (Name,Barcode,Brand_Id,Category_Id,Price) VALUES (@product_name,@barcode,@brand_id,@category_id,@price)";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@product_name", product_name);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@brand_id", brand_id);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                Reset_TextBoxes();
                ProductList.LoadProductsTable();
                MessageBox.Show("succesful opereation ");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateProduct(int product_id, string product_name, string barcode, int brand_id, int category_id, float price)
        {
            string query = "UPDATE Products SET Name=@product_name ,Price=@price , Barcode=@barcode ,Category_Id=@category_id ,Brand_Id=@brand_id  WHERE Product_Id=@product_id";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@product_name", product_name);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@brand_id", brand_id);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("succssful updating");
                //Reset_TextBoxes();
                ProductList.LoadProductsTable();
            }
            catch
            {
                MessageBox.Show("Error in Updating DB");
            }
            finally { con.Close(); }
        }
        bool Is_Empty(string product_name , string barcode , string price)
        {
            return (product_name.Length == 0 || barcode.Length == 0 || price.Length == 0);
        }
    }
    
}