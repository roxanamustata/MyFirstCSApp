using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCS
{
    public class Rectangle : Unit, IArea
    {
        private double length;
        //private double width;
        public double Width { get; set; }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }

        }


     





        public override string Draw()
        {
            return "rectangle";
        }


        public override double CalculateArea()
        {
            return this.Length*this.Width;
        }
    }
}
