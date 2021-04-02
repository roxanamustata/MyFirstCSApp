using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class LibraryExtensions
    {
        public static void AddBook (this Library Library, Book Book)
        {
            Library.Collection.Add(Book);
        }


        public static void RemoveBook(this Library Library, Book Book)
        {
            Library.Collection.Remove(Book);
        }

       
    }
}
