using System;
using System.Collections;
using System.Collections.Generic;

namespace startproject
{
    // Class definition.
   public class MenuItem
   {
    // Class members.
    private Product item;
    private Prijs waarde;
    
    // Property.
    public Product Item { get; set; }
    public Prijs Waarde { get; set; }
    
    // Method.

    // Instance Constructor.
    public MenuItem(Product product, Prijs prijs)
    {
        item = product;
        waarde = prijs;
    }

    public MenuItem()
    {
    }

    public string ToString()
    {
       return "item: " + Item.ToString() + " - prijs:" + Waarde.ToString();
    }
   }
}