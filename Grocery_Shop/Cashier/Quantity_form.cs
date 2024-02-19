using Grocery_Shop.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Grocery_Shop
{
    public partial class Quantity_form : Form
    {
        int quantity;
        Cashier_Mainform cashier_form;
        Product product;
        int currentQuantity;
        public Quantity_form(Cashier_Mainform f, Product p ,int qty)
        {
            InitializeComponent();
            cashier_form = f;
            product = p;
            currentQuantity = qty;
        }

        private void quantity_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Number_Validation(quantity_txtbox.Text))
                {
                    quantity = int.Parse(quantity_txtbox.Text);
                    if(quantity > product.Cur_Amount - currentQuantity)
                    {
                        MessageBox.Show("The quantity you ask for is not available for this product The Cuurent Amount is" + (product.Cur_Amount - currentQuantity));
                        quantity_txtbox.Clear();
                    }
                    else
                    {
                        
                        this.Hide();
                        cashier_form.AddTo_Purchases_Table(quantity);
                    }

                }
                else
                {
                    MessageBox.Show("Erorr You Have To Enter A Numeric Number");
                    quantity_txtbox.Clear();
                }
            }
        }
        private bool Number_Validation(string num)
        {
            if(num.Length == 0)
            {
                return false;
            }
            int i = 0;
            while (i < num.Length)
            {
                if (!char.IsDigit(num[i]))
                { 
                    return false;
                }
                i++;
            }
            return true;
        }

        private void quantity_txtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
