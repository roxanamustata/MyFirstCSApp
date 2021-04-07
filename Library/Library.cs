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


        public List<Book> ListAllBooksAfterYear(int year)
        {
            var booksPublishedAfterYear = Collection.Where(b => b.PublishDate.Date.Year > year);
            return booksPublishedAfterYear.ToList();
        }

        public List<Book> ListAllBooksInCategory(Category category)
        {
            var booksInCategory = Collection.Where(b => b.Categories.Contains(category));
            return booksInCategory.ToList();
        }

        public List<string> ListAuthorsWithAtLeastAGivenNumberOfBooks(int numberOfBooks)
        {
            var authorsWithAtLeastNBooks = Collection
                       .GroupBy(b => b.Author.Name)
                       .Where(g => g.Count() >= numberOfBooks)
                       .Select(n => n.Key);

            return authorsWithAtLeastNBooks.ToList();

        }


        public List<string> ListAuthorsBornBeforeAndWithANumberofBooksInGivenCategory(int Year, int numberOfBooks, Category category)
        {
            var authorsOverAndAtLeastBooksInCategory = Collection
                       .GroupBy(b => b.Author)
                       .Where(g => g.Key.BirthDate.Year < Year)
                       .Where(g => g.Key.Books.Count(b => b.Categories.Contains(category)) >= numberOfBooks)
                       .Select(n => n.Key.Name);

            return authorsOverAndAtLeastBooksInCategory.ToList();
        }

        public List<IGrouping<int, Book>> ListBooksGroupedByPublishingDecade()
        {
            var booksGroupedByPublishDecade = Collection
                .GroupBy(b => b.Decade);

            return booksGroupedByPublishDecade.ToList();

        }
    }
}
