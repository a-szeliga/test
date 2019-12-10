using System;
using Loops.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dostępne produkty: mleko, chleb, cukier. \nAby dodać mleko wybierz 1, chleb - wybierz 2, cukier - wybierz 3");
            string input = Console.ReadLine();
            int produkt = Convert.ToInt32(input);

            switch (produkt)
            {
                case 1:
                    Milk milk = new Milk();
                    milk.AddToCart();
                    break;
                case 2:
                    Bread bread = new Bread();
                    bread.AddToCart();
                    break;
                default:
                    Console.WriteLine("Wybrany produkt nie istnieje ");
                    break;
            }

            //if
            int x = 5;
            if (x == 1)
            {
                Console.WriteLine("1");
            }
            else if (x == 2)
            {
                Console.WriteLine("2");
            }

            else if (x == 3)
            {
                Console.WriteLine("3");
            }

            else if (x == 4)
            {
                Console.WriteLine("4");
                Console.WriteLine("4");
                Console.WriteLine("4");
            }
            //default
            else
            {
                Console.WriteLine("Nic nie zostało wybrane");
            }


            if (x < 5)
            {
                Console.WriteLine("<5");
            }
            else if (x > 5)
            {
                Console.WriteLine(">5");
            }
            //default
            else
            {
                Console.WriteLine("Nic nie zostało wybrane");
            }        

            int z = 11;
            switch (z)
            {
                case 1:
                    Plus plus = new Plus();
                    plus.Add(5, 6);
                    break;

                case 2:
                    Minus minus = new Minus();
                    minus.Subtract(10, 3);
                    break;

                default:

                    Console.WriteLine("Brak");
                    break;
            }
            

            List<int> numList = new List<int>()
            {
                11,22,33,88
            };

            for (int i = 0; i < numList.Count(); i++)
            {
                Console.WriteLine(numList[1]);
            }

            //list of strings
            List<string> elementKolekcji = new List<string>()
            {
                "string","spring","sphinx","bring"
            };


            //list of strings          
           foreach (string e in elementKolekcji)
           {
               Console.WriteLine(e);
           }

            Console.ReadLine();

            //tab of int
            int[] tab = {1,2,3,7,9};

            foreach (int y in tab)
            {
                Console.WriteLine(y);
            }

            Console.ReadLine();

            //tab of strings

            string[] dong = { "ping", "pong", "strong" };
            foreach (string d in dong)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
