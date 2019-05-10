using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExampleUsingReflectionAndDynamic();
            // Console.WriteLine("-----------------------------");

            ExampleDynamic();

            Console.ReadLine();
        }

        private static void ExampleDynamic()
        {
            dynamic name = "Henrique";
            name = 10;

            Console.WriteLine(name);

            // the code below will throw an error:
            //dynamic name2 = "henrique";
            //name2++;
            //Console.WriteLine(name2);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
            Console.WriteLine(c);

            // Conversion and cast;
            int i = 5;
            dynamic d = i;
            Console.WriteLine(d);

            long l = d;
            Console.WriteLine(l);


        }

        private static void ExampleUsingReflectionAndDynamic()
        {
            object obj = "Henrique";

            // reflection; (Reflection is a way to inspect the metadata about the type, and access properties and methods);
            // obj.GetHashCode();
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            // dynamic is much cleaner than reflection;
            dynamic excelObject = "henrique";
            excelObject.Optimize();

        }
    }
}
