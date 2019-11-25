using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class Cylinder : Circle
    {
        public Cylinder(double radius, double height) : base(radius) 
        {
            value2 = height;
        }

        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * value1 * value2);
        }
    }
}
