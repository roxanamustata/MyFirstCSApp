using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace ClassesInCS
{
    class Program
    {

        static void Main(string[] args)
        {
            Unit CircleUnit = new Circle() { Radius = 10 };
            Unit RectangleUnit = new Rectangle() { Length = 11, Width = 10 };
            Unit AnotherCircle = new Circle() { Radius = 20 };

            Floor GroundFloor = new Floor();

            GroundFloor.Units.Add(CircleUnit);
            GroundFloor.Units.Add(RectangleUnit);

            GroundFloor.CalculateArea();
            Console.ReadLine();



            Floor.SimulateFloor(CircleUnit);
            Console.ReadLine();
            Floor.SimulateFloor(CircleUnit, RectangleUnit);
            Console.ReadLine();
            Floor.SimulateFloor(CircleUnit, RectangleUnit, AnotherCircle);






        }



    }

}