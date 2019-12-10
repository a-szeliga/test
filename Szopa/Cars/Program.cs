using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.Classes;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {       
            Car c1 = new Car();           
            Engine ce1 = new Engine {Course = "xyx", Power = 100};
            Wheels cw1 = new Wheels {Count = 4};
            Body cb1 = new Body { Color = "niebieski", IsHatchback = true, IsSedan = false, Length = 1000};            
            c1.engine = ce1;
            c1.wheels = cw1;
            c1.body = cb1;         


            Car c2 = new Car();
            Engine ce2 = new Engine { Course = "sws", Power = 800 };
            Wheels cw2 = new Wheels { Count = 5 };
            Body cb2 = new Body { Color = "biały", IsHatchback = true, IsSedan = false, Length = 100 };
            c2.engine = ce2;
            c2.wheels = cw2;
            c2.body = cb2;



            Car c3 = new Car();
            Engine ce3 = new Engine { Course = "wtf", Power = 800 };
            Wheels cw3 = new Wheels { Count = 7 };
            Body cb3 = new Body { Color = "czarny", IsHatchback = false, IsSedan = false, Length = 400 };
            c3.engine = ce3;
            c3.wheels = cw3;
            c3.body = cb3;           


            Car[]tab = new Car [3];
            tab[0]=c1;
            tab[1]=c2;
            tab[2]=c3;
            
            for (int i = 0; i< tab.Length; i++)
            {
                tab[i].Display();
                              
            };
            Console.ReadLine();

            Console.WriteLine("Wybierz samochód: c1 , c2 lub c3:");
            string input = Console.ReadLine();

            switch (input)
            {
                case "c1":
                    Console.WriteLine("marka: c1");
                    c1.Display();
                    break;
                case "c2":
                    Console.WriteLine("marka: c2");
                    tab[1].Display();
                    break;
                case "c3":
                    Console.WriteLine("marka: c3");
                    tab[2].Display();
                    break;
                default:
                   Console.WriteLine("There is no data.");
                    break;       
            }
            Console.ReadLine();            
        }
    }
}
