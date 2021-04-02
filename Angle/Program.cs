using System;

namespace Angle
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle a = new Angle (3, 36, 53 );
            Angle b = new Angle (4, 27,45 );

            Angle c = a + b;
            Angle d = new Angle( 8, 4, 38) ;

            Console.WriteLine(c);
            Console.WriteLine(d == a + b);
            Console.WriteLine(d.Equals(c));
            Console.WriteLine(d.Equals(a));




        }
    }
}
