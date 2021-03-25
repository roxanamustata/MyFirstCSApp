using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // value types, reference types with class object
            Point p = new Point();
            p.x = 3;
            p.y = 3;

            //prints: 3, 3
            Console.WriteLine(p.x + ", " + p.y);       

            //prints 3, 3 because the reference of p has not changed
            modify(p);
            Console.WriteLine("Modified p without ref: " + p.x + ", " + p.y);

            //prints 1, 1 because now p is pointing to the object created in the method
            modifyRef(ref p);
            Console.WriteLine("Modified p with ref: " + p.x + ", " + p.y);

            //value types, reference types with struct object
            Origin s = new Origin { x = 10, y = 10 };
            Console.WriteLine(s.x + ", " + s.y);

            //prints 10, 10
            modifyStruct(s);
            Console.WriteLine("Modified s without ref: " + s.x + ", " + s.y);

            //prints 0, 0 as s will reference the new object created within the method
            modifyStructRef(ref s);
            Console.WriteLine("Modified s with ref: " + s.x + ", " + s.y);

            //out 
            Point AnotherP = new Point();
            Origin AnotherS = new Origin();

            //prints 1, 1 both for class and struct object as the reference will be to the new object created within the method
            modifyOut(out AnotherP);
            Console.WriteLine("Modified anotherP with out: " + AnotherP.x + ", " + AnotherP.y);

            modifyStructOut(out AnotherS);
            Console.WriteLine("Modified anotherS with out: " + AnotherS.x + ", " + AnotherS.y);



            //boxing
            //value of obj is 100
            int a = 100;
            object obj = a;
            Console.WriteLine("value of obj is: " + obj);

            //unboxing
            //if I don't cast obj y int, I get an error
            //value of b is 100
            int b = (int)obj;
            Console.WriteLine("value of b is: " + b);


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
