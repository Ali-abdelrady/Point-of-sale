using Grocery_Shop.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Vendor_List : UserControl
    {
        //Setter And Getter
        TextboxStyles textboxStyle = new TextboxStyles();
        Vendor vendor = new Vendor();
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
                    Delete_Vendor(vendor_id);
                }
            }
            else if (Vendors_Table.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {

                if (Vendors_Table.Rows.Count > 0)
                {
                    string name = CellValue(3, e);
                    string address = CellValue(4, e); ;
                    string email = CellValue(5, e); ;
                    string phoneNumber = CellValue(6, e); ;
                    int vendor_id = int.Parse(CellValue(2,e));
                    //Set Values To the Obj
                    vendor.Vendor_id = vendor_id;
                    vendor.Vendor_Name = name;
                    vendor.Address = address;
                    vendor.Email = email;
                    vendor.PhoneNumber = phoneNumber;
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
        String CellValue(int index, DataGridViewCellEventArgs e)
        {
           return Vendors_Table.Rows[e.RowIndex].Cells[index].Value.ToString().TrimEnd();  
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
        private void Delete_Vendor(int vendor_id)
        {
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
}
