using System;

namespace MulticastDelegate
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Test test = new Test();

            del d;

            d = test.AddNumbers;
            Console.WriteLine("Invoking delegate d with one target:");
            d(6, 5);
            Console.WriteLine();

            d += test.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d with two targets:");
            d(6, 5);
            Console.WriteLine();

            d += test.SubtractNumbers;
            Console.WriteLine("Invoking delegate d with three targets:");
            d(6, 5);
            Console.WriteLine();

            d -= test.MultiplyNumbers;
            Console.WriteLine("Invoking delegate without MultiplyNumbers (removed MultiplyNumbers):");
            d(6, 5);
            Console.WriteLine();

            Console.ReadLine();
        }

        public class Test
        {
            public void AddNumbers(int a, int b)
            {
                Console.WriteLine("AddNumbers: a + b = " + (a + b));
            }

            public void MultiplyNumbers(int a, int b)
            {
                Console.WriteLine("MultiplyNumbers: a * b = " + (a * b));
            }

            public void SubtractNumbers(int a, int b)
            {
                Console.WriteLine("SubtractNumbers a - b = " + (a - b));
            }
        }
    }
}
