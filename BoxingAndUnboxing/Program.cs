using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int x = 25;

            o = x; // Boxing is taking place here;
            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);

            o = 123;
            x = (int)o; // Unboxing;
            Console.WriteLine("o= " + o);
            Console.WriteLine("x= " + x);

            Console.ReadLine();
        }
    }
}
