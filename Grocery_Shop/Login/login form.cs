using Grocery_Shop.Cashier;
using IronSoftware.Drawing;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class login_form : System.Windows.Forms.Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public login_form()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, System.EventArgs e)
        {
            
            string Username, Password;
            Username=login_txtbox.Text;
            Password=password_txtbox.Text;
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
                if(dt.Rows.Count > 0)
                {
                       
                    string Role = dt.Rows[0]["Role"].ToString().TrimEnd();
                    Global.User_Id= int.Parse(dt.Rows[0]["User_Id"].ToString());
                    if (Role == "Admin")
                    {
                        Global.Role = "Admin";
                        this.Hide();
                        Admin form = new Admin();
                        form.Show();
                    }
                    else
                    {
                        Global.Role = "Cashier";
                        this.Hide();
                        Cashier_Mainform form = new Cashier_Mainform();
                        form.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Invaild Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                con.Close() ;
            }
        }

        private void exit_btn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void login_form_Load(object sender, System.EventArgs e)
        {
            login_txtbox.Text = " Username";
            login_txtbox.ForeColor = Color.Gray;
            password_txtbox.PasswordChar = '\0';
            password_txtbox.Text = " Password";
            password_txtbox.ForeColor = Color.Gray;
        }

        private void user_account_icon_Click(object sender, System.EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
