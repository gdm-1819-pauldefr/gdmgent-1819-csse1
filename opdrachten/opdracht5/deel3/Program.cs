using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 5 - Deel 3: DB Connect");

            DbConnect db1 = DbConnect.Instance();
            DbConnect db2 = DbConnect.Instance();

            if(db1 == db2) {
                Console.WriteLine("Both connections are the same instance.");
            }
        }
    }
}