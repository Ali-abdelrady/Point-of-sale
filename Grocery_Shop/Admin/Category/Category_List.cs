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
    public partial class Category_List : UserControl
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public Category_List()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Category_Details category = new Category_Details(this);
            category.ShowDialog();
        }
        DataTable LoadUserTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM Categories";
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
        public void RefreshTable()
        {
            Category_Table.DataSource = LoadUserTable();
        }

        private void Category_List_Load(object sender, EventArgs e)
        {
            LoadUserTable();
            Category_Table.DataSource = LoadUserTable();
/*            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;*/
        }

        private void Category_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Category_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (Category_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Category_Table.Rows[e.RowIndex];
                    int category_id =int.Parse(row.Cells[2].Value.ToString());
                    try
                    {
                        string query = "DELETE FROM Categories WHERE Category_Id=@category_id";
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@category_id", category_id);
                        cmd.ExecuteNonQuery();
                        Category_Table.Rows.RemoveAt(e.RowIndex);
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
            else if (Category_Table.Columns[e.ColumnIndex].DataPropertyName == "Edit")
            {

                if (Category_Table.Rows.Count > 0)
                {
                    int category_id = int.Parse(Category_Table.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd());
                    string category_name = Category_Table.Rows[e.RowIndex].Cells[3].Value.ToString().TrimEnd();
                    //Set Values To the Ob
                    Category_Id = category_id;
                    Category_Name = category_name;
                    //open the form
                    Category_Details category_form = new Category_Details(this);
                    category_form.Set_Btn_Txt("UPDATE");
                    category_form.ShowDialog();
                }
            }
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string Category_name = Search_Txtbox.Text;
                string query = "SELECT * FROM Categories WHERE Category_Name LIKE '%" + Category_name + "%'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Category_Table.DataSource = dt;
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
