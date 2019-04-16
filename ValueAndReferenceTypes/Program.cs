using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteValueType();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            ExecuteReferenceType();

            Console.ReadLine();
        }

        private static void ExecuteValueType()
        {
            Console.WriteLine("Example of Value Type");

            int a = 5;
            int b = 10;
            Console.WriteLine("a value: " + a);
            Console.WriteLine("b value: " + b);

            int c = b;
            Console.WriteLine("c value: " + c);
            Console.WriteLine("------------");

            c = 3;

            Console.WriteLine("a value: " + a);
            Console.WriteLine("b value: " + b);
            Console.WriteLine("c value: " + c);
        }

        private static void ExecuteReferenceType()
        {
            Console.WriteLine("Example of Reference Type");
            Person pe1 = new Person();
            pe1.Name = "Luke";
            Console.WriteLine("Pe1 name is: " + pe1.Name);

            Person pe2 = new Person();
            pe2.Name = "John";
            Console.WriteLine("Pe2 name is: " + pe2.Name);

            Person pe3 = pe2;
            pe3.Name = "Ned";
            Console.WriteLine("Pe3 name is: " + pe3.Name);

            Console.WriteLine("------------");

            Console.WriteLine("Pe1 name is: " + pe1.Name);
            Console.WriteLine("Pe2 name is: " + pe2.Name);
            Console.WriteLine("Pe3 name is: " + pe3.Name);
        }

        public class Person
        {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
}