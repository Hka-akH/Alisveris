using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlışVerişş
{
    public interface IOrderMediator
    {
        void AddProduct(Product product);
        void MakePayment(int paymentType);
    }
}
