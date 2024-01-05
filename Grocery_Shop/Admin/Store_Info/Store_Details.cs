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
    public partial class Store_Details : Form
    {
        //Database Connection
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public Store_Details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Store_Details_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT Name,Address,Phone_Number FROM Store_Details";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    StoreName_Txtbox.Text = reader.GetString(0).TrimEnd();
                    Address_Txtbox.Text = reader.GetString(1).TrimEnd();
                    PhoneNumber_Txtbox.Text = reader.GetString(2).TrimEnd();

                }
            }
            catch
            {
                MessageBox.Show("Error in loading store_details");
            }
            finally
            {
                con.Close();
            }
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            string store_name = StoreName_Txtbox.Text;
            string address = Address_Txtbox.Text;
            string phone_number = PhoneNumber_Txtbox.Text;
            try
            {
                con.Open();
                string query = "UPDATE Store_Details SET Name=@store_name, Address=@address ,Phone_Number=@phone_number WHERE Store_Id=1";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@store_name", store_name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone_number", phone_number);
                cmd.ExecuteNonQuery();
                StoreName_Txtbox.Clear();
                Address_Txtbox.Clear();
                PhoneNumber_Txtbox.Clear();
                MessageBox.Show("Updated Sucessfully");
            }
            catch
            {
                MessageBox.Show("Error in update store details");
            }
            finally
            {
                con.Close();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
