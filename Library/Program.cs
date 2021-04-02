using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{





    //6. Get the names of all authors that have published at least 3 books
    //7. Get the names of all authors that are born before 1990 and have written at 
    //        least 2 books of category "science-fiction"
    public class Program
    {
        static void Main(string[] args)
        {
            //Create authors and books
            var Joyce = new Author { Name = "James Joyce", BirthDate = new DateTime(1882, 2, 2, 0, 0, 0) };
            var Ulysses = new Book
            {

                Title = "Ulysses",
                PublishDate = new DateTime(1922, 2, 2, 0, 0, 0),
                Author = Joyce,
                Categories = { Category.action, Category.fantasy }
            };

            Joyce.Books.Add(Ulysses);

            var Tolstoi = new Author { Name = "Lev Tolstoi", BirthDate = new DateTime(1828, 8, 28, 0, 0, 0) };
            var WarAndPeace = new Book
            {

                Title = "War and Peace",
                PublishDate = new DateTime(1928, 2, 3, 0, 0, 0),
                Author = Tolstoi,
                Categories = { Category.drama, Category.romance }
            };

            Tolstoi.Books.Add(WarAndPeace);

            var Faur = new Author { Name = "Daniela Faur", BirthDate = new DateTime(1982, 10, 5, 0, 0, 0) };
            var NatureForces1 = new Book
            {

                Title = "Nature Forces - vol 1",
                PublishDate = new DateTime(2015, 2, 15, 0, 0, 0),
                Author = Faur,
                Categories = { Category.action, Category.fantasy, Category.romance }
            };

            var NatureForces2 = new Book
            {

                Title = "Nature Forces - vol 2",
                PublishDate = new DateTime(2017, 2, 15, 0, 0, 0),
                Author = Faur,
                Categories = { Category.action, Category.fantasy, Category.romance }
            };

            //Create library 
            var Library = new Library();

            //1. Add books to the collection
            Library.AddBook(Ulysses);
            Library.AddBook(WarAndPeace);
            Library.AddBook(NatureForces1);
            Library.AddBook(NatureForces2);

            //2. Remove a book from the collection
            Library.RemoveBook(NatureForces2);

            IEnumerable<Book> Books = Library.Collection;

            //3. Retrieve the list of all books
            Console.WriteLine("List of all books:");
            Books.Display();

            //4. Retrieve the list of all books published after 1980
            Console.WriteLine("List of all books published after 1980:");
            var BooksPublishedAfter80 = Books.Where(b => b.PublishDate.Date.Year > 1980);
            BooksPublishedAfter80.Display();

            //5. Retrieve the list of all books with one of the categories: "drama"
            Console.WriteLine("List of all books in drama category:");
            var DramaBooks = Books.Where(b => b.Categories.Contains(Category.drama));
            DramaBooks.Display();

            //6. Get the names of all authors that have published at least 3 books
            Console.WriteLine("All authors that have published at least 3 books:");
            var AuthorsWithAlLeastThreeBooks = Books.GroupBy(b => b.Author).Count() >= 3;
           





        }
    }

}