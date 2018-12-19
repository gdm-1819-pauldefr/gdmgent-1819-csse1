using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 5 - Book");

            Author author1 = new Author();
            author1.Name = "Tom Aat";
            author1.Email = "TomAat@mail.be";
            author1.Gender = 'M';

            Book book1 = new Book("Hoe kom je snel tot rust", author1, 40.00, 1);

            // Testing print and getters.
            
            Console.WriteLine("\nFirst Print");
            book1.print();
            Console.WriteLine("\nTesting getters:");
            Console.WriteLine(book1.getName().ToString());
            Console.WriteLine(book1.getPrice().ToString());
            Console.WriteLine(book1.getQtyInStock().ToString());
            
            
            Console.WriteLine(book1.getAuthor());
            Console.WriteLine(book1.getAuthorName().ToString());

            
            
            book1.setPrice(19.99);
            book1.setQtyInStock(2);

           
            Console.WriteLine("\nSecond Print after testing setters:");
            book1.print();

        }
    }
}