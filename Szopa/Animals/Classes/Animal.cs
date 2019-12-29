using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
   public enum AnimalType
    { Cat, Dog}

    public class Animal
    {

        
        public void Move( int distance)
        {
           Console.WriteLine("Zwierzę ma przejść " + distance + " m.");
        }

        public void Sit()
        {
            Console.WriteLine("Zwierzę usiadło.");
        }

        protected void Stand()
        {
            Console.WriteLine("Zwierzę stoi.");
        }
    }
    public class Cat : Animal
    {
        public void Jump()
        {
            Console.WriteLine(" Skoczył kot.");
            base.Stand();
         
        }
    }
    public class Dog : Animal
    {
        public void Jump()
        {
            Console.WriteLine(" Skoczył pies.");
            base.Sit();

        }
    }
    public class Parrot : Animal
    {
        public void FlyAway()
        {
            Console.WriteLine("Papuga odleciała.");
            base.Stand();
            Sit();
            Move(5);
        }
    }

    public class Horse : Animal
    {
        public void BiteParrot()
        {
            Console.WriteLine("\nKoń ugryzł papugę.");
            Sit();
            Move(11);
            base.Stand();
            
           
        }
    }

  

}
