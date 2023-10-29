using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Fyrkant : Geometri
    {
        public int SquareSide { get; set; }

        public Fyrkant()
        {
            SquareSide = 10;
        }
        public override double Area()
        {
            return SquareSide * SquareSide;
        }
    }
}
