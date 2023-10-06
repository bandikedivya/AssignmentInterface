using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    public enum PaymentMode
    {
        cash,
        upi,
        debit,
        credit,
        netbanking
    }

    public class Order : IOperations
    {
        Product[] CartItems = new Product[10];
        private int _orderId;
        private static int cartIndex = 0;
        public int orderId
        {
            get { return _orderId; }
            set { _orderId = value; }
        }
        private DateTime _orderDate;

        public DateTime orderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private PaymentMode _paymode;

        public PaymentMode GetPaymentMode
        {
            get { return _paymode; }
            set { _paymode = value; }
        }

        public void AddToCart(int prodid, string city, int qty, int price)
        {
        }

        public void PaymentGateway(int amt)
        {

        }

        public void BuyNow()
        {

        }

    }
}