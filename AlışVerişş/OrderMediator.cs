using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışVerişş
{
    internal class OrderMediator : IOrderMediator
    {
        public void AddProduct(Product product)
        {
            CartManager.Instance.Cart.AddProduct(product);
        }
        public void MakePayment(int paymentType)
        {
            decimal total = CartManager.Instance.Cart.GetTotalPrice();

            IPayment payment;

            if (paymentType == 1)
                payment = new CrediCardPayments();
            else
                payment = new CashPayments();

            payment.Pay(total);
        }
    }


}
