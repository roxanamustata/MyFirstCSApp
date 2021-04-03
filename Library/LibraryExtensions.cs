using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class LibraryExtensions
    {
        public static void AddBook(this Library library, Book book)
        {
            library.Collection.Add(book);
        }

        public static void AddBooks(this Library library, List<Book> books)
        {
            foreach (var book in books)
            {
                library.AddBook(book);
            }
        }

        public static void RemoveBook(this Library library, Book book)
        {
            library.Collection.Remove(book);
        }

        public static IEnumerable<IGrouping<int, Book>> GroupBooksByDecades(this Library library)
        {
            return library.Collection.GroupBy(b => b.PublishDate.Year / 10);

        }
    }
}
