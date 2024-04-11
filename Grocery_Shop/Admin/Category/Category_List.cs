using Grocery_Shop.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Category_List : UserControl
    {
        //Database Connection
        private SqlConnection con;
        TextboxStyles textboxStyle = new TextboxStyles();
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public Category_List()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Category_Details category = new Category_Details(this);
            category.ShowDialog();
        }
        public void LoadCategoriesTable()
        {
            try
            {
                DataTable dt = new DataTable();
                string category_name = Search_Txtbox.Text;
                string query1 = "SELECT * FROM Categories WHERE Category_Name LIKE '%" + category_name + "%'";
                string query2 = "SELECT * FROM Categories";
                string res_query = (category_name == " Search here") ? query2 : query1;
                con.Open();
                SqlCommand cmd = new SqlCommand(res_query, con);
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


        private void Category_List_Load(object sender, EventArgs e)
        {
            LoadCategoriesTable();
        }

        private void Category_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Category_Table.Columns[e.ColumnIndex].DataPropertyName == "Delete")
            {
                if (Category_Table.Rows.Count > 0)
                {
                    DataGridViewRow row = Category_Table.Rows[e.RowIndex];
                    int category_id =int.Parse(row.Cells[2].Value.ToString());
                    DeleteCategories(category_id, e);
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
            LoadCategoriesTable();
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
        void DeleteCategories(int category_id, DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "DELETE FROM Categories WHERE Category_Id=@category_id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@category_id", category_id);
                cmd.ExecuteNonQuery();
                Category_Table.Rows.RemoveAt(e.RowIndex);
                //MessageBox.Show("Deleted Successfully");

            }
            catch
            {
                MessageBox.Show("Error In Delete Category");

            }
            finally
            {
                con.Close();
            }
        }

    }
}
