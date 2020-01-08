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
        private readonly OrderDiscount discount;
        private readonly FileLogger logger;

        public OrderService(OrderDiscount Discount, FileLogger Logger)
        {
            FileLogger logger = Logger;
            OrderDiscount discount = Discount;
        }
        public void Add(Order order)
        {
            if (order.ShouldAddDiscount == true)
            {
                OrderDiscount orderDiscount = new OrderDiscount();
                orderDiscount.CalculateDiscount(order);
            }

            string orderJson = JsonConvert.SerializeObject(order);
            File.AppendText("orders.txt");
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Dodano zlecenie: " + orderJson);

            if (order.ShouldAddDiscount == true)
            {
                fileLogger.Log("Rabat wynosił: " + OrderDiscount.Discount);
            }

        }

        public void GetAll(string message)
        {
            File.ReadAllText("orders.txt");
        }


        //string json = JsonConvert.Serialize(TextBlock.Text);
        // TextBlock.Text = json;


        /* string path = txtFilePath.Text;

         if (!File.Exists(path))
         {
             using (StreamWriter sw = File.CreateText(path))
             {
                 foreach (var line in employeeList.Items)
                 {
                     sw.WriteLine(((Employee)line).FirstName);
                     sw.WriteLine(((Employee)line).LastName);
                     sw.WriteLine(((Employee)line).JobTitle);
                 }
             }
         }
         else
         {
             StreamWriter sw = File.AppendText(path);

             foreach (var line in employeeList.Items)
             {
                 sw.WriteLine(((Employee)line).FirstName);
                 sw.WriteLine(((Employee)line).LastName);
                 sw.WriteLine(((Employee)line).JobTitle);
             }
             sw.Close();
         }*/
        //  Order.Serialize 

    }

       


}

/*  public class OrderService
    {
       // OrderDiscount orderDiscount = new OrderDiscount();
        public readonly OrderDiscount Discount;
        public readonly FileLogger Logger;
       

        public OrderService(OrderDiscount discount, FileLogger logger)
        {
            Discount = discount;
            logger = Logger;
        }

        public void Add(Order order)
        {
           

            if(order.ShouldAddDiscount==true)
            {
                OrderDiscount orderDiscount = new OrderDiscount();
                orderDiscount.CalculateDiscount(order);           
            }
          
            string orderJson= JsonConvert.SerializeObject(order);
            File.AppendText("orders.txt");
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Dodano zlecenie: " + orderJson);

            if (order.ShouldAddDiscount == true)
            {
                fileLogger.Log("Rabat wynosił: " + OrderDiscount.Discount);
            }

        }
      
    }
}
*/