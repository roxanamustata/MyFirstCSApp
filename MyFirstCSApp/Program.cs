using System;

namespace MyFirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // conditional statements
            Console.WriteLine("Please enter a constant: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a constant: ");
            int y = int.Parse(Console.ReadLine());

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
