using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // The non-generic way to create a list
            // We'll add integers to this list
            // The integers are upcast to Object type when added;
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);

            // we can add strings and integers together in a list without any warning or compile-time error;
            // on the foreach loop, we will get an invalid cast;
            // list1.Add("Hello");

            Console.WriteLine("Non-Generic List Results:");
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }

            // Using a generic List;
            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(9);
            list2.Add(21);
            // If we try to add a string to the list we get an error;
            // list2.Add("Hello");

            Console.WriteLine("Generic List Results:");

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
