using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop.Classes
{
    public class SoldItem_Details : Product
    {
        private int transaction_id;
        private float discount;
        private decimal total;
        private int quantity;

        public SoldItem_Details()
        {
            transaction_id = 0;
            discount = 0;
            total = 0;
            quantity = 0;
        }
        public int Transaction_Id
        {
            set { transaction_id = value; }
            get { return transaction_id; }
        }
        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public int Quantity
        {
           get {return quantity; }
           set { quantity = value; }
        }
    }
}
