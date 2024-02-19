using Grocery_Shop.Classes;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using MySql.Simple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Grocery_Shop
{
    public partial class Vendor_Details : Form
    {
        //Database Connection
        private SqlConnection con;


        Vendor_List vendor_form =new Vendor_List();
        Vendor vendor = new Vendor();
        public Vendor_Details(Vendor_List f,Vendor v)
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            vendor_form = f;
            vendor = v;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Save_Update_Btn_Click(object sender, EventArgs e)
        {
            int id = vendor.Vendor_id;
            string vendor_name = Name_Txtbox.Text;
            string address = Address_Textbox.Text;
            string email = Email_Txtbox.Text;
            string phone_number = Number_TxtBox.Text;
            
            if(vendor_name.Length == 0 || address.Length == 0 || email.Length == 0 || phone_number.Length == 0)
            {
                MessageBox.Show("Fill The Empty Boxes");
            }
            else if(phone_number.Any(char.IsLetter) || phone_number.Length != 11)
            {
                MessageBox.Show("Phone Number Can't Have Letters And Must Be 11 Characters");
                Email_Txtbox.Clear();
            }
            else
            {
                //Check 
                if (Save_Update_Btn.Text == "SAVE")
                {
                    SaveVendors(vendor_name, address, email, phone_number);
                }
                else
                { 
                    UpdateVendors(id,vendor_name, address, email, phone_number);
                }
                vendor_form.LoadVendorTable();
            }
        }
        public void Change_Btn_Text(String name)
        {
            Save_Update_Btn.Text = name;
        }
        private void Vendor_Details_Load(object sender, EventArgs e)
        {
            if (Save_Update_Btn.Text == "UPDATE")
            {
                Load_Vendor_Details();
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Load_Vendor_Details()
        { 
            Name_Txtbox.Text = vendor.Vendor_Name.TrimEnd();
            Address_Textbox.Text = vendor.Address.TrimEnd();
            Email_Txtbox.Text = vendor.Email.TrimEnd();
            Number_TxtBox.Text = vendor.PhoneNumber.TrimEnd();
        }
        void Clear_TextBoxes()
        {
            Name_Txtbox.Clear();
            Address_Textbox.Clear();
            Email_Txtbox.Clear();
            Number_TxtBox.Clear();
        }
        void SaveVendors(string vendor_name, string address, string email, string phone_number)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Vendors (Name,Address,Email,PhoneNumber) VALUES (@Name,@Address,@Email,@PhoneNumber)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", vendor_name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phone_number);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucssfuly added");
                Clear_TextBoxes();
            }
            catch
            {
                MessageBox.Show("Error in inserting vendors details");
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateVendors(int id,string vendor_name, string address, string email, string phone_number)
        {
            try
            {
                string query = "UPDATE Vendors SET  Name=@Name , Address=@Address , Email=@Email , PhoneNumber=@Phone_Number WHERE Vendor_Id=@Id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", vendor_name);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone_Number", phone_number);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully Updated ");
                Clear_TextBoxes();
            }
            catch
            {
                MessageBox.Show("Error in Update Database");
            }
            finally
            {
                con.Close();
            }
        }

    }
}
