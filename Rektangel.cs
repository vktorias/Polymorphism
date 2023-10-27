using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rektangel : Geometri
    {
        public int rectangleBase { get; set; }
        public int rectangleHeight { get; set; }

        public Rektangel()
        {
            rectangleBase = 4;
            rectangleHeight = 3;
        }

        public override double Area()
        {
            return rectangleBase * rectangleHeight;
        }
    }
}
