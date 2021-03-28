using System;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle a = new Angle { Degrees = 3, Minutes = 36, Seconds = 53 } ;
            Angle b = new Angle { Degrees = 4, Minutes = 27, Seconds = 45 } ;
           
            Angle c = a + b;
            Angle d = new Angle { Degrees = 8, Minutes = 4, Seconds = 38 };          
            
            Console.WriteLine(c);
            Console.WriteLine(d==a+b);
            Console.WriteLine(d.Equals(c));
           
         


        }
    }
}
