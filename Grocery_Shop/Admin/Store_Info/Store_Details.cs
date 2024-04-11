using Grocery_Shop.Classes;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grocery_Shop
{
    public partial class Store_Details : Form
    {
        //Database Connection
        private SqlConnection con;
        public Store_Details()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
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
            Get_StoreDetails();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            string storeName = StoreName_Txtbox.Text.ToString();
            string phoneNumber = PhoneNumber_Txtbox.Text.ToString();
            string address = Address_Txtbox.Text.ToString();
            if (Is_Empty(storeName, phoneNumber, address))
            {
                MessageBox.Show("Fill All Empty Boxes");
            }
            else if (phoneNumber.Any(char.IsLetter))
            {
                MessageBox.Show("The Phone Number Must Be A Numric Value");
            }
            else if (phoneNumber.Length != 11)
            {
                MessageBox.Show("The Phone Number Must Be 11 Digits ");
            }
            Update_StoreDetails();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Update_StoreDetails()
        {
            string store_name = StoreName_Txtbox.Text;
            string address = Address_Txtbox.Text;
            string phone_number = PhoneNumber_Txtbox.Text;
            try
            {
                con.Open();
                string query = "UPDATE Store_Details SET Name=@store_name, Address=@address ,Phone_Number=@phone_number WHERE Store_Id=1";
                SqlCommand cmd = new SqlCommand(query, con);
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
        void Get_StoreDetails()
        {
            try
            {
                con.Open();
                string query = "SELECT Name,Address,Phone_Number FROM Store_Details";
                SqlCommand cmd = new SqlCommand(query, con);
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
        bool Is_Empty(string storeName, string phoneNumber, string address)
        {
            return storeName.Length == 0 || storeName.Length == 0 || storeName.Length == 0 || storeName.Length == 0;
        }
    }
}
