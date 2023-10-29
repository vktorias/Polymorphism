using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rektangel : Geometri
    {
        public int RectangleBase { get; set; }
        public int RectangleHeight { get; set; }

        public Rektangel()
        {
            RectangleBase = 4;
            RectangleHeight = 3;
        }

        public override double Area()
        {
            return RectangleBase * RectangleHeight;
        }
    }
}
