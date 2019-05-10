using System;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExecuteWithError();
            // ExecuteWithoutError();
            ExecuteWithErrorUsingExceptionClass();

            Console.WriteLine("-----------------------------");

            // ExampleCalculatorCrashingTheApplication();

            ExampleCalculator();

            Console.WriteLine("-----------------------------");

            ExampleUsingUnmanagedResources();

            Console.WriteLine("-----------------------------");

            ExampleUsingUnmanagedResourcesWithACleanerWay();

            Console.WriteLine("-----------------------------");

            ExampleThrowCustomExceptions();

            Console.ReadLine();
        }

        private static void ExampleThrowCustomExceptions()
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("henrique");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ExampleUsingUnmanagedResourcesWithACleanerWay()
        {
            try
            {
                // Basically, when you use a using statement, internally the compiler will create a finally
                // block under the hood, which will call the Dispose method of StreamReader, so you don't have to
                // manually call that;
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
        }

        private static void ExampleUsingUnmanagedResources()
        {
            // A StreamReader is a class that is used for reading files;
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"c:\file.zip");

                var content = streamReader.ReadToEnd();
            }
            // need to be from most specific to most generic;
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
            }
            // Why do we need finally block?
            // In .NET we have classes that access unmanaged resources, that is resources that are not managed by
            // CLR, so there is no garbage collection applied to them. Examples are file handles, database connections,
            // network connections, graphic handles and in situations like that we need to manually do the cleanup.
            // Any class that uses unmanaged resources is expected to implement an interface called IDisposable.
            // We use the finally block to call the Dispose method of the class that uses unmanaged resources;
            finally
            {
                
                if (streamReader != null)
                    // With this code, if anything goes wrong inside the try block during reading the file, you want to make sure
                    // that the stream would be closed. This is extremely important because if you don't manage these situations
                    // properly you will end up keeping files open on the disk or keeping network connections open or your database
                    // connections and sometimes you get out of resources.
                    streamReader.Dispose();
            }
        }

        private static void ExampleCalculator()
        {
            try
            {
                var calculator = new Calculator();
                // the code below will crash the application:
                var result = calculator.Divide(5, 0);

                Console.WriteLine(result);
            }
            // need to be from most specific to most generic;
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0.");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally will always be executed.");
            }
        }

        private static void ExampleCalculatorCrashingTheApplication()
        {
            var calculator = new Calculator();

            // the code below will crash the application:
            var result = calculator.Divide(5, 0);
            
            Console.WriteLine(result);
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
