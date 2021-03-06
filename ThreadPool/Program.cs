﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starts a new foreground thread running the Count method
            // writes "FG" in the output;
            Thread t = new Thread(Count);
            t.Start();


            // Starts a background thread that writes "T" in the output;
            Task task = Task.Run(() =>
            {
                // The task is running on a background thread and will
                // produce 8 T's in the output;
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("BG "); // background;
                }
            }); 

            Console.ReadLine();
        }

        static void Count()
        {
            // Set this condition number higher than 8 (which is the condition in Task.Run)
            // to see that this foreground thread continues to run when the Task completes
            // Set this condition number lower than 8 to see that when this foreground thread
            // completes the background task thread ends.
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(500); // 500 milliseconds
                Console.Write("FG "); // foreground thread;
            }
        }
    }
}
