using Grocery_Shop.Cashier;
using Grocery_Shop.Classes;
using Grocery_Shop.Login;
using IronSoftware.Drawing;
using System;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class login_form : System.Windows.Forms.Form
    {
        private Authenticator _authenticator;
        TextboxStyles textboxStyles = new TextboxStyles();
        public login_form(Authenticator authenticator)
        {
            _authenticator = authenticator;
            InitializeComponent();
        }

        private void login_btn_Click(object sender, System.EventArgs e)
        {
            
            string Username, Password;
            Username=login_txtbox.Text;
            Password=password_txtbox.Text;
            try
            {
                bool isAuthenticated = _authenticator.AuthenticateUser(Username, Password);

                if(isAuthenticated)
                {
                    if (User.Role == "Admin")
                    {
                        this.Hide();
                        Admin form = new Admin();
                        form.Show();
                    }
                    else
                    {
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


        private void login_txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyles.Textbox_Enter(login_txtbox," Username");
        }

        private void login_txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyles.Textbox_Leave(login_txtbox, " Username");
        }

        private void password_txtbox_Enter(object sender, EventArgs e)
        {
            textboxStyles.PasswordTextBox_Enter(password_txtbox, " Password", '.');
        }

        private void password_txtbox_Leave(object sender, EventArgs e)
        {
            textboxStyles.PasswordTextBox_Leave(password_txtbox, " Password", '\0');

        }
    }
}
