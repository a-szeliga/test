using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Classes
{
    public class Car
    {
        //zmienne punliczne z duzej should be: public Engine Engine;
        public Engine engine;
        public Wheels wheels;
        public Body body;
        public Mechanics mechanics;


        public double CalculateMaxSpeed()
        {
            //double speed1 = (engine.Power * (double)wheels.Count) / (body.Length - 1);
            //double speed2 = engine.Power * wheels.Count * 2 / (body.Length - 1);
            double speed;
            //double maxSpeed;
            //var maxSpeed = CalculateMaxSpeed();
           // if (engine != null && wheels != null) ;
            if (body.IsSedan == true)
            {
                //return speed1;
                return speed = (engine.Power * (double)wheels.Count) / (body.Length - 1);
            }
            if (body.IsHatchback)
            {
                //return speed2; 
                return speed = engine.Power * wheels.Count * 2 / (body.Length - 1);
            }

            //returm naxSpeed;
            return 0;

        }
        public void Display()
        {
            Console.WriteLine("course: " + engine.Course + "\npower: " + engine.Power
                + "\nwheels: " + wheels.Count +
                "\ncolor:" + body.Color + "\nhatchback: "
                + body.IsHatchback + "\nsedan: "
                + body.IsSedan + "\nlength: " + body.Length);
            CalculateMaxSpeed();
            Console.WriteLine("max speed: " + CalculateMaxSpeed() + "\n");
        }
    }

    public class Engine
    {
        public double Power;
        public string Course;
    }

    public class Wheels
    {
        public int Count;
    }

    public class Body
    {
        public string Color;
        public bool IsSedan;
        public bool IsHatchback;
        public double Length;
    }

    public class Mechanics
    {
        public void Go()
        {
            Console.WriteLine("Ruszaj");
        }

        public void Stop()
        {
            Console.WriteLine("Zatrzymaj");
        }
    }
}
