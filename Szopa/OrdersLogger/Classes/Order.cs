using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace OrdersLogger.Classes
{
    public class Order
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool ShouldAddDiscount { get; set; }

        public Order(string name, double price, bool shouldAddDiscount)
        {
            Name = name;
            Price = price;
            ShouldAddDiscount = shouldAddDiscount;
        }
    }
}
