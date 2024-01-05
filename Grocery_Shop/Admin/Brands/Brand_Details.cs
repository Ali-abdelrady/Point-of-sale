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
    public partial class Brand_Details : Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        Brand_List brand_list;
        public Brand_Details(Brand_List list)
        {
            InitializeComponent();
            this.brand_list = list;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {

        }

        private void SaveUpdate_Btn_Click(object sender, EventArgs e)
        {
            if (SaveUpdate_Btn.Text == "SAVE")
            {
                string brand_name = Brand_Txtbox.Text;
                string query = "INSERT INTO Brands (Brand_Name) VALUES(@name)";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", brand_name);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("succeful addding");
                    Brand_Txtbox.Clear();
                    brand_list.RefreshTable();
                }
                catch
                {
                    MessageBox.Show("Error in Savnig to DB");
                }
                finally { con.Close(); }
            }
            else
            {
                string brand_name = Brand_Txtbox.Text;
                int brand_id = brand_list.Brand_Id;
                string query = "UPDATE Brands SET Brand_Name=@brand_name WHERE Brand_Id=@Id";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@brand_name", brand_name);
                    cmd.Parameters.AddWithValue("@Id", brand_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("succeful updating");
                    Brand_Txtbox.Clear();
                    brand_list.RefreshTable();
                }
                catch
                {
                    MessageBox.Show("Error in Savnig to DB");
                }
                finally { con.Close(); }
            }
        }
        public void Set_Btn_Txt(string name)
        {
            SaveUpdate_Btn.Text = name;
        }

        private void Brand_Details_Load(object sender, EventArgs e)
        {
            if (SaveUpdate_Btn.Text == "UPDATE")
            {
                Brand_Txtbox.Text = brand_list.Brand_Name;
            }
        }

        private void Brand_Txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveUpdate_Btn_Click(sender, e);
            }
        }
    }
}
