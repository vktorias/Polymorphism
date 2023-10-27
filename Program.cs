using System.Security.Cryptography.X509Certificates;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Geometriska figurers area **"); //Skriver ut i början av programmet
            Console.WriteLine(); //Skapar en tom rad
            Cirkel cirkel = new Cirkel(); //Skapar en ny cirkel och tilldelar den ett namn
            Console.WriteLine("Cirkelns area: " + cirkel.Area() + " cm2"); //Skriver ut och anropar metoden Area för cirkeln
            Fyrkant fyrkant = new Fyrkant(); //Skapar en ny fyrkant och tilldelar den ett namn
            Console.WriteLine("Fyrkantens area: " + fyrkant.Area() + " cm2"); //Skriver ut och anropar metoden Area för fyrkanten
            Rektangel rektangel = new Rektangel(); //Skapar en ny rektangel och tilldelar den ett namn
            Console.WriteLine("Rektangelns area: " + rektangel.Area() + " cm2"); //Skriver ut och anropar metoden Area för rektangeln
            Parallellogram parallellogram = new Parallellogram(); //Skapar ett nytt parallellogram och tilldelar den ett namn
            Console.WriteLine("Parallelogramets area: " + parallellogram.Area() + " cm2"); //Skriver ut och anropar metoden Area för parallellogramet
            Ellips ellips = new Ellips(); //Skapar en ny ellips och tilldelar den ett namn
            Console.WriteLine("Ellipsens area: " + ellips.Area() + " cm2"); //Skriver ut och anropar metoden Area för ellipsen
        }
    }
}