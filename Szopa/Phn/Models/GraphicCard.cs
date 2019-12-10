using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phn
{
    public class GraphicCard
    {
        private int cores;
        public GraphicCard(int _cores)
        {
            cores = _cores;
        }

        public int Cores
        { get { return cores; }

         //   private set { }
        }

    }
}
