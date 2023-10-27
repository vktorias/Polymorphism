using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Fyrkant : Geometri
    {
        public int squareSide { get; set; }

        public Fyrkant()
        {
            squareSide = 10;
        }
        public override double Area()
        {
            return squareSide * squareSide;
        }
    }
}
