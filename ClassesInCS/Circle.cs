using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCS
{
    public class Circle : Unit, IArea
    {
        //private double radius;

        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return this.Radius*this.Radius*Math.PI;
        }

        public override string Draw()
        {
            return "circle";
        }



    }
}
