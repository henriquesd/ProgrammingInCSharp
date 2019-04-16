using System;
using System.Collections.Generic;

namespace CollectionsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteCollection();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            int[] a1 = new int[] { 1, 3, 5, 7, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadLine();
        }

        private static void ExecuteCollection()
        {
            // Create a collection that is a list of strings;

            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Retriever");

            // foreach to move throught the list;
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");
            }

            Console.WriteLine("-----------------------------");
            dogs.Remove("Collie");
            Console.WriteLine("Removed Collie");

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Dog on position 1: ");
            // acessing by position;
            Console.WriteLine(dogs[1]);
        }

        private static void ArrayExamples()
        {
            // The following example creates single-dimensional, multidimensional, and jagged arrays:

            // Declare a single-dimensional array 
            int[] array1 = new int[5];

            // Declare and set array element values
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
