using System;

namespace AbstractFactory
{
    class NogNiets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            VormFactory vormFactory = new VormFactory();
            IVorm vormA = vormFactory.GetVorm("Cirkel");
            vormA.Teken();
        }
    }
}
