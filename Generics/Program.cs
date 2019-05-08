using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo1();

            Console.WriteLine("-----------------------------");

            Demo2();

            Demo3();

            Console.ReadLine();
        }

        #region Demo1

        private static void Demo1()
        {
            // The non-generic way to create a list
            // We'll add integers to this list
            // The integers are upcast to Object type when added;
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);

            // we can add strings and integers together in a list without any warning or compile-time error;
            // on the foreach loop, we will get an invalid cast;
            // list1.Add("Hello");

            Console.WriteLine("Non-Generic List Results:");
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }

            // Using a generic List;
            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(9);
            list2.Add(21);
            // If we try to add a string to the list we get an error;
            // list2.Add("Hello");

            Console.WriteLine("Generic List Results:");

            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Demo 2
        private static void Demo2()
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            // 
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            // we get code reusability and we don't have that performance penalty
            // at runtime our GenericList is actually a list of books, it's not a list of objects, so there is no casting or boxing;


            // Where all the generic collection are in .NET:
            // System.Collections.Generic.

            var dictonary = new GenericDictionary<string, Book>();
            dictonary.Add("1234", new Book());
        }

        #endregion

        #region Demo 3
        private static void Demo3()
        {
            // You don't really have to go and create this Nullable class, it's actually part of .NET Framework
            // You can find it in System.Nullable;
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue); ;
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var nullableInteger = new Nullable<int>();
            Console.WriteLine("Has Value ? " + nullableInteger.HasValue); ;
            Console.WriteLine("Value: " + nullableInteger.GetValueOrDefault());
        }
        #endregion
    }
}
