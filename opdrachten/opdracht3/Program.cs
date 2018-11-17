using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Datacollectie oefening Array...
            // Een array van integers met plaats voor 10 items met getallen van 1 tot 10.
            int[] mijnGetallen = new int[10] { 8, 4, 2, 1, 5, 3, 7, 9, 6, 10 };
            // Oproepen van de functie WeergevenGetallen.
            WeergevenGetallen(mijnGetallen);
            // Sorteren van de collectie.
            Array.Sort(mijnGetallen);
            WeergevenGetallen(mijnGetallen);

            // Voorbeeld menu...
            // Een array met alle menuitems.
            string[] menuItems = new string[7];
            menuItems[0] = "plat water";
            menuItems[1] = "cola 25 cl";
            menuItems[2] = "cola 33 cl";
            menuItems[3] = "witte wijn";
            menuItems[4] = "pils";
            menuItems[5] = "toast";
            menuItems[6] = "kaasplank";
            // Weergevan van alle menuitems.

            // Een array met alle menuprijzen.
            double[] menuPrijzen = new double[7];
            menuPrijzen[0] = 1;
            menuPrijzen[1] = 1.5;
            menuPrijzen[2] = 2;
            menuPrijzen[3] = 3;
            menuPrijzen[4] = 2;
            menuPrijzen[5] = 5;
            menuPrijzen[6] = 4;

            WeergevenMenuItems(menuItems, menuPrijzen);
            Array.Sort(menuItems, menuPrijzen);
            WeergevenMenuItems(menuItems, menuPrijzen);

            
            
            Console.WriteLine("--- List ---");
            var menu = new List<KeyValuePair<string, double>>() 
            { 
                new KeyValuePair<string, double>("plat water", 1),
                new KeyValuePair<string, double>("cola 25 cl", 1.5),
                new KeyValuePair<string, double>("cola 33 cl", 2),
                new KeyValuePair<string, double>("witte wijn", 3),
                new KeyValuePair<string, double>("pils", 2),
                new KeyValuePair<string, double>("toast", 5),
                new KeyValuePair<string, double>("kaasplank", 4),
            };
            WeergevenElementenListKVP(menu);
            //menu.Sort();
            Console.WriteLine("--- Dictionary ---");
            Dictionary<string, double> mijnDictionary = new Dictionary<string, double>();
            mijnDictionary.Add("plat water", 1);
            mijnDictionary.Add("cola 25 cl", 1.5);
            mijnDictionary.Add("cola 33 cl", 2);
            mijnDictionary.Add("witte wijn", 3);
            mijnDictionary.Add("pils", 2);
            mijnDictionary.Add("toast", 5);
            mijnDictionary.Add("kaasplank", 4);
            WeergevenElementenDictionary(mijnDictionary);

            Console.WriteLine("--- ArrayList ---");
            ArrayList mijnArrayList = new ArrayList();
            
            WeergevenElementenArrayList(mijnArrayList);
            
            Console.WriteLine("--- SortedList ---");
            SortedList mijnSortedList = new SortedList();
            mijnSortedList.Add("plat water", 1);
            mijnSortedList.Add("cola 25 cl", 1.5);
            mijnSortedList.Add("cola 33 cl", 2);
            mijnSortedList.Add("witte wijn", 3);
            mijnSortedList.Add("pils", 2);
            mijnSortedList.Add("toast", 5);
            mijnSortedList.Add("kaasplank", 4);
            WeergevenElementenSortedList(mijnSortedList);
        }

        static void WeergevenGetallen(int[] mijnCollectie)
        {
            // In deze functie gaan we elk element uit de 
            // meegegeven collectie overlopen en afdrukken in de Console.
            foreach (int element in mijnCollectie)  {
                // Item afdrukken in de console.
                Console.Write("\t{0}", element);
            }
            Console.WriteLine();
        }

        static void Weergeven(int[] mijnCollectie)
        {
            // Elk element uit de meegegeven collectie overlopen en tonen in de Console.
            foreach (int element in mijnCollectie)  {
                // Item tonen in de console.
                Console.Write("\t{0}", element);
            }
            Console.WriteLine();
        }

        public static void WeergevenMenuItems(string[] sleutels, double[] waarden)
        {
            for ( int i = 0; i < sleutels.Length; i++ )
            {
                Console.WriteLine( "   {0,-10}: {1}", sleutels[i], waarden[i] );
            }
            Console.WriteLine();
        }

         public static void WeergevenElementenListKVP(List<KeyValuePair<string, double>> collectie)
         {
            foreach (var element in collectie)
            {
                Console.WriteLine(element);
            }
        }

        public static void WeergevenElementenList(List<object> collectie)
         {
            foreach (var element in collectie)
            {
                Console.WriteLine(element);
            }
        }

        public static void WeergevenElementenDictionary(Dictionary<string, double> collectie)
         {
            foreach (var element in collectie)
            {
                Console.WriteLine(element);
            }
        }

        public static void WeergevenElementenArrayList(ArrayList collectie)
         {
            foreach (var element in collectie)
            {
                Console.WriteLine(element);
            }
        }

         public static void WeergevenElementenSortedList(SortedList collectie)
         {
            for ( int i = 0; i < collectie.Count; i++ )
            {
                Console.WriteLine( "\t[{0}]:\t{1}\t{2}", i, collectie.GetKey(i), collectie.GetByIndex(i) );
            }
            Console.WriteLine();
        }
    }
}
