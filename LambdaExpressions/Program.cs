using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoWithoutLambda();
            Console.WriteLine("-----------------------------");

            Demo1WithLambda();
            Console.WriteLine("-----------------------------");

            Demo2WithLambda();
            Console.WriteLine("-----------------------------");

            Demo3WithoutLambda();
            Console.WriteLine("-----------------------------");

            Demo4WithLambda();

            Console.ReadLine();
        }
        
        #region Demo without Lambda
        private static void DemoWithoutLambda()
        {
            Console.WriteLine(Square(5));

        }
        static int Square(int number)
        {
            return number * number;
        }
        #endregion

        #region Demo 1 with Lambda
        private static void Demo1WithLambda()
        {
            // the syntax for a lambda expression is something like this:
            // args => expression
            // read this as: args goes to some expression;
            // number => number * number; // this is the same of the Square method below;

            // In this case, because the square method takes an integer on parameter and returns an integer, we use Func of int and int;
            // Func<int, int> square = Square;


            // If we don't need any arguments, we need to write a lambda expression like this:
            // () => ...
            // If we have one argument, we can use just the argumento by itself without using parentheses:
            // x => x...
            // And if we have multiple argumentos, we should always surround them in parentheses:
            // (x, y, x) => ...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
        }
        #endregion

        #region Demo 2 with Lambda
        private static void Demo2WithLambda()
        {
            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);

            Console.WriteLine(result);
        }
        #endregion

        #region Demo 3 without Lambda expression
        private static void Demo3WithoutLambda()
        {
            var books = new BookRepository().GetBooks();

            // A Predicate (see in FindAll method parameter) is basically a delegate which points to a method that gets a book, in this case, because it's of type book,
            // and returns a boolean value specifying if a given condition was satisfied;
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        // example of a Predicate method:
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        #endregion

        #region Demo 4 with Lambda expression
        private static void Demo4WithLambda()
        {
            var books = new BookRepository().GetBooks();

            // A Predicate (see in FindAll method parameter) is basically a delegate which points to a method that gets a book, in this case, because it's of type book,
            // and returns a boolean value specifying if a given condition was satisfied;
            var cheapBooks = books.FindAll(b => b.Price < 10); // this lambda expression is exactly equivalent to the IsCheaperThan10Dollars method;

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
        #endregion
    }
}
