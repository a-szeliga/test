using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Classes;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Parrot p1 = new Parrot();
            p1.FlyAway();
            Horse h1 = new Horse();
            h1.BiteParrot();

            Animal an2 = new Parrot();
            an2.Move(1);


            Cat c = new Cat();

            //c.AnimalType = AnimalType.Cat;
            c.Sit();
            c.Jump();

            Dog d = new Dog();
            d.Move(7);
            d.Jump();

            Animal[] type = new Animal[2];
            type[0] = c;
            type[1] = d;

            for (int i = 0; i < type.Length; i++)
            {
                // if(type[i].AnimalType==AnimalType.Dog)
                Console.WriteLine(AnimalType.Cat);
                Console.WriteLine(AnimalType.Dog);
            }
        
    
            Console.ReadLine();

            Audi a1 = new Audi();
           
            a1.Engine = "v8";
            a1.Body = "red";
            a1.Wheels = 4;
            a1.Name = "nazwa";
            a1.Start(5);



            Console.ReadLine();

            Book test = new ProfessionalBook();
            test.Cover = true;
            test.Page = 657;
            test.Title = "Selenium";
            test.Buy();
            test.Read();
            

            Console.ReadLine();
        }
    }
}
