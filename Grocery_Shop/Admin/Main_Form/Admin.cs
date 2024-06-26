﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Grocery_Shop.Login;
using Grocery_Shop.Classes;
using Grocery_Shop.Cashier;

namespace Grocery_Shop
{
    public partial class Admin : Form
    {
        //Database Connection
        private SqlConnection con;

        Authenticator authenticator = new Authenticator();
        public Admin()
        {
            InitializeComponent();
            con = DatabaseManger.CreateConnection();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dashboard2.Visible = true;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            userAccount_Form1.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
            Button_Event_Handler();
        }

        private void dashborad_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Dashboard_Load(sender, e);
            dashboard2.Visible = true;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;

        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            dashboard2.Visible = false;
            //productList_Form1.Visible=true;
            productList_Form2.Visible = true;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            userAccount_Form1.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;

        }

        private void Brand_Btn_Click(object sender, EventArgs e)
        {
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = true;
            userAccount_Form1.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
            dashboard2.Visible = false;

        }

        private void Category_Btn_Click(object sender, EventArgs e)
        {
            productList_Form2.Visible = false;
            category_List2.Visible = true;
            brand_List2.Visible = false;
            userAccount_Form1.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
            dashboard2.Visible = false;

        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form log = new login_form(authenticator);
            log.Show();
        }

        private void User_Btn_Click(object sender, EventArgs e)
        {
            userAccount_Form1.Visible = true;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
            dashboard2.Visible = false;

        }
        private void StockEntry_Btn_Click(object sender, EventArgs e)
        {
            stockEntry_Form2.Visible = true;
            //stockEntry_Form2
            stockEntry_Form2.Fill_ComboBox();
            userAccount_Form1.Visible = false;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
            dashboard2.Visible = false;

        }


        private void Records_Btn_Click(object sender, EventArgs e)
        {
            records_Form2.Records_Form_Load(sender,e);
            stockEntry_Form2.Visible = false;
            userAccount_Form1.Visible = false;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            records_Form2.Visible = true;
            vendor_List1.Visible = false;
            dashboard2.Visible = false;

        }

        private void Vendor_Btn_Click(object sender, EventArgs e)
        {
            vendor_List1.Visible = true;
            stockEntry_Form2.Visible = false;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            records_Form2.Visible = false;
            dashboard2.Visible = false;
            userAccount_Form1.Visible = false;
        }

        private void StoreDetails_Btn_Click(object sender, EventArgs e)
        {
            Store_Details form=new Store_Details();
            form.ShowDialog();
        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }


        private void Left_Frame_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                button.BackColor = System.Drawing.Color.FromArgb(23, 167, 255);
            }
        }

        private void Left_Frame_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = System.Drawing.Color.FromArgb(40,45,50);
            }
        }
        private void Button_Event_Handler()
        {
            //DashBoard
            Dashborad_Btn.MouseEnter += Left_Frame_MouseEnter;
            Dashborad_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Product
            Product_Btn.MouseEnter += Left_Frame_MouseEnter;
            Product_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Vendor
            Vendor_Btn.MouseEnter += Left_Frame_MouseEnter;
            Vendor_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Brand
            Brand_Btn.MouseEnter += Left_Frame_MouseEnter;
            Brand_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Category
            Category_Btn.MouseEnter += Left_Frame_MouseEnter;
            Category_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Stock Entry
            StockEntry_Btn.MouseEnter += Left_Frame_MouseEnter;
            StockEntry_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Records                                       
            Records_Btn.MouseEnter += Left_Frame_MouseEnter;
            Records_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Sales History                                       
            SalesHistory_Btn.MouseEnter += Left_Frame_MouseEnter;
            SalesHistory_Btn.MouseLeave += Left_Frame_MouseLeave;

            //Store details
            StoreDetails_Btn.MouseEnter += Left_Frame_MouseEnter;
            StoreDetails_Btn.MouseLeave += Left_Frame_MouseLeave;

            //UserAccounts
            User_Btn.MouseEnter += Left_Frame_MouseEnter;
            User_Btn.MouseLeave += Left_Frame_MouseLeave;
            //Logout
            Logout_Btn.MouseEnter += Left_Frame_MouseEnter;
            Logout_Btn.MouseLeave += Left_Frame_MouseLeave;
        }

        private void stockEntry_Form2_Load(object sender, EventArgs e)
        {

        }
/*        void Set_Forms_Sizes()
        {
            dashboard2.Width = 1241;
            dashboard2.Height = 1100;
            productList_Form2.Visible = false;
            category_List2.Visible = false;
            brand_List2.Visible = false;
            userAccount_Form1.Visible = false;
            stockEntry_Form2.Visible = false;
            records_Form2.Visible = false;
            vendor_List1.Visible = false;
        }*/

        private void SalesHistory_Btn_Click(object sender, EventArgs e)
        {
            Daily_Sales daily_Sales = new Daily_Sales();
            daily_Sales.ShowDialog();
        }
    }
}
