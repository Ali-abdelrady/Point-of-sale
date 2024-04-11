using Grocery_Shop.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class ProductList_Form : UserControl
    {
        //Database Connection
        private SqlConnection con;

        TextboxStyles textboxStyle = new TextboxStyles();
        //initalize the class
        Product product=new Product();
        public ProductList_Form()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            New_Products_Form form = new New_Products_Form(this,product);
            form.Set_Btn_Txt("SAVE");
            form.ShowDialog();

        }
        public void LoadProductsTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string product_name = Search_Txtbox.Text;
                string query1 = "SELECT Product_Id,Name,Price,Barcode,Category_Name,Brand_Name FROM Products p,Categories c,Brands b WHERE p.Category_Id=c.Category_Id and p.Brand_Id=b.Brand_Id and Name LIKE '%" + product_name + "%'";
                string query2 = "SELECT Product_Id,Name,Price,Barcode,Category_Name,Brand_Name FROM Products p,Categories c,Brands b WHERE p.Category_Id=c.Category_Id and p.Brand_Id=b.Brand_Id";
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
        private void ProductList_Form_Load(object sender, EventArgs e)
        {
            LoadProductsTable();
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadProductsTable();
        }

        private void Search_Txtbox_Click(object sender, EventArgs e)
        {
            Search_Txtbox.ResetText();
        }

        private void Products_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check for the cell Coulmn Header
            if (Products_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                //Check If There Is Rows To Delete
                if (Products_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Products_Table.Rows[e.RowIndex];
                    int product_id = int.Parse(row.Cells[2].Value.ToString());

                    DeleteProduct(product_id,e);
                }
            }
            else if (Products_Table.Columns[e.ColumnIndex].DataPropertyName == "Edit")
            {
                //Check If There Is Rows To Edit
                if (Products_Table.Rows.Count > 0)
                {
                    //Set Values To the Product Obj
                    product.Product_Id = int.Parse(Products_Table.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd());
                    product.Product_Name= Products_Table.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();
                    product.Price= float.Parse(Products_Table.Rows[e.RowIndex].Cells[4].Value.ToString().TrimEnd());
                    product.Barcode= Products_Table.Rows[e.RowIndex].Cells[5].Value.ToString().TrimEnd();
                    product.Category = Products_Table.Rows[e.RowIndex].Cells[6].Value.ToString().TrimEnd();
                    product.Brand= Products_Table.Rows[e.RowIndex].Cells[7].Value.ToString().TrimEnd();

                    //open the form
                    New_Products_Form form =new New_Products_Form(this,product);
                    form.Set_Btn_Txt("UPDATE");
                    form.ShowDialog();
                }
            }
        }

        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(Search_Txtbox, " Search here");
        }
        void DeleteProduct(int product_id , DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Products WHERE Product_Id=@product_id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                cmd.ExecuteNonQuery();
                Products_Table.Rows.RemoveAt(e.RowIndex);
                //MessageBox.Show("Deleted Successfully");

            }
            catch
            {
                MessageBox.Show("error in Deleting product");

            }
            finally
            {
                con.Close();
            }
        }
    }
}
