using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ellips : Geometri
    {
        public double majorAxis { get; set; } 
        public double minorAxis { get; set; }
        public double pi { get; set; }
        public Ellips()
        {
            majorAxis = 7.5;
            minorAxis = 4;
            pi = 3.14;
        }

        public override double Area()
        {
            return majorAxis * minorAxis * pi;
        }
    }
}
