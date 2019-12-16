using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StaticEx;
using StaticEx.Classes;

namespace StaticEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea.Name = "Lipton";
            Tea.Price = 5;
            Coffee.Country = "Brazylia";
            Coffee.Quality = 5;

            Console.WriteLine("herbata:" + Tea.Name + ", "+ Tea.Price +"\nkawa: "+  Coffee.Quality + ", "+ Coffee.Country );
        
            Console.ReadLine();
        }        
    }
}
