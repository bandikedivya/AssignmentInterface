using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IOperation
    {
        void AddToCart(int prodid, string city, int qty, int price);
        void PaymentGateway(int amt);
        void BuyNow();
    }
}
