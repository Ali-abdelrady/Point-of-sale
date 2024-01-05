﻿using System;
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
    public partial class Category_Details : Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        Category_List category_list;
        public Category_Details(Category_List form )
        {
            InitializeComponent();
            category_list = form;  
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveUpdate_Btn_Click(object sender, EventArgs e)
        {
            if (SaveUpdate_Btn.Text == "SAVE")
            {
                string category_name = Category_Txtbox.Text;
                string query = "INSERT INTO Categories (Category_Name) VALUES(@name)";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", category_name);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("succeful addding");
                    Category_Txtbox.Clear();
                    category_list.RefreshTable();
                }
                catch
                {
                    MessageBox.Show("Error in Savnig to DB");
                }
                finally { con.Close(); }
            }
            else
            {
                string category_name = Category_Txtbox.Text;
                int category_id = category_list.Category_Id;
                string query = "UPDATE Categories SET Category_Name=@category_name WHERE Category_Id=@Id";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@category_name", category_name);
                    cmd.Parameters.AddWithValue("@Id", category_id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("succeful updating");
                    Category_Txtbox.Clear();
                    category_list.RefreshTable();
                }
                catch
                {
                    MessageBox.Show("Error in updatieng to DB");
                }
                finally { con.Close(); }
            }
        }
        public void Set_Btn_Txt(string name)
        {
            SaveUpdate_Btn.Text = name;
        }

        private void Category_Details_Load(object sender, EventArgs e)
        {
            if(SaveUpdate_Btn.Text == "UPDATE")
            {
                Category_Txtbox.Text = category_list.Category_Name;
            }
        }

        private void Category_Txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveUpdate_Btn_Click(sender, e);
            }
        }
    }
}
