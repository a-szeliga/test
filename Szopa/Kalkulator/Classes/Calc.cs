using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.Classes
{
    public class Calc
    {

        public void Calculate(string x, string y, string inputedValue)
        {
            int input1 = Convert.ToInt32(x);
            int input2 = Convert.ToInt32(y);
            int input3 = Convert.ToInt32(inputedValue);

            switch (input3)
            {
                case 1:
                    Addition add = new Addition();
                    add.Calc(input1, input2);
                    break;
                case 2:
                    Multipliction multiplicate = new Multipliction();
                    multiplicate.Calc(input1, input2);
                    break;
                case 3:
                    Division divide = new Division();
                    divide.Calc(input1, input2);
                    break;
                case 4:
                    Modulo mod = new Modulo();
                    mod.Calc(input1, input2);
                    break;
                case 5:
                    DivisionFloat floatDivide = new DivisionFloat();
                    floatDivide.Calc(input1, input2);
                    break;
                default:
                    Console.WriteLine("Something go wrong, try again. ");
                    break;
            }
        }
    }
}
