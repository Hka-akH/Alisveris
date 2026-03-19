using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışVerişş
{
    internal class CartManager
    {
        private static CartManager _instance;
        private static readonly object _lock = new object();

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




    }



}
