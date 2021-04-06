using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class Library
    {

        public List<Book> Collection { get; set; }

        public Library()
        {
            Collection = new List<Book>();
        }


        public void AddBook(Book book)
        {
            Collection.Add(book);
        }

        public void AddBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                AddBook(book);
            }
        }

        public void RemoveBook(Book book)
        {
            Collection.Remove(book);
        }

        public void ListAllBooks()
        {
            Collection.Display();
        }

        public void ListAllBooksAfterYear(int year)
        {
            var booksPublishedAfterYear = Collection.Where(b => b.PublishDate.Date.Year > year);
            booksPublishedAfterYear.Display();
        }

        public void ListAllBooksInCategory(Category category)
        {
            var booksInCategory = Collection.Where(b => b.Categories.Contains(category));
            booksInCategory.Display();
        }

        public void ListAuthorsWithAtLeastAGivenNumberOfBooks(int numberOfBooks)
        {
            var authorsWithAtLeastNBooks = Collection
                       .GroupBy(b => b.Author.Name)
                       .Where(g => g.Count() >= numberOfBooks)
                       .Select(n => new { Name = n.Key });

            authorsWithAtLeastNBooks.Display();
        }

        public void ListAuthorsBornBeforeAndWithANumberofBooksInGivenCategory(int Year, int numberOfBooks, Category category)
        {
            var authorsOverAndAtLeastBooksInCategory = Collection
                       .GroupBy(b => b.Author)
                       .Where(g => g.Key.BirthDate.Year < Year)
                       .Where(g => g.Key.Books.Count(b => b.Categories.Contains(category)) >= numberOfBooks)
                       .Select(n => new { Name = n.Key });

            authorsOverAndAtLeastBooksInCategory.Display();
        }

        public void ListBooksGroupedByPublishingDecade()
        {
            var booksGroupedByPublishDecade = Collection
                .GroupBy(b => b.Decade);

            booksGroupedByPublishDecade.DisplayIGrouping();

        }
    }
}
