using System;

namespace Book {

  public class Book {
    // Fields
    private string name;
    private Author author;
    private double price;
    private int qtyInStock = 0;
    
    // Constructor
    public Book(string name, Author author, double price, int qtyInStock) {
      this.name = name;
      this.author = author;
      this.price = price;
      this.qtyInStock = qtyInStock;
    }
    
    // Methods: getters.
    public string getName() 
    {
      return this.name;
    }

    public Author getAuthor() 
    {
      return this.author;
    }

    public double getPrice() 
    {
      return this.price;
    }

    public int getQtyInStock()
    {
      return this.qtyInStock;
    }

    public string getAuthorName()
    {
      return this.author.Name;
    }

    // Methods: setters.

    public void setPrice(double price) 
    {
      this.price = price;
    }

    public void setQtyInStock(int qtyInStock)
    {
      this.qtyInStock = qtyInStock;
    }

    // Methods: print.

    public void print() {
      Console.WriteLine("Het boek met titel \"" + this.name + "\" van auteur " + this.author.Name + " kost " + this.price + " euro.");
      if(this.qtyInStock == 1) 
      {
        Console.WriteLine("Er is nog " + this.qtyInStock + " boek in voorraad");
      } else 
      {
        Console.WriteLine("Er zijn nog " + this.qtyInStock + " boeken in voorraad");
      }
    }

  }
}