using System;

namespace opdracht4
{
    class MenuItem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
        public class Product
        {
        private string naam;
        private string type;
        
        public Product(string typeEnum, string productName)
        {
            type = typeEnum;
            naam = productName;
        }
        
        // Remaining implementation of MenuItem class.
        }


        public class Price
        {
        private string naam2;
        private string valuta;
        
        public Price(string typeValuta, string productPrice)
        {
            valuta = typeValuta;
            naam2 = productPrice;
        }
        
        // Remaining implementation of Price class.
        }

   
        //Welke klasse is de subklasse? Welke de basisklasse?
        // De subklasse is product en de basisklasse is MenuItem
        //Als je een sortering zou uitvoeren op de elementen van de lijst hoe zou dit dan implementeren?
    }
}
