using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Parallellogram : Geometri
    {
        public int parallelogramBase { get; set; }
        public int parallelogramHeight { get; set; }

        public Parallellogram()
        {
            parallelogramBase = 5;
            parallelogramHeight = 4;
        }

        public override double Area()
        {
            return parallelogramBase * parallelogramHeight;
        }
    }

}
