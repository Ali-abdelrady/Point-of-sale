using Grocery_Shop.Classes;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Grocery_Shop.Cashier
{
    public partial class Change_Password : Form
    {
        //Database Connection
        private SqlConnection con;
        TextboxStyles textboxStyles = new TextboxStyles();
        public Change_Password()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
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
                    cmd.Parameters.AddWithValue("@user_id", User.Emp_Id);
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
            textboxStyles.Textbox_Enter(Password_Txtbox," New Password");

        }

        private void Password_Txtbox_Leave(object sender, EventArgs e)
        {

            textboxStyles.Textbox_Leave(Password_Txtbox," New Password");
        }

        private void Confirmation_Txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyles.Textbox_Enter(Confirmation_Txtbox, " Confirm New Password");
        }

        private void Confirmation_Txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyles.Textbox_Leave(Confirmation_Txtbox, " Confirm New Password");
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
