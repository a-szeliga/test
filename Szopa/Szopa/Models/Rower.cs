using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Rower
    {
        public Rower(string name)
        {
            Name = name;
        }


        public Rower(string name, int model)

        {
            Name = name;
            Model = model;
        }

        public Rower(string name, string color, int model)

        {
            Name = name;
            Color = color;
            Model = model;
        }


        private string Name;
        private string Color;
        private int Model;


        public void Start()
        {
            Console.WriteLine("Jedziemy " + Name);          
        }

        public void Stop()
        {
            Console.WriteLine("Stop! " + Name + " " + Model);
        }

        public void Write()
        {
            Console.WriteLine("Trzeci rower" + Name + ", " + Color + " model " + Model);
        }
    }

   
}
