using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace OrdersLogger.Classes
{
    public class OrderService
    {

        private readonly OrderDiscount _discount;
        private readonly FileLogger _logger;

        public OrderService(OrderDiscount discount, FileLogger logger)
        {
            _discount = discount;
            _logger = logger;
        }

        public void Add(Order order)
        {
            if (order.ShouldAddDiscount == true)
            {
               // OrderDiscount orderDiscount = new OrderDiscount();
                _discount.CalculateDiscount(order);
            }
         
            string orderJson = JsonConvert.SerializeObject(order);

            using (StreamWriter sw = File.AppendText("orders.txt"))
            {
                sw.WriteLine(orderJson);
            }
                FileLogger fileLogger = new FileLogger();
                _logger.Log("Dodano zlecenie: " + orderJson);

                if (order.ShouldAddDiscount == true)
                {
                    _logger.Log("Rabat wynosił: " + OrderDiscount.Discount);
                }
              
            
        }
        public string GetAll()
        {
            return File.ReadAllText("orders.txt");
        }
     }
}
