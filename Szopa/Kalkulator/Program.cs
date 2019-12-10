using Kalkulator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie kalkulator.");

            Console.WriteLine("Podaj pierwszą liczbę do obliczeń:");
            string x = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę do obliczeń:");
            string y = Console.ReadLine();

            Console.WriteLine("Co chciałbyś zrobić z tymi liczbami, podaj liczbę odpowiadającą operacji:" +
                "\n1 - Dodawanie" +
                "\n2 - Mnożenie" + "\n3 - Dzielenie bez przecinków" + "\n4 - Modulo " + "\n5 - Dzielenie z przecinkiem" + "\n");

            string inputedValue = Console.ReadLine();
            Calc calculation = new Calc();
            calculation.Calculate(x,y,inputedValue);

            Console.WriteLine("Press any key to contiue...");
            Console.ReadLine();
        }
    }
}
