using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecDemo1();

            Console.WriteLine("-----------------------------");

            ExecDemo2();

            Console.WriteLine("-----------------------------");

            ExecDemo3();

            Console.ReadLine();
        }

        private static void ExecDemo3()
        {
            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            // se numbers. ... there are some extensions methods that come with Linq which allows us to query objects;
            var max = numbers.Max();

            Console.WriteLine(max);
        }

        private static void ExecDemo2()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";

            var shortenedPost = post.Shorten(5);
          
            Console.WriteLine(shortenedPost);
        }

        private static void ExecDemo1()
        {
            string x = "Hello";
            string y = "hello";

            Console.WriteLine(x + " is capitalized? " + x.IsCap());
            Console.WriteLine(y + " is capitalized? " + y.IsCap());
        }
    }

    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}
