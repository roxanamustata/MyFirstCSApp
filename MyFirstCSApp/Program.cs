using System;

namespace MyFirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // conditional statements
            int x = 5;
            int y = 5;

            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            
            else if (x == y)
            {
                Console.WriteLine($"{x} equals {y}");

            }
            else
            {

                Console.WriteLine("{0} is less than {1}", x, y);
            }




            Console.WriteLine();
            Console.ReadLine();





        }
    }
}
