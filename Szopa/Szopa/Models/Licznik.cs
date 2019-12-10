using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    class Licznik

    {
        public void LataLicz()
        {
            Console.WriteLine("Podaj rok urodzenia + [Enter]: ");
            string birthdate = Console.ReadLine();
            Console.WriteLine("Podaj bieżący rok + [Enter]: ");
            string currentdate = Console.ReadLine();
            int age = Convert.ToInt32(currentdate)- Convert.ToInt32(birthdate);
            
            Console.WriteLine("Masz " + age + " lat." );
        }
    }
}
