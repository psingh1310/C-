using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
   public class Outer_Class
    {
        public void method1()
        {
            Console.WriteLine("We are calling the Outer Class");
        }

        public class Inner_Class
        {
            public void method2()
            {
                Console.WriteLine("We are calling the inner class");
            }
        }

    }
}
