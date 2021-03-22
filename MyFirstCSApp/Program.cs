using System;

namespace MyFirstCSApp
{
    class Program
    {
        static void Main(string[] args)
        {


            // switch statements

            int x = 4;
            switch (x)
            {
                case 1:
                    Console.WriteLine($"{x} is one");
                    break;
                case 2:
                    Console.WriteLine($"{x} is two");
                    break;
                case 3:
                    Console.WriteLine($"{x} is three");
                    break;
                default:
                    Console.WriteLine("unknown number");
                    break;


            }



            Console.ReadLine();
            



        }
    }
}
