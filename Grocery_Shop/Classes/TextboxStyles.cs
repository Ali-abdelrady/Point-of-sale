using IronSoftware.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Shop.Classes
{
    public class TextboxStyles
    {

        //Methods
        public void Textbox_Enter(TextBox textbox , string text)
        {

            if (textbox.Text == text)
            {
                textbox.Clear();
                textbox.ForeColor = Color.Black;
            }
        }
        public void Textbox_Leave(TextBox textbox, string text)
        {
            if (textbox.Text == "")
            {
                textbox.Text = text;
                textbox.ForeColor = Color.Gray;
            }
        }
        public void PasswordTextBox_Enter(TextBox textbox, string text , char passwordChar)
        {
            if (textbox.Text == text)
            {
                textbox.PasswordChar = passwordChar;
                textbox.Clear();
                textbox.ForeColor = Color.Black;
            }
        }  
        public void PasswordTextBox_Leave(TextBox textbox, string text , char passwordChar)
        {
            if (textbox.Text == "")
            {
                textbox.PasswordChar = passwordChar;
                textbox.Text = text;
                textbox.ForeColor = Color.Gray;
            }
        }
    }
}
