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

namespace Grocery_Shop.Cashier
{
    public partial class Order_Void : Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        Cancel_Order _Cancel_Order;
        public Order_Void(Cancel_Order _cancel)
        {
            InitializeComponent();
            _Cancel_Order = _cancel;
        }
        private void login_txtbox_Enter(object sender, EventArgs e)
        {
            if (login_txtbox.Text == " Username")
            {
                login_txtbox.Clear();
                login_txtbox.ForeColor = Color.Black;
            }
        }

        private void login_txtbox_Leave(object sender, EventArgs e)
        {
            if (login_txtbox.Text == "")
            {
                login_txtbox.Text = " Username";
                login_txtbox.ForeColor = Color.Gray;
            }
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            if (password_txtbox.Text == " Password")
            {
                password_txtbox.PasswordChar = '.';
                password_txtbox.Clear();
                password_txtbox.ForeColor = Color.Black;

            }
        }

        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            if (password_txtbox.Text == "")
            {
                password_txtbox.PasswordChar = '\0';
                password_txtbox.Text = " Password";
                password_txtbox.ForeColor = Color.Gray;
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Void_Btn_Click(object sender, EventArgs e)
        {
            string Username, Password;
            Username = login_txtbox.Text;
            Password = password_txtbox.Text;
            try
            {
                con.Open();

                DataTable dt = new DataTable();
                string query = "SELECT * FROM UserAccounts WHERE Username=@Username AND Password=@Password ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    string Role = dt.Rows[0]["Role"].ToString().TrimEnd();
                    if (Role == "Admin")
                    {
                        MessageBox.Show("Ordered Is Canceled");
                        _Cancel_Order.Store_CancelledOrder_Details();
                    }
                    else
                    {
                        MessageBox.Show("The User must be from Admins");
                    }
                }
                else
                {
                    MessageBox.Show("Invaild Username Or Password");
                    login_txtbox.Clear();
                    password_txtbox.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                con.Close();
            }
        }

        private void Order_Void_Load(object sender, EventArgs e)
        {
            login_txtbox.Text = " Username";
            login_txtbox.ForeColor = Color.Gray;
            password_txtbox.PasswordChar = '\0';
            password_txtbox.Text = " Password";
            password_txtbox.ForeColor = Color.Gray;
        }

    }
}
