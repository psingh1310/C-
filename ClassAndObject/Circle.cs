using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Circle : Shape     //Circle extens Shape
    {
        public Circle(double radius) : base(radius,0)
        {

        }

        public override double Area()
        {
            return pi * value1 * value2;
        }
    }
}
