﻿using Grocery_Shop.Cashier;
using System;
using System.Windows.Forms;

namespace Grocery_Shop
{
    public partial class Discount_Form : Form
    {
        public int Row_Index { get; set; }
        public float Total_Price { get; set; }
        Cashier_Mainform cashier_form;
        public Discount_Form(Cashier_Mainform form)
        {
            InitializeComponent();
             cashier_form=form;
        }
        private void Discount_Form_Load(object sender, EventArgs e)
        {
            TotalPrice_lbl.Text = Total_Price.ToString();
        }

        private void Discount_txtbox_TextChanged(object sender, EventArgs e)
        {  try
            {
                float discount;
                if (Discount_txtbox.Text==" ")
                {
                    discount = 0;
                }
                else
                {
                    discount = float.Parse(Discount_txtbox.Text) / 100;
                }
                DiscAmount_lbl.Text=(discount*Total_Price).ToString();
            }
            catch 
            {
                MessageBox.Show("Error in Discount_txtbox");
            }
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if(Discount_txtbox.Text.Length == 0)
            {

                MessageBox.Show("Fill The Empty Box");

            }
            else
            {
                this.Hide();
                float discount_amount = float.Parse(DiscAmount_lbl.Text);
                float total_discount = float.Parse(TotalPrice_lbl.Text) - discount_amount;
                cashier_form.SetProductDiscount(Row_Index, discount_amount, total_discount);
            }
        }
    }
}
