using System;

namespace deel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persoon p1 = new Persoon();
            Console.WriteLine(p1.GenereerWachtwoord());

            Student s1 = new Student();
            Console.WriteLine(s1.GenereerWachtwoord());
        }
    }
}