using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop
{
    public class Product
    {
        private int id;
        private string product_name;
        private string barcode;
        private string brand;
        private string category;
        private float price;
        private int cur_amount;
        public Product()
        {
            id = 0;
            product_name = string.Empty;
            barcode = string.Empty;
            brand = string.Empty;
            category = string.Empty;
            price = 0;
            cur_amount = 0;
        }
        public int Product_Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Product_Name
        { 
            set { product_name = value; }
            get { return product_name; }
        } 
        public string Barcode
        { 
            set { barcode = value; }
            get { return barcode; }
        }
        public string Brand
        { 
            set { brand = value; }
            get { return brand; }
        }
        public string Category
        { 
            set { category = value; }
            get { return category; }
        }
        public float Price
        { 
            set { price = value; }
            get { return price; }
        }
        public int Cur_Amount
        { 
            set { cur_amount = value; }
            get { return cur_amount; }
        }

    }
}
