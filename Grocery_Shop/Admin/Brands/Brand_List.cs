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

namespace Grocery_Shop
{
    public partial class Brand_List : UserControl
    {

        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        //Brands Id
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
        public Brand_List()
        {
            InitializeComponent();
            
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Brand_Details brand_form = new Brand_Details(this);
            brand_form.Set_Btn_Txt("SAVE");
            brand_form.ShowDialog();
        }
        public void RefreshTable()
        {
            Brands_Table.DataSource = LoadUserTable();
        }
          DataTable LoadUserTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Brands";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
                throw;
            }
        }

        private void Brand_List_Load(object sender, EventArgs e)
        {
            LoadUserTable();
            Brands_Table.DataSource = LoadUserTable();
/*            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;*/
        }

        private void Brands_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Brands_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (Brands_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Brands_Table.Rows[e.RowIndex];
                    int brand_id = int.Parse(row.Cells[2].Value.ToString());
                    try
                    {
                        string query = "DELETE FROM Brands WHERE Brand_Id=@brand_id";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@brand_id", brand_id);
                        cmd.ExecuteNonQuery();
                        Brands_Table.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Deleted Successfully");

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
            else if (Brands_Table.Columns[e.ColumnIndex].DataPropertyName == "Edit")
            {

                if (Brands_Table.Rows.Count > 0)
                {
                    int brand_id = int.Parse(Brands_Table.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd());
                    string brand_name = Brands_Table.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();
                    //Set Values To the Ob
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
            try
            {
                DataTable dt = new DataTable();
                string brand_name = Search_Txtbox.Text;
                string query = "SELECT * FROM Brands WHERE Brand_Name LIKE '%" + brand_name + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Brands_Table.DataSource = dt;
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

        private void Search_Txtbox_Click(object sender, EventArgs e)
        {
            Search_Txtbox.Clear();
        }
        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            if (Search_Txtbox.Text == "Search here")
            {
                Search_Txtbox.Clear();
                Search_Txtbox.ForeColor = Color.Black;
            }
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            if (Search_Txtbox.Text == "")
            {
                Search_Txtbox.Text = "Search here";
                Search_Txtbox.ForeColor = Color.Gray;
            }
        }
    }
}
