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
        public Quantity_form(Cashier_Mainform f, Product p)
        {
            InitializeComponent();
            cashier_form = f;
            product = p;
        }

        private void quantity_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Number_Validation(quantity_txtbox.Text))
                {
                    quantity = int.Parse(quantity_txtbox.Text);
                    if(quantity > product.Cur_Amount)
                    {
                        MessageBox.Show("The quantity you ask for is not available for this product The Cuurent Amount is" + product.Cur_Amount);
                        quantity_txtbox.Clear();
                    }
                    else
                    {
                        float total = quantity * product.Price;
                        this.Hide();
                        cashier_form.AddTo_Purchases_Table(product.Product_Name, product.Price, quantity, total);
                    }

                }
                else
                {
                    MessageBox.Show("Erorr You Have To Enter A Numeric Number");
                    quantity_txtbox.Clear();
                }
            }
        }
        bool Number_Validation(string num)
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
    }
}
