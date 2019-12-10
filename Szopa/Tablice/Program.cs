using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tablice.Classses;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie3.2

            string[,] movies = new string[2, 4]{           
             {"Wielkie piękno" , "Django" , "Podróż czerwonego balonika", "Człowiek z kamerą filmową"},
             { "Juste a la fin du monde", "Ojciec chrzestny","Buena Vista Social Club","Rejs"}         
             };
            

            for (int i = 0; i < movies.GetLength(0); i++)
            {               
                for (int j = 0; j < movies.GetLength(1); j++)
                { 
                    Console.WriteLine(movies[i, j]);                   
                }
            }
           
            Console.ReadLine();

            

            //zadanie3.2 v.1

            
            string[,] films;
            films = new string[2,4];
            films[0,0] = "Wielkie piękno";
            films[0,1] = "Django";
            films[0,2] = "Podróż czerwonego balonika";
            films[0,3] = "Człowiek z kamerą filmową";
            films[1,0] = "Juste a la fin du monde";
            films[1,1] = "Ojciec chrzestny";
            films[1,2] = "Buena Vista Social Club";
            films[1,3]= "Rejs";
 

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <4; j++)
                {
                    Console.WriteLine(films[i,j]);
                }
            }
            Console.ReadLine();


            //zadanie3.1
            Filtr f1 = new Filtr();
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

            Filtr f4 = new Filtr();
            f4.Logic = "po";
            f4.Item = new FiltrItem() {Field = "bar",Value = "ack" };
            

            //string[] Filtr = new string [3]{};
            Filtr[] tablica;
            tablica = new Filtr[4];
            tablica[0] = f1;
            tablica[1] = f2;
            tablica[2] = f3;
            tablica[3] = f4;

            for (int y = 0; y < tablica.Length; y++)
            {
                Console.WriteLine(tablica[y].Logic);
                Console.WriteLine(tablica[y].Item.Value);
                Console.WriteLine(tablica[y].Item.Field);
                Array.Reverse(tablica);
            }
            Console.ReadLine();
            
        }
    }
}
