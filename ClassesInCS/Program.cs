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
                        
            //Circle and Rectangle are inheriting Unit, which is an abstract class that implements IArea interface
            Unit CircleUnit = new Circle() { Radius = 10 };
            Unit RectangleUnit = new Rectangle() { Length = 11, Width = 10 };
            Unit AnotherCircle = new Circle() { Radius = 20 };

            //Each floor of a building is comprised of several units, each unit having a different shape
            Floor GroundFloor = new Floor();

            GroundFloor.Units.Add(CircleUnit);
            GroundFloor.Units.Add(RectangleUnit);

            //Below I show method overriding as for each unit, the area is calculated depending on units shape 
            GroundFloor.CalculateArea();
            Console.ReadLine();


            // Below I show methods overloading
            Floor.SimulateFloor(CircleUnit);
            Console.ReadLine();
            Floor.SimulateFloor(CircleUnit, RectangleUnit);
            Console.ReadLine();
            Floor.SimulateFloor(CircleUnit, RectangleUnit, AnotherCircle);






        }



    }

}