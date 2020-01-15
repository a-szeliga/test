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

        private readonly OrderDiscount Discount;
        private readonly FileLogger Logger;

        public OrderService(OrderDiscount discount, FileLogger logger)
        {
            Discount = discount;
            Logger = logger;
        }

        public void Add(Order order)
        {
            if (order.ShouldAddDiscount == true)
            {
                OrderDiscount orderDiscount = new OrderDiscount();
                orderDiscount.CalculateDiscount(order);
            }

           
            string orderJson = JsonConvert.SerializeObject(order);
            File.WriteAllText("orders.txt", orderJson);
            
            using (StreamWriter sw = File.AppendText("orders.txt"))
            {
                FileLogger fileLogger = new FileLogger();


                fileLogger.Log("Dodano zlecenie: " + orderJson);

                if (order.ShouldAddDiscount == true)
                {
                    fileLogger.Log("Rabat wynosił: " + OrderDiscount.Discount);
                }
                sw.Close();
            }
        }
        public string GetAll()
        {
            return File.ReadAllText("orders.txt");
        }
     }
}
