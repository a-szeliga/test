using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phn.Models
{
   public  class Processor
    {


        public Processor(string structure)
        {
            Structure = structure;
        }

/*
        private void CalculateSpeed()
        {
            speed = 1000 * 6;
        }

        private void CalculatePower()
        {
            int power =  1000 * 6 * speed;
        }

    */
        public string Structure
        {
            get;
            private set;
        }

        private int speed;

        public int Speed
        {
           //protected
                get { return speed; }
            set
            {
                if (value > 100 && value < 3000)
                {
                    speed = value;
                }
            }
        }
    }
}
