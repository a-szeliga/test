using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFirst.Classes
{
    class DivisionFirst
    {
        public void Calc(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0.");
            }
            else
            {
                Console.WriteLine("Wynik: " + (x /y));
            }
        }

    }
}
