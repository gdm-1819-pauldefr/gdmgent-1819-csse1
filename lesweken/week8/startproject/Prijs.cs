using System;
using System.Collections;
using System.Collections.Generic;

namespace startproject
{
    // Class definition.
   public class Prijs
   {
    // Class members.
    private string waarde;
    private Valuta valuta;
    public enum Valuta {EUR, USD};
    
    // Property.
    public string Waarde { get; set; }
    public Valuta Val { get; set; }

    // Method.

    // Instance Constructor.
    public Prijs(string prijs, Valuta valuta)
    {
        this.valuta = valuta;
        this.waarde = prijs;
    }

    public Prijs()
    {
    }

    public string ToString()
    {
       return "prijs: " + this.Waarde + " - valuta:" + this.Val.ToString();
    }
   }
}