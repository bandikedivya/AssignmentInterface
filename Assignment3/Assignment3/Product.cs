using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Product
    {
        private int _ProductId;

        public int ProductId
        {
            get { return _ProductId; }
            set { _ProductId = value; }
        }

        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        private int _Qty;
        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }
        private int _Price;
        public int Price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}