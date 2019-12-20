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

            Home.home = "ss";
            Room.Window = "3a";
            int x = Room.Value + Coffee.Quality;
            Home.Owner = "c";
            Home.RoomNumber = 87;
            //Room.Count();


            Console.WriteLine("herbata:" + Tea.Name + ", "+ Tea.Price +"\nkawa: "+  Coffee.Quality + ", "+ Coffee.Country );
            Console.WriteLine("");
            Console.WriteLine(x + ", " + Home.home + ", " + Room.Window + ", " + Home.Owner + ", " + Home.RoomNumber + ", "+ Room.Value );
            Room.Count();


            Console.ReadLine();
        }        
    }
}
