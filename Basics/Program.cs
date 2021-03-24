using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // value types, reference types, ref, out
            //Point p = new Point();
            //p.x = 3;
            //p.y = 3;
            //Console.WriteLine(p.x + ", " + p.y);

            //Point anotherP = new Point();
            //Origin anotherS = new Origin();

            //modify(p);
            //Console.WriteLine("Modified p without ref: "+p.x + ", " + p.y);

            //modifyRef(ref p);
            //Console.WriteLine("Modified p with ref: " + p.x + ", " + p.y);

            //Origin s=new Origin{ x=10, y=10};
            //Console.WriteLine(s.x + ", " + s.y);

            //modifyStruct(s);
            //Console.WriteLine("Modified s without ref: " + s.x + ", " + s.y);

            //modifyStructRef(ref s);
            //Console.WriteLine("Modified s with ref: " + s.x + ", " + s.y);

            //modifyOut(out anotherP);
            //Console.WriteLine("Modified anotherP with out: " + anotherP.x + ", " + anotherP.y);

            //modifyStructOut(out anotherS);
            //Console.WriteLine("Modified anotherS with out: " + anotherS.x + ", " + anotherS.y);


            //boxing 
            //int a = 100;
            //object obj = a;
            //Console.WriteLine("value of obj is: " + obj);

            //unboxing
            //int b =(int) obj;
            //Console.WriteLine("value of b is: " + b);



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

        private static void modifyOut(out Point point)
        {
            point = new Point { x = 1, y = 1 };
            

        }


        private static void modifyStruct(Origin point)
        {
            point = new Origin { x = 0, y = 0 };
           
        }

        private static void modifyStructRef(ref Origin point)
        {
            point = new Origin { x = 0, y = 0 };

        }

        private static void modifyStructOut(out Origin point)
        {
            point = new Origin { x = 1, y = 1 };


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
