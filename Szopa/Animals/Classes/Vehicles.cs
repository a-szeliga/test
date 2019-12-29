using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Classes
{
    public abstract class Vehicle
    {
        public virtual int Wheels { get; set; }
        public string Engine { get; set; }

        public abstract void Start(int distance);
        public abstract string Body { get; set; }

    }

    public class Audi : Vehicle
    {
        public string Model;
        public string Name;

        public override string Body { get; set; }

        public override void Start(int distance)
        {

            Console.WriteLine("dystans: " + distance);
            Console.WriteLine("koła: " + base.Wheels);
            Console.WriteLine("silnik: " + base.Engine);
            Console.WriteLine("body: " + Body);
            Console.WriteLine("nazwa: " + Name);
        }

    }
}
