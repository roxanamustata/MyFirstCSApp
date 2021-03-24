using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesInCS
{
    public abstract class Unit:IArea
    {
       
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual string Draw()
        {
            return "shape";


        }

        
    }
}