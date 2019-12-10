using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    class Kalkulator
    { 
        public void Wylicz( float x, float y)
        {
            float z = (x + y) / 2;
            Console.WriteLine("Wynik (5 + 10)/2= " +z);
        }
    }
}
