using System;

namespace week5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int getalA = 10;
            int getalB = 30;
            getalA = getalA + getalB;
            getalA += getalB;
            Console.WriteLine(getalA);


            int i = 2;
            while(i <=100)
            {
                i=i*2;
                Console.WriteLine(i);
            }
        }
        */

            
            Console.WriteLine("Hello World!");

            string tekst = "Dit is een testje!";
            int lengte = tekst.Length;

            for(int i = 0; i< lengte; i++)
            {
                Console.WriteLine(tekst.Substring(i,1));
                // Console.WriteLine (tekst[i] + " staat op plaats " + i + " binnen mijn string");
            }

            // string tekstUp = tekst.ToLower();
            // Console.WriteLine(tekstUp);
            // string tekstLow = tekst.ToUpper();
            // Console.WriteLine(tekstLow);
            // string[] tekstSplit = tekst.Split(' ');
            string[] woorden = tekst.Split(' ');
            // 
            foreach (var woord in woorden)
            {
                // Console.WriteLine(word.Trim());
                Console.WriteLine(woord);

            }
            // // Console.WriteLine(tekstSplit[0] + "  " + tekstSplit[1]  + "  " + tekstSplit[2]  + "  " + tekstSplit[3]);
            Console.WriteLine(tekst.ToLower());
            Console.WriteLine(tekst.ToUpper());
            char[] spatie = { ' ' };
            Console.WriteLine(tekst.Trim(spatie)) ;



            string wachtwoord = "test";
            bool test1 = wachtwoord.Contains('b');
            Console.WriteLine(test1);
            bool test2 = wachtwoord.Contains('b');
            Console.WriteLine(test2);
            bool test3 = wachtwoord.Contains('t');
            Console.WriteLine(test3);
            if (wachtwoord == "tekst3")
            {
                Console.Write("Wachtwoord is gelijk");
                }


            
            
            Random randomGetal = new Random();
            int getal1 = randomGetal.Next(0, 20);
            Console.WriteLine(getal1);
            int getal2 = randomGetal.Next(0, 20);
            Console.WriteLine(getal2);
            int getal3 = randomGetal.Next(0, 20);
            Console.WriteLine(getal3);
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(randomGetal.Next(0,20));
            }

            char[] chars = new char[8];
            chars[0] = ' ';
            chars[1] = 'G';
            // Char aanroepen met behulp van integer waarde.
            chars[2] = (char)78;
            // Char aanroepen door middel van de unicode van het karkater
            chars[3] = '\u002E';
            chars[4] = 'f';
            chars[5] = 'a';
            chars[6] = 'i';
            chars[7] = (char)85;

            foreach (char c in chars)
            {
                Console.Write(c);
            }
            char[] campus = {'M','A','R'};

                string[]menu1 = new string[3];
                menu1[0] = "broodje martino";
                menu1[1] = "broodje ham";
                menu1[2] = "broodje kaas";

                foreach(var item in menu1)
                {
                    Console.WriteLine(item);

                }

                string[] menu2 = new string[3] {"broodje scampi", "broodje brie", "broodje boulette"};
                foreach(var item in menu2)
                {
                    Console.WriteLine(item);

                }
                Console.WriteLine("For Loop:");
                for (int i = 0; i < menu2.Length; i++)
                {
                    Console.WriteLine(menu2[i]);

                }
                string[,] menu3 = new string[,] {{"Broodje scampi", "4"}, {"Broodje Brie", "3"}, {"Broodje boulette", "4"}};
                foreach (var item in menu3 )
                {
                    Console.WriteLine(item);
                }
        } 
    }
}
