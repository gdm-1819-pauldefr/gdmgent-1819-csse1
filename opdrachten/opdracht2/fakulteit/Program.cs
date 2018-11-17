using System;


using System.Text;


namespace fakulteit
{
    class Program
    {
        public static int Faktor(int num)
        {
            int result = 1;
            for(int i=1;i<=num;i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int fact = Faktor(number);
            Console.WriteLine("{0} factorial is {1}", number, fact);
            Console.ReadKey();

            

        
        
        }
    }
}