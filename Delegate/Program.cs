using System;

namespace Delegate
{
    class Program
    {
        delegate int del(int x, int y);

        static void Main(string[] args)
        {
            Demo1();

            Console.WriteLine("-----------------------------");

            Demo2();

            Console.ReadLine();
        }

        #region Demo 1
        private static void Demo1()
        {
            Test test = new Test();
            del d = test.AddNumbers;
            Console.WriteLine(d(3, 4));

            d = test.MultiplyNumbers;
            Console.WriteLine(d(3, 4));

            d = test.DoAnotherThing;
            Console.WriteLine(d(3, 4));
        }
        #endregion

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

        #region Demo 2

        private static void Demo2()
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            Console.WriteLine("------------");

            var processorWithAction = new PhotoProcessorAction();

            Action<Photo> filterHandlerWithAction = filters.ApplyBrightness;
            filterHandlerWithAction += filters.ApplyContrast;
            filterHandlerWithAction += RemoveRedEyeFilter;

            processorWithAction.ProccessAction("photo.jpg", filterHandlerWithAction);
        }

        // If I need a filter that was not released with the framework, I can create my own here;
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
        #endregion

    }
}