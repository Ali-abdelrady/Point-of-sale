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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Grocery_Shop
{
    public partial class UserAccount_Form : UserControl
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public UserAccount_Form()
        {
            InitializeComponent();
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            string username=Create_Username_txtbox.Text;
            string password = Create_Password_Txtbox.Text;
            string confirm = Password_Confimation_Txtbox.Text;
            string role=Role_Combox.GetItemText(Role_Combox.SelectedItem);
            
            try
            {
                if(password == confirm)
                {
                    string query = "INSERT INTO UserAccounts (Username,Password,Type) VALUES (@username,@password,@role)";
                    con.Open();
                    SqlCommand cmd=new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
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
               Create_Username_txtbox.Clear();
               Create_Password_Txtbox.Clear();
                New_Password_Txtbox.Clear();
               Password_Confimation_Txtbox.Clear();
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            string username = Current_Username_Txtbox.Text;
            string password = Current_Password_Txtbox.Text;
            string new_password = New_Password_Txtbox.Text;
            string confirm = Confirm_NewPassword_Txtbox.Text;
            DataTable dt=new DataTable();
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
                        SqlCommand cmd2= new SqlCommand(query, con);

                        cmd2.Parameters.AddWithValue("@new_password",new_password);
                        cmd2.Parameters.AddWithValue("@username",username);
                        cmd2.Parameters.AddWithValue("@password",password);
                        cmd2.ExecuteNonQuery();

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

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            string username = Deleted_Username_Txtbox.Text;
            string password = Deleted_Password_Txtbox.Text;
            DataTable dt = new DataTable();
            try
            {

                string query = "SELECT Username,Password FROM UserAccounts WHERE Username=@username AND Password=@password";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    con.Close();
                    con.Open();
                    query = "DELETE FROM UserAccounts WHERE Username='" + username + "' AND Password='" + password + "' ";
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("This is user doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Error on Delete Account");
            }
            finally
            {
                con.Close();
                Deleted_Username_Txtbox.Clear();
                Deleted_Password_Txtbox.Clear();
            }
        }

        private void UserAccount_Form_Load(object sender, EventArgs e)
        {
            Search_Txtbox.Text = " Search here";
            Search_Txtbox.ForeColor = Color.Gray;
        }
        private void Search_Txtbox_Enter(object sender, EventArgs e)
        {
            if (Search_Txtbox.Text == " Search here")
            {
                Search_Txtbox.Clear();
                Search_Txtbox.ForeColor = Color.Black;
            }
        }

        private void Search_Txtbox_Leave(object sender, EventArgs e)
        {
            if(Search_Txtbox.Text == "")
            {
                Search_Txtbox.Text= " Search here";
                Search_Txtbox.ForeColor = Color.Gray;
            }
        }

        private void Search_Txtbox_TextChanged(object sender, EventArgs e)
        {
            try
            {    
                string name=Search_Txtbox.Text;
                DataTable dt = new DataTable();
                string query = "SELECT \r\n e.Emp_Id AS ID ,\r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS NAME ,\r\ne.Address AS ADDRESS ,\r\ne.Email AS EMAIL,\r\ne.Phone_Number AS PHONE_NUMBER,\r\ne.Salary AS SALARY,\r\nu.Username AS USERNAME ,\r\nu.Password AS PASSWORD\r\nFROM Employees AS e \r\nINNER JOIN UserAccounts AS u ON e.User_Id=u.User_Id\r\n WHERE RTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name)  LIKE '%" + name+"%' ";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
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

        private void Load_InvetoryList_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt=new DataTable();
                string query = "SELECT \r\n e.Emp_Id AS ID , \r\nRTRIM(e.First_Name)+' '+RTRIM(e.Middle_Name)+' '+RTRIM(e.Last_Name) AS NAME ,\r\ne.Address AS ADDRESS ,\r\ne.Email AS EMAIL,\r\ne.Phone_Number AS PHONE_NUMBER,\r\ne.Salary AS SALARY,\r\nu.Username AS USERNAME ,\r\nu.Password AS PASSWORD\r\nFROM Employees AS e \r\nINNER JOIN UserAccounts AS u ON e.User_Id=u.User_Id;";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                User_Table.DataSource= dt;
            }
            catch
            {
                MessageBox.Show("Error in fill the user table");
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
                        /*string combinedQuery =""*/
                        DataGridViewRow row = User_Table.Rows[e.RowIndex];
                        int emp_id = int.Parse(row.Cells[1].Value.ToString());
                        string username = row.Cells[7].Value.ToString();
                        string password = row.Cells[8].Value.ToString();
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

                }
            }
        }
    }

}

