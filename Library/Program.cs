using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{

    public class Program
    {
        static void Main(string[] args)
        {
            // Create authors and books
            var joyce = new Author { Id = 1, Name = "James Joyce", BirthDate = new DateTime(1882, 2, 2, 0, 0, 0) };
            var ulysses = new Book
            {
                Id = 1,
                Title = "Ulysses",
                PublishDate = new DateTime(1922, 2, 2, 0, 0, 0),
                Author = joyce,
                Categories = { Category.action, Category.fantasy }
            };

            joyce.Books.Add(ulysses);

            var tolstoi = new Author { Id = 2, Name = "Lev Tolstoi", BirthDate = new DateTime(1828, 8, 28, 0, 0, 0) };
            var warAndPeace = new Book
            {
                Id = 2,
                Title = "War and Peace",
                PublishDate = new DateTime(1931, 2, 3, 0, 0, 0),
                Author = tolstoi,
                Categories = { Category.drama, Category.romance }
            };
            var annaKarenina = new Book
            {
                Id = 6,
                Title = "Anna Karenina",
                PublishDate = new DateTime(1931, 2, 3, 0, 0, 0),
                Author = tolstoi,
                Categories = { Category.drama, Category.romance }
            };
            tolstoi.Books.Add(warAndPeace);
            tolstoi.Books.Add(annaKarenina);

            var faur = new Author { Id = 3, Name = "Daniela Faur", BirthDate = new DateTime(1982, 10, 5, 0, 0, 0) };
            var natureForces1 = new Book
            {
                Id = 3,
                Title = "Nature Forces - vol 1",
                PublishDate = new DateTime(2015, 2, 15, 0, 0, 0),
                Author = faur,
                Categories = { Category.action, Category.fantasy, Category.romance, Category.SF }
            };

            var natureForces2 = new Book
            {
                Id = 4,
                Title = "Nature Forces - vol 2",
                PublishDate = new DateTime(2017, 2, 15, 0, 0, 0),
                Author = faur,
                Categories = { Category.action, Category.fantasy, Category.romance, Category.SF }
            };

            var natureForces3 = new Book
            {
                Id = 5,
                Title = "Nature Forces - vol 3",
                PublishDate = new DateTime(2019, 2, 15, 0, 0, 0),
                Author = faur,
                Categories = { Category.action, Category.fantasy, Category.romance, Category.SF }
            };

            // Create library 
            var library = new Library();
            var books = library.Collection;

            // 1. Add books to the collection
            library.AddBooks(new List<Book> { ulysses, warAndPeace, natureForces1, natureForces2, natureForces3 });
            library.AddBook(annaKarenina);


            // 2. Remove a book from the collection
            library.RemoveBook(annaKarenina);


            //3. Retrieve the list of all books
            Console.WriteLine("List of all books:");
            books.Display();


            //4. Retrieve the list of all books published after 1980

            Console.WriteLine("List of all books published after 1980:");

            var booksPublishedAfter80 = books.Where(b => b.PublishDate.Date.Year > 1980);
            booksPublishedAfter80.Display();


            //5. Retrieve the list of all books with one of the categories: "drama"

            Console.WriteLine("List of all books in drama category:");

            var dramaBooks = books.Where(b => b.Categories.Contains(Category.drama));
            dramaBooks.Display();


            //6. Get the names of all authors that have published at least 3 books

            Console.WriteLine("All authors that have published at least 3 books:");

            var authorsWithAtLeastThreeBooks = books
                    .GroupBy(b => b.Author.Name)
                    .Where(g => g.Count() >= 3)
                    .Select(n => new { Name = n.Key });

            authorsWithAtLeastThreeBooks.Display();

            //7. Get the names of all authors that are born before 1990 and have written at 
            //   least 2 books of category "science-fiction"

            Console.WriteLine("All authors born before 1990 and with at least 2 SF books:");

            var authorsOver30AndAtLeastTwoSFBooks = books
                    .Where(b => b.Categories.Contains(Category.SF))
                    .GroupBy(b => b.Author)
                    .Where(g => g.Key.BirthDate < new DateTime(1990, 1, 1, 0, 0, 0) && g.Count() >= 2)
                    .Select(n => new { Name = n.Key });

            authorsOver30AndAtLeastTwoSFBooks.Display();


            //8.Write a method that returns an IGrouping of Books grouped by the decade they were published in.

            var booksGroupedByPublishDecade = library.GroupBooksByDecades();

            Console.WriteLine("Books grouped by the decade they were published in:");
            booksGroupedByPublishDecade.DisplayIGrouping();






        }
    }

}