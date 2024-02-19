using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop.Classes
{
    public class Validations
    {
        public bool Is_Empty(string str)
        {
            return str.Length == 0;
        }
        public bool Is_Numeric(string str)
        {
            return str.All(char.IsDigit);
        }
    }
}
