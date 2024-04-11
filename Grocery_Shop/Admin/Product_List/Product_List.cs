using Grocery_Shop.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Product_List : Form
    {
        ///Database Connection
        private SqlConnection con;
        TextboxStyles textboxStyle = new TextboxStyles();
        StockEntry_Form entryForm;
        public Product_List(StockEntry_Form entryForm)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            this.entryForm = entryForm;
        }

        private void Product_List_Load(object sender, EventArgs e)
        {
            Load_Products_Table();
            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;
        }
        void Load_Products_Table()
        {
            DataTable dt= new DataTable();  
            try
            {
                con.Open();
                string query = "SELECT Product_Id,Name,Cur_Amount FROM Products ";
                SqlCommand cmd= new SqlCommand(query, con);
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                da.Fill(dt);
                Products_Table.DataSource= dt;
            }
            catch
            {
                MessageBox.Show("Error in loading Priducts table ");
            }
            finally
            {
                con.Close();
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string product_name = Search_Txtbox.Text;
                string query1 = "SELECT Product_Id,Name,Cur_Amount FROM Products WHERE Name LIKE '%" + product_name + "%'";
                string query2 = "SELECT Product_Id,Name,Cur_Amount FROM Products";
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
            if (Products_Table.Columns[e.ColumnIndex].DataPropertyName == "Correct")
            {
                if (Products_Table.Rows.Count > 0)
                {
                    int pcode = int.Parse(Products_Table.Rows[e.RowIndex].Cells[1].Value.ToString());
                    string product_name = Products_Table.Rows[e.RowIndex].Cells[2].Value.ToString();
                    entryForm.Add_Rows_On_Table(pcode, product_name);
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

    }
}
