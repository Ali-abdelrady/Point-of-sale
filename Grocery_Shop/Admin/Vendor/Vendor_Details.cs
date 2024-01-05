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
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);

        Vendor_List vendor_form=new Vendor_List();
        Vendor vendor = new Vendor();
        public Vendor_Details(Vendor_List f,Vendor v)
        {
            vendor_form = f;
            vendor = v;
            InitializeComponent();            
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Clear_TextBoxes()
        {
            Name_Txtbox.Clear();
            Address_Textbox.Clear();
            Email_Txtbox.Clear();
            Number_TxtBox.Clear();
        }

        private void Save_Update_Btn_Click(object sender, EventArgs e)
        {
            int id = vendor.Vendor_id;
            string vendor_name = Name_Txtbox.Text;
            string address = Address_Textbox.Text;
            string email = Email_Txtbox.Text;
            string phone_number = Number_TxtBox.Text;
            if (Save_Update_Btn.Text == "SAVE")
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
            else
            { 
                try
                {
                    string query = "UPDATE Vendors SET  Name=@Name , Address=@Address , Email=@Email , PhoneNumber=@Phone_Number WHERE Vendor_Id=@Id";
                    con.Open();
                    SqlCommand cmd= new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id",id);
                    cmd.Parameters.AddWithValue("@Name",vendor_name);
                    cmd.Parameters.AddWithValue("@Address",address);
                    cmd.Parameters.AddWithValue("@Email",email);
                    cmd.Parameters.AddWithValue("@Phone_Number",phone_number);
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
            vendor_form.LoadVendorTable();
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
        void Load_Vendor_Details()
        { 
            Name_Txtbox.Text = vendor.Vendor_Name.TrimEnd();
            Address_Textbox.Text = vendor.Address.TrimEnd();
            Email_Txtbox.Text = vendor.Email.TrimEnd();
            Number_TxtBox.Text = vendor.PhoneNumber.TrimEnd();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
