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
    public partial class Change_Password : Form
    {
        static string sql = "Data Source =ALIABDERADY\\SQLEXPRESS01; Initial Catalog=Shop; Integrated Security=True; User ID=''; Password = ''";
        SqlConnection con = new SqlConnection(sql);
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            string password = Password_Txtbox.Text.TrimEnd();
            string confirmation = Confirmation_Txtbox.Text.TrimEnd();
            if (password == confirmation)
            {
                try
                {
                    string query = "UPDATE UserAccounts SET Password=@password WHERE User_Id=@user_id";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@user_id", Global.User_Id);
                }
                catch
                {
                    MessageBox.Show("Error on updating password ");
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Password don't match");
            }

        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_Txtbox_Enter(object sender, EventArgs e)
        {
            if (Password_Txtbox.Text == " New Password")
            {
                Password_Txtbox.Clear();
                Password_Txtbox.ForeColor = Color.Black;
            }
        }

        private void Password_Txtbox_Leave(object sender, EventArgs e)
        {
            if (Password_Txtbox.Text == "")
            {
                Password_Txtbox.Text = " New Password";
                Password_Txtbox.ForeColor = Color.Gray;
            }
        }

        private void Confirmation_Txtbox_Enter(object sender, EventArgs e)
        {
            if (Confirmation_Txtbox.Text == " Confirm New Password")
            {
                Confirmation_Txtbox.Clear();
                Confirmation_Txtbox.ForeColor = Color.Black;
            }
        }

        private void Confirmation_Txtbox_Leave(object sender, EventArgs e)
        {
            if (Confirmation_Txtbox.Text == "")
            {
                Confirmation_Txtbox.Text = " Confirm New Password";
                Confirmation_Txtbox.ForeColor = Color.Gray;
            }
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            Password_Txtbox.Text = " New Password";
            Password_Txtbox.ForeColor = Color.Gray;
            Confirmation_Txtbox.Text = " Confirm New Password";
            Confirmation_Txtbox.ForeColor = Color.Gray;
        }
    }
}
