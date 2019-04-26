using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExecuteWithError();
            // ExecuteWithoutError();
            ExecuteWithErrorUsingExceptionClass();

            Console.ReadLine();
        }

        private static void ExecuteWithErrorUsingExceptionClass()
        {
            int a = 4;
            int b = 0;

            try
            {
                Console.WriteLine(a + " divided by " + b + " is: " + a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred..." + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally has been called...");
            }

            Console.WriteLine("...the program continues...");
        }

        private static void ExecuteWithoutError()
        {
            int a = 4;
            int b = 2;

            try
            {
                Console.WriteLine(a + " divided by " + b + " is: " + a / b);
            }
            catch
            {
                Console.WriteLine("An error has occurred...");
            }
            finally
            {
                Console.WriteLine("Finally has been called...");
            }

            Console.WriteLine("...the program continues...");
        }

        private static void ExecuteWithError()
        {
            int a = 4;
            int b = 0;

            try
            {
                Console.WriteLine(a + " divided by " + b + " is: " + a / b);
            }
            catch
            {
                Console.WriteLine("An error has occurred...");
            }
            finally
            {
                Console.WriteLine("Finally has been called...");
            }

            Console.WriteLine("...the program continues...");
        }
    }
}
