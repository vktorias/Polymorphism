using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Parallellogram : Geometri
    {
        public int ParallelogramBase { get; set; }
        public int ParallelogramHeight { get; set; }

        public Parallellogram()
        {
            ParallelogramBase = 5;
            ParallelogramHeight = 4;
        }

        public override double Area()
        {
            return ParallelogramBase * ParallelogramHeight;
        }
    }

}
