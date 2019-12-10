using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.Classes
{
    class DivisionFloat
    {
        public void Calc(int x, int y)
        {
            float xx =  Convert.ToSingle(x);
            float yy = Convert.ToSingle(y);
            if (yy == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0.");
            }
            else
            {
                Console.WriteLine("Wynik: " + (xx/yy));
            }
        }

    }
}
