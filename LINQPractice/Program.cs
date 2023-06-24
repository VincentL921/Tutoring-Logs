using System;

namespace LINQPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBooks = new List<Book>
            {
                new Book() {Title = "Advance C#", Price = 9.99 },
                new Book() {Title = "OOP with C#", Price = 14.99 },
                new Book() {Title = "C# For Beginners", Price = 19.99 },
                new Book() {Title = "Complete ASP.NET Core", Price = 29.99 },
            };

            //With LINQ
            var myNewBooks = myBooks.Where(b => b.Title.Contains("C#")).Select(b => b.Title);

            //Others selections:
            //.Select(b => b.Price);

            //If wanting to select books to order with "C#" alphabetically:
            //.OrderBy(b => b.Title);

            //Ordering alphabetically with a select statement as well:
            //.OrderBy(b => b.Title).Select(b => b.Title);

            //Ordering by price list with a select statement as well:
            //.OrderBy(b => b.Title).Select(b => b.Price);


            foreach (var book in myNewBooks)
            {
                Console.WriteLine(book);
                //When just searching for titles that contain "C#", print (book.Title) or (book.Price).
                //^^Need to print this way as well if ordering alphabetically or based off price order.
                //Dont need to add .Title or .Price on print when using select statement.
            }

            //Without LINQ
            //foreach (var book in myBooks)
            ////{
            ////    if (book.Title.Contains("C#"))
            ////    {
            ////        Console.WriteLine(book.Title);
            ////    }
            ////}
        }
    }
    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }
}
