using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışVerişş
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if(obj is not  Product other) return false;
            return Name == other.Name && Price == other.Price;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
