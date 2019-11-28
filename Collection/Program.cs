using System;
using System.Collections;
using System.Collections.Generic;
namespace CollectionFramework
{

    class Program
    {


        static void Main(string[] args)
        {
            ArrayListImplementation arrayList = new ArrayListImplementation();
            arrayList.listMethod();

            /********************************************************************************************************/

            List<Part> parts = new List<Part>
            {

                //add
                new Part { name = "Kumar", id = 12345 },
                new Part { name = "Ranjan", id = 12364 },
                new Part { name = "Kuhikar", id = 13245 },
                new Part { name = "Singh", id = 14785 },
                new Part { name = "Roy", id = 13101 }
            };

            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            //find
            Console.WriteLine("\nContains(\"1734\"): {0}" +
                " ", parts.Contains(new Part { name = " ", id = 1734 }));

            Console.WriteLine("\nContain (\"12364\"): {0}" +
                " ", parts.Contains(new Part { name = " ", id = 12364 }));

            //update and add
            Console.WriteLine("\nInsert(\"1834\")");
            parts.Insert(2, new Part { name = "Rai", id = 1834 });

            foreach(Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            //remove

            Console.WriteLine("\nRemoveAt(3)");
            parts.RemoveAt(4);

            foreach(Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }


        }
    }
}
