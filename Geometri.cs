using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Geometri //Skapar en abstrakt klass för Geometri
    {
        public const double Pi = Math.PI; //Skapar en konstant variabel som är en double med namnet Pi och tilldelar den värdet med hjälp av Math.PI klassen
    
    
        public abstract double Area(); //Skapar en abstrakt metod för Area som alla subklasser ärver
    }
}