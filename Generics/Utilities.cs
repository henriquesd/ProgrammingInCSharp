using System;

namespace Generics
{
    // five type of constraints:
    // where T : IComparable // as in applying a constraint to an interface;
    // where T : Product // as in applying a constraint to a class;
    // where T : struct // for T should be a value type;
    // where T : class // for T has to be a reference type;
    // where T : new() // T is an object that has a default constructor;


    // A constraint to an interface;
    // use the ", new()" to add a constraint to a default constructor;
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // an generic method;
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    //public class Utilities
    //{
    //    public int Max(int a, int b)
    //    {
    //        return a > b ? a : b;
    //    }

    //    // an generic method;
    //    public T Max<T>(T a, T b) where T : IComparable
    //    {
    //        return a.CompareTo(b) > 0 ? a : b;
    //    }
    //}
}
