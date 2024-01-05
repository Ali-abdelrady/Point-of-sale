using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop
{
    public class Vendor 
    {   
        private int id;
        private string vendor_name;
        private string address;
        private string email;
        private string phone_number;

        public Vendor()
        {
            id = 0;
            vendor_name = "";
            address= "";
            Email= "";
            phone_number = "";
        }
        public Vendor(int id,string name, string address, string Email, string Phone_Number)
        {
            this.id = id;
            this.vendor_name = name;

            this.address = address;
            this.Email = Email; 
            this.phone_number = Phone_Number;
        }
        public int Vendor_id
        {
            get { return id; }
            set { id = value; }
        }
        public string Vendor_Name
        {
            get { return vendor_name; }
            set => vendor_name = value;
        }
        public string Address
        {
            get { return address; }
            set => address = value;
        }
        public string Email
        {
            get { return email; }
            set => email = value;
        }
        public string PhoneNumber
        {
            get { return phone_number; }
            set => phone_number = value;
        }
    }
}
