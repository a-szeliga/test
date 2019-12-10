using CalculatorFirst.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w programie kalkulator.");


            Console.WriteLine("Podaj pierwszą liczbę:");
            string x = Console.ReadLine();
            int input1 = Convert.ToInt32(x);

            Console.WriteLine("Podaj drugą liczbę:");
            string y = Console.ReadLine();
            int input2 = Convert.ToInt32(y);

            Console.WriteLine("Co chciałbyś zrobić z tymi liczbami, podaj liczbę odpowiadającą operacji:" +
                "\n1 - Dodawanie" +
                "\n2 - Mnożenie" + "\n3 - Dzielenie bez przecinków" + "\n4 - Modulo " + "\n5 - Dzielenie z przecinkiem" + "\n");


            string inputedValue = Console.ReadLine();
            int input3 = Convert.ToInt32(inputedValue);
            
                        switch (input3)
                        {
                            case 1:
                                AdditionFirst add = new AdditionFirst();
                                add.Calc(input1,input2);                   
                                break;
                            case 2:
                                MultiplictionFirst multiplicate = new MultiplictionFirst();
                                multiplicate.Calc(input1,input2);              
                                break;
                            case 3:
                                DivisionFirst divide = new DivisionFirst();
                                divide.Calc(input1,input2);
                                break;
                            case 4:
                                ModuloFirst mod = new ModuloFirst();
                                mod.Calc(input1,input2);                 
                                break;
                            case 5:
                                DivisionFloatFirst floatDivide = new DivisionFloatFirst();
                                floatDivide.Calc(input1, input2);                 
                                break;
                            default:
                                Console.WriteLine("Something go wrong, try again. " );
                                break;                   
                        }
            
            Console.WriteLine("Press any key to contiue...");
            Console.ReadLine();
        }
    }
}
