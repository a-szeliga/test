using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Vehicle
    {
        private int Time;

        public Vehicle(int time)
        {
            Time = time;
        }

       public void Drive()
        {
            Console.WriteLine("Jedziemy przez " + Time + "minut");
        }
    }
}
