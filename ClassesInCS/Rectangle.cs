using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCS
{
    public class Rectangle : Unit, IArea
    {
        private double width;
        private double length;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }
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
            return this.Length * this.Width;
        }
    }
}
