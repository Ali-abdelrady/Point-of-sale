using Grocery_Shop.Classes;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using MySql.Simple;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Color = System.Drawing.Color;

namespace Grocery_Shop
{
    public partial class UserAccount_Form : UserControl
    {
        //Database Connection
        private SqlConnection con;
        TextboxStyles textboxStyle = new TextboxStyles();
        public UserAccount_Form()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection(); 
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            //Get Data From Textboxes
            string first_name = firstName_Textbox.Text.ToString();
            string mid_name = MidName_Textbox.Text.ToString();
            string last_name = LastName_Textbox.Text.ToString();
            string address = Address_Textbox.Text.ToString();
            string salary = Salalry_Textbox.Text.ToString();
            string phoneNumber = Phone_Textbox.Text.ToString();
            string username=Create_Username_txtbox.Text.ToString();
            string password = Create_Password_Txtbox.Text.ToString();
            string confirm = Password_Confimation_Txtbox.Text.ToString();
            string role=Role_Combox.GetItemText(Role_Combox.SelectedItem).ToString();
            
            if(Is_Empty(first_name,mid_name,last_name,address,salary,phoneNumber,username, password, confirm))
            {
                MessageBox.Show("Fill All Empty Boxes");
            }
            else if(salary.Any(char.IsLetter) || phoneNumber.Any(char.IsLetter))
            {
                MessageBox.Show("The Salary And Number Must Be A Numric Value");
            }
            else if(phoneNumber.Length != 11 )
            {
                MessageBox.Show("The Phone Number Must Be 11 Digits ");
            }
            else
            {
                CreateAccount(first_name,mid_name,last_name,address,float.Parse(salary),phoneNumber,username, password, confirm, role);
            }

        }
     

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            //Get Data From Textboxes
            string username = Current_Username_Txtbox.Text.ToString();
            string password = Current_Password_Txtbox.Text.ToString();
            string new_password = New_Password_Txtbox.Text.ToString();
            string confirm = Confirm_NewPassword_Txtbox.Text.ToString();

            if(Is_Empty(username,password,new_password,confirm))
            {
                MessageBox.Show("Fill All Empty Boxes");
            }
            else
            {
                UpdateAccount(username, password,new_password, confirm);
            }
        }


        private void UserAccount_Form_Load(object sender, EventArgs e)
        {
            Load_UserList();
            Role_Combox.SelectedIndex = 0;
            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;
        }
        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Enter(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyle.Textbox_Leave(Search_Txtbox, " Search here");
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            Load_UserList();
        }
        void Load_UserList()
        {
            try
            {
                string name = Search_Txtbox.Text.ToString();
                DataTable dt = new DataTable();
                string query1 = "SELECT \r\n e.Emp_Id AS ID ,\r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS NAME ,\r\ne.Address AS ADDRESS ,\r\ne.Phone_Number AS PHONE_NUMBER,\r\ne.Salary AS SALARY,\r\nu.Username AS USERNAME ,\r\nu.Password AS PASSWORD\r\nFROM Employees AS e \r\nINNER JOIN UserAccounts AS u ON e.Emp_Id=u.Emp_Id\r\n WHERE RTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name)  LIKE '%" + name + "%' ";
                string query2 = "SELECT \r\n e.Emp_Id AS ID ,\r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS NAME ,\r\ne.Address AS ADDRESS ,\r\ne.Phone_Number AS PHONE_NUMBER,\r\ne.Salary AS SALARY,\r\nu.Username AS USERNAME ,\r\nu.Password AS PASSWORD\r\nFROM Employees AS e \r\nINNER JOIN UserAccounts AS u ON e.Emp_Id=u.Emp_Id";
                string res_query = (name == " Search here") ? query2 : query1;
        
                con.Open();
                SqlCommand cmd = new SqlCommand(res_query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                User_Table.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("ERORR");
            }
            finally
            {
                con.Close();
            }
        }


        private void User_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (User_Table.Columns[e.ColumnIndex].DataPropertyName == "DELETE")
            {
                if (User_Table.Rows.Count > 0)
                {
                    var res= MessageBox.Show("Any transcation this user made will be deleted from all tables ", "Title", MessageBoxButtons.OKCancel);
                    if(res == DialogResult.OK)
                    {
                        DataGridViewRow row = User_Table.Rows[e.RowIndex];
                        int emp_id = int.Parse(row.Cells[1].Value.ToString());
                        string username = row.Cells[6].Value.ToString();
                        string password = row.Cells[7].Value.ToString();
                        DeleteAccount(emp_id,username,password,e);
                    }

                }
            }
        }
        void Clear_Textboxes()
        {
            Create_Username_txtbox.Clear();
            Create_Password_Txtbox.Clear();
            New_Password_Txtbox.Clear();
            Password_Confimation_Txtbox.Clear();
            firstName_Textbox.Clear();
            MidName_Textbox.Clear(); ;
            LastName_Textbox.Clear();
            Address_Textbox.Clear();
            Salalry_Textbox.Clear();
            Phone_Textbox.Clear();
        }
        void CreateAccount(string first_name, string mid_name, string last_name, string address, float salary, string phoneNumber, string username, string password, string confirm, string role)
        {
            
            try
            {
                if (password == confirm)
                {
                    //Insert Data Of employee
                    string query = "INSERT INTO Employees (First_Name,Middle_Name,Last_Name,Salary,Address,Phone_Number) VALUES (@First_Name,@Middle_Name,@Last_Name,@Salary,@Address,@Phone_Number);INSERT INTO UserAccounts (Emp_Id,Username,Password,Role) VALUES ((SELECT @@IDENTITY ),@username,@password,@role);";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@First_Name", first_name);
                    cmd.Parameters.AddWithValue("@Middle_Name", mid_name);
                    cmd.Parameters.AddWithValue("@Last_Name", last_name);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Phone_Number", phoneNumber);
                    cmd.ExecuteNonQuery();
                    Clear_Textboxes();
                    Load_UserList();
                    MessageBox.Show("Successful Adding ");
                }
                else
                {
                    MessageBox.Show("No Matching Paswwords");
                }
            }
            catch
            {
                MessageBox.Show("Error On Adding ");
            }
            finally
            {
                con.Close();
            }
        }
        void UpdateAccount(string username , string password , string  new_password,string confirm)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT Username,Password FROM UserAccounts WHERE Username=@username AND Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (new_password == confirm)
                    {
                        con.Close();
                        con.Open();
                        query = "UPDATE UserAccounts SET Password=@new_password WHERE Username=@username AND Password=@password";
                        SqlCommand cmd2 = new SqlCommand(query, con);

                        cmd2.Parameters.AddWithValue("@new_password", new_password);
                        cmd2.Parameters.AddWithValue("@username", username);
                        cmd2.Parameters.AddWithValue("@password", password);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Successful Updated");
                        Load_UserList();

                    }
                    else
                    {
                        MessageBox.Show("password isn't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                else
                {
                    MessageBox.Show("Invaild Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                con.Close();
                Current_Username_Txtbox.Clear();
                Current_Password_Txtbox.Clear();
                New_Password_Txtbox.Clear();
                Password_Confimation_Txtbox.Clear();
            }
        }
        void DeleteAccount(int emp_id,string username, string password , DataGridViewCellEventArgs e)
        {
            /*string combinedQuery =""*/

            try
            {
                string query = "DELETE FROM Employees WHERE Emp_Id=@emp_id";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@emp_id", emp_id);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                User_Table.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Deleted Successfully");
                Load_UserList();
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
        bool Is_Empty(string first_name, string mid_name, string last_name, string address, string  salary, string phoneNumber, string username, string password, string confirm)
        {
            return first_name.Length == 0 || mid_name.Length == 0 || last_name.Length == 0 || address.Length == 0 || salary.Length == 0 || phoneNumber.Length == 0 || username.Length == 0 || password.Length == 0 || confirm.Length == 0 ;
        }
        bool Is_Empty(string username, string password,string new_password ,string confirm)
        {
            return username.Length == 0 || password.Length == 0 || confirm.Length == 0 || new_password.Length == 0;
        }
    }

}

