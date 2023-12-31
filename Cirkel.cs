﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cirkel : Geometri //Skapar en klass för cirkel som ärver från geometri
    {
        //Egenskaper för cirkeln
        public double Radius { get; set; } 

        //Konstruktor där jag tilldelar cirkelns egenskaper ett fast värde
        public Cirkel()
        {
            Radius = 6.5;
        }

        //Metod som är overridad från Geometriklassen (basklassen)
        public override double Area() 
        {
            return Pi * Pi * Radius; //returnerar uträkningen för cirkelns area
        }
    }
}
