using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    class Beer

    {
        public Beer(string color)
        {
            Color = color;
        }
        private string Color;

        public void WriteLine()
        {
            Console.WriteLine("Jedna butelka: " + Color );
        }
    }
}
