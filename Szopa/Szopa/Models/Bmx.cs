using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basics.Models
{
    class Bmx
    {
        public Bmx()
        {
        }

        public void Drive(int time, string name, string color)
        {
            Console.WriteLine( "Mój rower o nazwie " + name + " i kolorze " +color +". Jedziemy przez " + time + " minut.");
            Vehicle v1 = new Vehicle(time);
            v1.Drive();
        }
    }
}
