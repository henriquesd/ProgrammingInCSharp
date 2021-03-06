﻿using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new thread and execute the WriteX method on the thread;
            Thread t = new Thread(WriteX);
            t.Start();

            // This will run on the main thread;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }

            Console.ReadLine();
        }

        // This will run on the new thread
        // The processor will allocate slices of time to each thread.
        // Usually around 20ms each;
        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }
        }
    }
}
