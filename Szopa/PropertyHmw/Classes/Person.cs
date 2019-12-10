using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyHmw.Classes
{
    /* public class Person

     {
         private int age;

         public int GetAge()
         {
             return age;
         }

         public void DisplayAge(int Age)
         {
             //Console.WriteLine("wiek: " + age);
             age = Age;
         }

     }
     */
    public class Person
    {

        private string name = Console.ReadLine();

        public string Name
        {
            get
            { return name; }
            
        }


        private string age = Console.ReadLine();
       // private int old = Convert.ToInt32(age);
     
        
        
    
  

        public void Display()
        {
            Console.WriteLine("Imię: " + name);
            Console.WriteLine("Wiek: " + age);
        }

    }



}

