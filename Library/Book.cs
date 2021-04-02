using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private static int Counter = 1;
        private readonly int id;

        public Book()
        {
            id = Counter;
            Counter++;
        }


        public string Title { get; set; }
        public DateTime PublishDate { get; set; }

        public Author Author { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();

        public override string ToString() => $"{id}, {Title}, {PublishDate:dd/MM/yyyy}, {Author}";



    }
}
