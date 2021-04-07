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
                Categories = { Category.Action, Category.Fantasy }
            };

            joyce.Books.Add(ulysses);

            var tolstoi = new Author { Id = 2, Name = "Lev Tolstoi", BirthDate = new DateTime(1828, 8, 28, 0, 0, 0) };
            var warAndPeace = new Book
            {
                Id = 2,
                Title = "War and Peace",
                PublishDate = new DateTime(1931, 2, 3, 0, 0, 0),
                Author = tolstoi,
                Categories = { Category.Drama, Category.Romance }
            };
            var annaKarenina = new Book
            {
                Id = 6,
                Title = "Anna Karenina",
                PublishDate = new DateTime(1931, 2, 3, 0, 0, 0),
                Author = tolstoi,
                Categories = { Category.Drama, Category.Romance }
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
                Categories = { Category.Action, Category.Fantasy, Category.Romance, Category.SF }
            };

            var natureForces2 = new Book
            {
                Id = 4,
                Title = "Nature Forces - vol 2",
                PublishDate = new DateTime(2017, 2, 15, 0, 0, 0),
                Author = faur,
                Categories = { Category.Action, Category.Fantasy, Category.Romance, Category.SF }
            };

            var natureForces3 = new Book
            {
                Id = 5,
                Title = "Nature Forces - vol 3",
                PublishDate = new DateTime(2019, 2, 15, 0, 0, 0),
                Author = faur,
                Categories = { Category.Action, Category.Fantasy, Category.Romance, Category.SF }
            };

            faur.Books.Add(natureForces1);
            faur.Books.Add(natureForces2);
            faur.Books.Add(natureForces3);

            // Create library 
            var library = new Library();


            // 1. Add books to the collection
            library.AddBooks(new List<Book> { ulysses, warAndPeace, natureForces1, natureForces2, natureForces3 });
            library.AddBook(annaKarenina);


            // 2. Remove a book from the collection
            library.RemoveBook(annaKarenina);


            //3. Retrieve the list of all books
            Console.WriteLine("List of all books:");
            library.Collection.Display();


            //4. Retrieve the list of all books published after 1980

            Console.WriteLine("List of all books published after 1980:");
            library.ListAllBooksAfterYear(1980).Display();


            //5. Retrieve the list of all books with one of the categories: "drama"

            Console.WriteLine("List of all books in drama category:");
            library.ListAllBooksInCategory(Category.Drama);


            //6. Get the names of all authors that have published at least 3 books

            Console.WriteLine($"All authors that have published at least 3 books: ");
            library.ListAuthorsWithAtLeastAGivenNumberOfBooks(3).Display();


            //7. Get the names of all authors that are born before 1990 and have written at 
            //   least 2 books of category "science-fiction"

            Console.WriteLine("All authors born before 1990 and with at least 2 SF books:");
            library.ListAuthorsBornBeforeAndWithANumberofBooksInGivenCategory(1990, 2, Category.SF).Display();


            //8.Write a method that returns an IGrouping of Books grouped by the decade they were published in.

            Console.WriteLine("Books grouped by the decade they were published in:");
            library.ListBooksGroupedByPublishingDecade().DisplayIGrouping();






        }
    }

}