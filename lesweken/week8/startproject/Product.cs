using System;
using System.Collections;
using System.Collections.Generic;

namespace startproject
{
    // Class definition.
   public class Product
   {
    // Class members.
    private string naam;
    private ProductType type;
    public enum ProductType {
        None,
        Drank = 1,
        Snack = 2
    }
    private List<string> ingredienten;
    
    // Property.
    public string Naam { get; set; }
    public ProductType Type { get; set; }
    public List<string> Ingredienten { get; set; }


    // Method.

    // Instance Constructor.
    public Product(string pnaam, ProductType ptype, List<string> pingredienten)
    {
        naam = pnaam;
        type = ptype;
        ingredienten = pingredienten;
    }

    public Product(string pnaam, ProductType ptype)
    {
        naam = pnaam;
        type = ptype;
    }

    public Product()
    {
    }

    public string ToString()
    {
       return "product: " + this.Naam + " - type:" + this.Type.ToString();
    }
    public virtual int BerekenKCal()
    {
        return 0;
    }
   }
}