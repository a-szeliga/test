using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phn
{
    public class GraphicCard
    {
        public bool IsValid { get; private set; } = false;
        private int _cores;
        //public GraphicCard(int cores)
        //{
        //    if (cores > 0 && cores < 8 )
        //    {
        //        IsValid = true;
        //    }
        //    _cores = cores;
        //}

        public int Cores
        {
            get
            {
                if (!IsValid)
                {
                    throw new Exception("not valid GraphicCard");
                }
                return _cores; }

            private set
            {
                if (value > 0 && value < 8)
                {
                    IsValid = true;
                }
                _cores = value;
            }
        }
    }
}
