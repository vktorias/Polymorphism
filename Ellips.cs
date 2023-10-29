using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ellips : Geometri
    {
        public double MajorAxis { get; set; } 
        public double MinorAxis { get; set; }
        public Ellips()
        {
            MajorAxis = 8.5;
            MinorAxis = 4.5;
        }

        public override double Area()
        {
            return MajorAxis * MinorAxis * Pi;
        }
    }
}
