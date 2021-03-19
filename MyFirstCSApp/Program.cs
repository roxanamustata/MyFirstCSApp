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



            Console.WriteLine(isGreater);
            Console.WriteLine(isLess);
            Console.WriteLine(isEqual);
            Console.WriteLine(!isEqual);



        }
    }
}
