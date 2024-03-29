﻿using Grocery_Shop.Classes;
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
    public partial class Vendor_List : UserControl
    {
        //Setter And Getter
        Vendor vendor=new Vendor();
        TextboxStyles textboxStyle = new TextboxStyles();
        //Database Connection
        private SqlConnection con;
        public Vendor_List()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
            LoadVendorTable();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Vendor_Details Form = new Vendor_Details(this,vendor);
            Form.Change_Btn_Text("SAVE");
            Form.ShowDialog();
        }

        private void Search_Txtbox_Click(object sender, EventArgs e)
        {
            Search_Txtbox.Clear();
        }
        public void LoadVendorTable()
        {
            try
            {
                con.Open();
                DataTable dt=new DataTable();
                string vendor_name = Search_Txtbox.Text;
                string query1 = "SELECT * FROM Vendors WHERE Name  LIKE '%" + vendor_name + "%'";
                string query2 = "SELECT * FROM Vendors ";
                string res_query = (vendor_name == " Search here") ? query2 : query1;
                SqlCommand cmd =new SqlCommand(res_query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                Vendors_Table.DataSource = dt;  
            }
            catch
            {
                MessageBox.Show("Error in Load Vendor Table");
            }
            finally
            {
                con.Close();
            } 
        }

        private void Vendors_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Vendors_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Vendors_Table.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                if (Vendors_Table.Rows.Count > 0)
                {
                    int vendor_id = int.Parse(Vendors_Table.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //Delete Row From Table
                    Vendors_Table.Rows.RemoveAt(e.RowIndex);

                    //Delete From The Database Table  
                    string query = "DELETE FROM Vendors Where Vendor_Id=@Id";
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", vendor_id);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Error in Deleting at Vendors Table ");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else if (Vendors_Table.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {

                if (Vendors_Table.Rows.Count > 0)
                {
                    int vendor_id = int.Parse(Vendors_Table.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd());
                    //Set Values To the Obj
                    vendor.Vendor_id = vendor_id;
                    vendor.Vendor_Name = Get_Cell_Value(3, e);
                    vendor.Address = Get_Cell_Value(4, e);
                    vendor.Email= Get_Cell_Value(5, e);
                    vendor.PhoneNumber= Get_Cell_Value(6, e);
                    //open the form
                    Vendor_Details Form = new Vendor_Details(this,vendor);
                    Form.Change_Btn_Text("UPDATE");
                    Form.ShowDialog(this);
                }
            }
        }
        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {

            textboxStyle.Textbox_Leave(Search_Txtbox, " Search here");
        }
        String Get_Cell_Value(int index, DataGridViewCellEventArgs e)
        {
           return Vendors_Table.Rows[e.RowIndex].Cells[index].Value.ToString();  
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            LoadVendorTable();
        }

        private void Vendor_List_Load(object sender, EventArgs e)
        {
            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;
        }
    }
}
