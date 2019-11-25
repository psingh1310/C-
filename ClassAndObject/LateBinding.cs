using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    class LateBinding
    {
        dynamic obj1 = 4;
        dynamic obj2 = 5.13;

        public void types()
        {
            Console.WriteLine("The type of objects are: ");
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());
        }
    }
}

/* In the above, program the obj holds integer type data and obj1 holds double type data. 
 * But the compiler doesn’t resolve these at compile-time. At the runtime, these dynamic objects
 * get detected and converted into System.Int32 and System.Double respectively. Thats why 
 * the run-time resolving process is termed as late binding.*/
