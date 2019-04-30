using System;

namespace Delegate
{
    class Program
    {
        delegate int del(int x, int y);

        static void Main(string[] args)
        {
            Test test = new Test();
            del d = test.AddNumbers;
            Console.WriteLine(d(3, 4));

            d = test.MultiplyNumbers;
            Console.WriteLine(d(3, 4));

            d = test.DoAnotherThing;
            Console.WriteLine(d(3, 4));

            Console.ReadLine();
        }

        public class Test
        {
            public int AddNumbers(int a, int b)
            {
                return a + b;
            }

            public int MultiplyNumbers(int a, int b)
            {
                return a * b;
            }

            public int DoAnotherThing(int x, int y)
            {
                return x + (y * 3);
            }
        }
    }
}