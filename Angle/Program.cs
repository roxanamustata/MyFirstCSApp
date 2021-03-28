using System;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle a = new Angle { Degrees = 59, Minutes = 35, Seconds = 55 } ;
            Angle b = new Angle { Degrees = 59, Minutes = 35, Seconds = 55 } ;
           
            Angle c = a + b;      
                      
            
            Console.WriteLine(c);
            Console.WriteLine(a==b);
            Console.WriteLine(a==c);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.Equals(c));
         


        }
    }
}
