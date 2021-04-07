using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    public class Library
    {

        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }



        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddBooks(List<Book> newBooks)
        {
            foreach (var book in newBooks)
            {
                AddBook(book);
            }
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }


        public IEnumerable<Book> ListAllBooksAfterYear(int year) => books.Where(b => b.PublishDate.Date.Year > year);


        public IEnumerable<Book> ListAllBooksInCategory(Category category) => books.Where(b => b.Categories.Contains(category));


        public IEnumerable<string> ListAuthorsWithAtLeastAGivenNumberOfBooks(int numberOfBooks) => books
                                                                                           .GroupBy(b => b.Author.Name)
                                                                                           .Where(g => g.Count() >= numberOfBooks)
                                                                                           .Select(n => n.Key);

        public IEnumerable<string> ListAuthorsBornBeforeAndWithANumberofBooksInCategory(int Year, int numberOfBooks, Category category) => books
                                                                                           .GroupBy(b => b.Author)
                                                                                           .Where(g => g.Key.BirthDate.Year < Year)
                                                                                           .Where(g => g.Key.Books.Count(b => b.Categories.Contains(category)) >= numberOfBooks)
                                                                                           .Select(n => n.Key.Name);

        public IEnumerable<IGrouping<int, Book>> ListBooksGroupedByPublishingDecade() => books.GroupBy(b => b.Decade);


    }
}
