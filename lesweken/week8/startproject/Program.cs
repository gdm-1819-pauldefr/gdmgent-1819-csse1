using System;

namespace startproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Aanmaken van producten
            Product p1 = new Product();
            p1.Naam = "Cola";
            Product.ProductType pt1 = Product.ProductType.Drank;
            p1.Type = pt1;

            Prijs prijs1 = new Prijs();
            prijs1.Waarde = "3";
            prijs1.Val = Prijs.Valuta.EUR;

            MenuItem mi1 = new MenuItem();
            mi1.Item = p1;
            mi1.Waarde = prijs1;

            Console.WriteLine(mi1.ToString());
            Product p2 = new Product();
            p2.Naam = "Fanta";
            Product.ProductType pt2 = Product.ProductType.Drank;
            p2.Type = pt2;

            Prijs prijs2 = new Prijs();
            prijs2.Waarde = "3";
            prijs2.Val = Prijs.Valuta.EUR;

            MenuItem mi2 = new MenuItem();
            mi2.Item = p2;
            mi2.Waarde = prijs2;

            
            Console.WriteLine(mi2.ToString());
            Console.WriteLine(p2.BerekenKCal().ToString());

            Snack s = new Snack();
            Console.WriteLine(s.BerekenKCal().ToString());
            Drank d = new Drank();
            Console.WriteLine(d.BerekenKCal().ToString());

        }
    }
}
