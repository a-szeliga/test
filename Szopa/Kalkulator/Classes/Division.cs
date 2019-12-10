using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.Classes
{
    public class Division
    {
        public void Calc(int x, int y)
        {
            if (y > 0)
            {
            Console.WriteLine("Wynik: " + (x / y));                
            }
            else
            {
                Console.WriteLine("Nieprawidłowa wartość drugiej liczby, nie można wykonać operacji.");
            }                    
        }
    }
}
