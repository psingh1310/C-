using System;
using System.Text;
using System.Collections;
namespace CollectionFramework
{
    
    class ArrayListImplementation
    {
        public void listMethod()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hi");
            arrayList.Add("Prashant");
            arrayList.Add("DOB");
            arrayList.Add("13101995");
            arrayList.Add(string.Format("{0:HH:mm:ss tt}", DateTime.Now));

            Console.WriteLine("My arrayList");
            Console.WriteLine("count: {0}", arrayList.Count);
            Console.WriteLine("Capacity: {0}", arrayList.Capacity);
            Console.WriteLine(" Values: ");
            printValues(arrayList);

        }

       public static void printValues(IEnumerable arrayList)
        {
            foreach(Object obj in arrayList)
            {
                Console.WriteLine(obj);
                Console.WriteLine();
            }
        }
    }
}
