using System;
using System.Collections;


namespace week6 {

public class SamplesSortedList {


   public static void Main()  {

      // Creates and initializes a new SortedList.
      SortedList mySL = new SortedList();
       mySL.Add("plat water", "1");
       mySL.Add("cola 25cl", "1,5");
       mySL.Add("cola 33cl", "2");
       mySL.Add("witte wijn", "3");
       mySL.Add("pils", "\t2");
       mySL.Add("toast", "\t5");
       mySL.Add("kaasplankje", "4");

       

      // Displays the properties and values of the SortedList.
      Console.WriteLine( "mySL" );
      Console.WriteLine( "  Count:    {0}", mySL.Count );
      Console.WriteLine( "  Capacity: {0}", mySL.Capacity );
      Console.WriteLine( "  Keys and Values:" );
      PrintKeysAndValues( mySL );
   }


   public static void PrintKeysAndValues( SortedList myList )  {
      Console.WriteLine( "\t \tMenu" );
      for ( int i = 0; i < myList.Count; i++ )  {
         Console.WriteLine( "\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i) );
         
      }
      Console.WriteLine();
   }

   public static void PrintValues( IEnumerable myList )  {
      foreach ( Object obj in myList )
         Console.Write( "   {0}", obj );
      Console.WriteLine();
   }

   //sort by value
    
   
   

}
}
