using System;
using System.Collections.Generic;

namespace ClassesInCS
{
    public class Floor
    {
        //fields
        private int id;
        private string name;



        //properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Unit> Units { get; set; } = new List<Unit>();





        public double CalculateArea()
        {
            double totalArea = 0;
            string message = "Area is made of: \n";
            for (int i = 0; i < this.Units.Count; i++)
            {
                string unitShape = Units[i].Draw();
                double unitArea = Units[i].CalculateArea();

                message += unitShape + " " + "with an area of: " + unitArea + "\n";
                totalArea += unitArea;
            }
            Console.WriteLine(message + "\nTotal area is of: " + totalArea);

            return totalArea;
        }


        public static void SimulateFloor(Circle circle)
        {
            Console.WriteLine("The simulated floor is made of: " + circle.Draw());
        }


        public static void SimulateFloor(Circle circle, Rectangle rectangle)
        {
            Console.WriteLine("The simulated floor is made of: " + circle.Draw() + rectangle.Draw());
        }
        public static void SimulateFloor(params Unit[] units)
        {
            for (int i = 0; i < units.Length; i++)
            {

                Console.WriteLine("The simulated floor is made of: " + units[i].Draw());
            }
        }

    }
}



