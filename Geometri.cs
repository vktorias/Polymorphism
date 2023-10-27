using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Geometri //Skapar en abstrakt klass för Geometri
    {
        public abstract double Area(); //Skapar en abstrakt metod för Area som alla subklasser kommer ärva
    }
}