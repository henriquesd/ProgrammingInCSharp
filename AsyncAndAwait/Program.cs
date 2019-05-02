using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the Main Thread........");
            }

            Console.ReadLine();
        }
    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            // If we comment out the await Task.Run instructions and
            // just call LongRunningOperation(), everything happens
            // synchronously... 
            // Program counts to 49, then writes 'Doing stuff..."
            //
            // Task.Run starts a background thread
            // Await means this task must complete before the rest of this method is rn
            await Task.Run(() =>
                {
                    CountToFifty();
                });

            // This will not execute until CountToFifty has completed;
            Console.WriteLine("Counting to 50 is completed");
        }

        private static async Task<string> CountToFifty()
        {
            int counter;
            for (counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("Background thread: " + counter);
            }

            return "Counter = "  + counter;
        }
    }
}
