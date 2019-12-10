using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Basics.Models;


namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
  /*          Filtr f1 = new Filtr();
            f1.Logic = "x";
            FiltrItem fi1 = new FiltrItem();
            fi1.Field = "y";
            fi1.Value = "c";
            f1.Item = fi1;

            Filtr f2 = new Filtr();
            f2.Logic = "dr";
            FiltrItem fi2 = new FiltrItem();
            fi2.Value = "kr";
            fi2.Field = "sr";
            f2.Item = fi2;

            Filtr f3 = new Filtr();
            f3.Logic = "baa";
            FiltrItem fi3 = new FiltrItem();
            fi3.Value = "raa";
            fi3.Field = "saa";
            f3.Item = fi3;

           //f3.Item = new FiltrItem() {Field = "",Value - "" };

            // string[] Filtr = new string [3]{};
            Filtr[] tablica;
            tablica = new Filtr [3];
            tablica[0] = f1;
            tablica[1] = f2;
            tablica[2] = f3;
            //tablica[3] = f3;

            for (int i =0; i< tablica.Length; i++)
            {
                Console.WriteLine(tablica[i].Logic);
                Console.WriteLine(tablica[i].Item);
            }
            Console.ReadLine();





/*
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
                    //

            }


 /*           //

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

            //
            //enum - Cars {Audi,Opel}  / case Cars.Audi

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

            List<string> 
            {
                11,22,33,88
            };

            //

            List<int> list = new List<int>()
            {
                11,22,33,88
            };


            foreach (int elementKolekcji in list)
            {
                Console.WriteLine(elementKolekcji);
            }
           /* for (int = 0, int < List.Count; int++)

            { Console.WriteLine (List [1])}*/
            //



            Glass bootle1 = new Glass(name: "Butelka", color: "Biała");


            Glass bootle2 = new Glass(name: "Butla", color: "Zielona");

            Beer bottle1 = new Beer(color: "Green");
            Beer bottle2 = new Beer(color: "Red");

            Rower bike1 = new Rower(name: "Stary");
            Rower bike2 = new Rower(name: "Nowy", model: 3);
            Rower bike3 = new Rower(name: " mały ", color: "żółty ", model: 1);


            Bmx bmx = new Bmx();

            Kalkulator licznik = new Kalkulator();

            Licznik letnik = new Licznik();


            bottle1.WriteLine();
            bottle2.WriteLine();
            bike1.Start();
            bike2.Stop();
            bike3.Write();
            bmx.Drive(name: "Rowerek", time: 5, color: "Red");
            bmx.Drive(5, "Rowerek", "Red");
            licznik.Wylicz(5,10);

            letnik.LataLicz();

            int i = 1;
            int y = 2;
            i = y;
            y = 3;

            Console.WriteLine(bootle1.Name, bootle1.Color);
            Console.WriteLine(bootle2.Name, bootle2.Color);
            Console.WriteLine(i);
            Console.WriteLine(y);
            Console.WriteLine();
       
            Console.ReadLine();
        }
    }
}
