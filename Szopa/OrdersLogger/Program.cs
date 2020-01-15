using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OrdersLogger.Classes;

namespace OrdersLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order ("Zakup ciągnika ", 2000.0, true);
            Order order2 = new Order("Zakup walca ", 3000.0, false);
            Order order3 = new Order("Zakup glebogryzarki", 80.0, true);

            OrderDiscount discount = new OrderDiscount();

            FileLogger fileLogger = new FileLogger();
            OrderService orderService = new OrderService(discount, fileLogger);


            orderService.Add(order1);
            orderService.Add(order2);
            orderService.Add(order3);

            Console.WriteLine(orderService.GetAll());
            Console.WriteLine(fileLogger.ReadLogs());

            Console.ReadLine();
        }
    }
}

