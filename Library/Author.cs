using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Author
    {
        private static int Counter = 1;
        private readonly int id;

        public Author()
        {
            id = Counter;
            Counter++;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public override string ToString() => $"{Name}";
    }
}
