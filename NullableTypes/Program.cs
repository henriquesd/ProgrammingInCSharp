using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Example1();

            Console.WriteLine("-----------------------------");

            Example2();

            Console.WriteLine("-----------------------------");

            NullCoalescingOperatorExample();

            Console.ReadLine();
        }

        private static void NullCoalescingOperatorExample()
        {
            // Older code:
            //DateTime? date = null;
            //DateTime? date2;

            //if (date != null)
            //    date2 = date.GetValueOrDefault();
            //else
            //    date2 = DateTime.Today;


            // New code:
            DateTime? date = null;

            // Null Coalescing Operator Example \/
            DateTime? date2 = date ?? DateTime.Today;

            // Null Coalescing Operator is a shorter way of writing this code below:
            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);
            Console.WriteLine(date3);
        }

        private static void Example2()
        {
            DateTime? date = new DateTime(2014, 1, 1);

            // The code bellow get an error, because we're trying to put a Nullable DateTime into a DateTime, and the compiler
            // doesn't know how to respond to that; So in situations like that, what you need to do is access that GetValueOrDefault method;
            // DateTime date2 = date;

            DateTime date2 = date.GetValueOrDefault();
            
            Console.WriteLine(date2);

            DateTime? date3 = date2;
            Console.WriteLine(date3.GetValueOrDefault());
        }

        private static void Example1()
        {
            // This code below got an error, because DateTime is a value type and, as a result, cannot be set to null;
            // We can solv that issue by using Nullable;
            // DateTime date = null;

            // Nullable is a generic structure that is defined in the System namespace.
            // So with that, now we can have a variable that can have either null or a valid DateTime:
            // Nullable<DateTime> date = null;
            // The shorthand of defining nullables is using the question mark:
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // the code below will thrown an exception; When you access the Value property, you should make sure that
            // your code object has a value, otherwise, you're gonna get an exception; So GetValueOrDefault is the preferred way
            // of gettin the value. Using GetValueOrDefault, if the object has a value, you will get it, otherwise, you'll get the
            // default value for that value type insted of getting an exception;
            // Console.WriteLine("Value: " + date.Value);
        }
    }
}
