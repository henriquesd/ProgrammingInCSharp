using System;

namespace ExplicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark m = new Mark();
            // m.DoThis();
            ((IFirst)m).DoThis();

            ((ISecond)m).DoThis();

            // ISecond mm = new Mark();
            // mm.DoThis();

            Console.ReadLine();
        }
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class Mark : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis...");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis...");
            return 5;
        }

        public void Test()
        {
            // add code;
        }
    }
}
