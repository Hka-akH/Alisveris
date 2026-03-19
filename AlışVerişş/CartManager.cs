using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışVerişş
{
    public class CartManager
    {
        private Cart _cart = new Cart();
        public void AddProduct(Product product)
        {
            _cart.AddProduct(product);
        }



        public static CartManager _instance;
        public static readonly object _lock = new object();

        public Cart Cart { get; private set; }

        private CartManager()
        {
            Cart = new Cart();
        }

        public static CartManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)

                        _instance = new CartManager();
                    return _instance;
                }
            }
        }
            public void RemovePrudoct(Product product)
        {
            Cart.Products.Remove(product);
        }
    }
}
    





    




