using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
   abstract class Shape
    {
        public const double pi = Math.PI;
        protected double value1, value2;

        protected Shape(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public abstract double Area();
    }
}


