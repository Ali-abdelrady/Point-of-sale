using System.Linq;

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
