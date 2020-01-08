using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLogger.Classes
{
    public class OrderDiscount
    {
        public static double Discount = 0.20;        

        public Order CalculateDiscount(Order order)
        {
            order.Price = order.Price * Discount;          
            return order;           
        }
    }
}

