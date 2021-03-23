using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point p = new Point();
            p.x = 3;
            p.y = 3;
            Console.WriteLine(p.x + ", " + p.y);
                        
            modify(p);
            Console.WriteLine("Modified p without ref: "+p.x + ", " + p.y);

            modifyRef(ref p);
            Console.WriteLine("Modified p with ref: " + p.x + ", " + p.y);

            Origin s=new Origin{ x=10, y=10};
            Console.WriteLine(s.x + ", " + s.y);

            modifyStruct(s);
            Console.WriteLine("Modified s without ref: " + s.x + ", " + s.y);

            modifyStructRef(ref s);
            Console.WriteLine("Modified s with ref: " + s.x + ", " + s.y);



            Console.ReadLine();
        }

        private static void modify(Point point)
        {
            point = new Point();
            point.x = 1;
            point.y = 1;
            
        }

        private static void modifyRef(ref Point point)
        {
            point = new Point();
            point.x = 1;
            point.y = 1;

        }


        private static void modifyStruct(Origin point)
        {
            point = new Origin { x = 0, y = 0 };
           

        }

        private static void modifyStructRef(ref Origin point)
        {
            point = new Origin { x = 0, y = 0 };

        }

    }


    class Point
    {
        public int x;
        public int y;

    }

    struct Origin
    {
        public int x;
        public int y;

    }

}
