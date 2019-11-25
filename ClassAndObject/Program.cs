using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Vehicle vehicle = new Vehicle("Honda Brio","Bk418Jh");
            vehicle.direction();

            StringClass stringClass = new StringClass("Prashant", "13-10-1995", "Pune");
            Console.WriteLine(stringClass.toString());

            //nested class
            Outer_Class outer_Class = new Outer_Class();
            outer_Class.method1();

            Outer_Class.Inner_Class inner_Class = new Outer_Class.Inner_Class();
            inner_Class.method2();

            //Early Binding Concept
            EarlyBinding earlyBinding = new EarlyBinding("Kumar", "CSHARP");
            earlyBinding.details();

            // Calling "mymethod()" gives error 
            // because this method does not  
            // belong to class or compiler  
            // does not know mymethod() at compile time

            //   earlyBinding.myMethod();  


            //Late Binding 
            LateBinding lateBinding = new LateBinding();
            lateBinding.types();


            //constructors
            var defaultCon1 = new Constructors();
            var argCon2 = new Constructors(25, 11, 2019);
            Console.WriteLine($"Constructor 1 : {defaultCon1}");
            Console.WriteLine($"Constructor 2 : {argCon2}");


            //Constructor 2

            Circle ring = new Circle(3); //radius = 3
            Cylinder tube = new Cylinder(3, 2.5);   //rad = 3, height = 2.5

            Console.WriteLine("Area of circle is  " + ring.Area());
            Console.WriteLine("Area of Cylinder is " + tube.Area());
               

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        
    }
}
