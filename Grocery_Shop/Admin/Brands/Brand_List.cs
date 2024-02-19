using Grocery_Shop.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grocery_Shop
{
    public partial class Brand_List : UserControl
    {

        //Database Connection
        private SqlConnection con;

        TextboxStyles textboxStyle = new TextboxStyles();
        //Brands Id
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public Brand_List()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Brand_Details brand_form = new Brand_Details(this);
            brand_form.Set_Btn_Txt("SAVE");
            brand_form.ShowDialog();
        }
        public void LoadBrandsTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string brand_name = Search_Txtbox.Text;
                string query1 = "SELECT * FROM Brands WHERE Brand_Name LIKE '%" + brand_name + "%'";
                string query2 = "SELECT * FROM Brands";
                string res_query = (brand_name == " Search here") ? query2 : query1;
                con.Open();
                SqlCommand cmd = new SqlCommand(res_query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Brands_Table.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Error in Load Brands Table");
            }
            finally
            {
                con.Close();
            }
        }
        private void Brand_List_Load(object sender, EventArgs e)
        {
            LoadBrandsTable();
        }

        private void Brands_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Brands_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (Brands_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Brands_Table.Rows[e.RowIndex];
                    int brand_id = int.Parse(row.Cells[2].Value.ToString());

                    DeleteBrands(brand_id, e);
                }
            }
            else if (Brands_Table.Columns[e.ColumnIndex].DataPropertyName == "Edit")
            {

                if (Brands_Table.Rows.Count > 0)
                {
                    int brand_id = int.Parse(Brands_Table.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd());
                    string brand_name = Brands_Table.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();
                    //Set Values To the Obj
                    Brand_Id = brand_id;
                    Brand_Name =brand_name;
                    //open the form
                    Brand_Details brand_form = new Brand_Details(this);
                    brand_form.Set_Btn_Txt("UPDATE");
                    brand_form.ShowDialog();
                }
            }
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadBrandsTable();
        }

        private void Search_Txtbox_Click(object sender, EventArgs e)
        {
            Search_Txtbox.Clear();
        }
        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(Search_Txtbox, " Search here");
        }
        void DeleteBrands(int brand_id , DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Brands WHERE Brand_Id=@brand_id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@brand_id", brand_id);
                cmd.ExecuteNonQuery();
                Brands_Table.Rows.RemoveAt(e.RowIndex);
                //MessageBox.Show("Deleted Successfully");

            }
            catch
            {
                MessageBox.Show("error om Delete product");

            }
            finally
            {
                con.Close();
            }
        }
    }
}
