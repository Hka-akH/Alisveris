using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AlışVerişş
{
    public class Cart
    {
        public List<Product> Products {  get; set; } = new List<Product>();
        

        public void AddProduct(Product product)
        {
            Products.Add(product);
            Console.WriteLine($"{product.Name} Sepete Eklendi ");
        }
        public decimal GetTotalPrice()
        {
            return Products.Sum(p => p.Price);
        }
    }
}
