using System;

namespace MyFirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // relational operators
            int x = 10;
            int y = 11;

            bool isGreater = x > y;
            bool isLess = x < y;
            bool isEqual = x == y;

            // conditional operators

            bool a = true;
            bool b = false;
            bool c = true;

            bool d = a && b;
            bool e = a || b;


            Console.WriteLine(d);
            Console.WriteLine(e);
            



        }
    }
}
