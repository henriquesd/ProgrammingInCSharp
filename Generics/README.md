# Generics

Generics were added to version 2.0 of the C# language and the common language runtime (CLR). Generics introduce to the .NET Framework the concept of type
parameters, which make it possible to design classes and methods that defer the specification of one or more types until the class or method is declared
and instantiated by client code. For example, by using a generic type parameter T you can write a single class that other client code can use without
incurring the cost or risk of runtime casts or boxing operations, as shown here:

// Declare the generic class.
public class GenericList<T>
{
    public void Add(T input) { }
}
class TestGenericList
{
    private class ExampleClass { }
    static void Main()
    {
        // Declare a list of type int.
        GenericList<int> list1 = new GenericList<int>();
        list1.Add(1);

        // Declare a list of type string.
        GenericList<string> list2 = new GenericList<string>();
        list2.Add("");

        // Declare a list of type ExampleClass.
        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        list3.Add(new ExampleClass());
    }
}


Generics Overview
- Use generic types to maximize code reuse, type safety, and performance.
- The most common use of generics is to create collection classes.
- The .NET Framework class library contains several new generic collection classes in the System.Collections.Generic namespace. These should be used whenever possible instead of classes such as ArrayList in the System.Collections namespace.
- You can create your own generic interfaces, classes, methods, events and delegates.
- Generic classes may be constrained to enable access to methods on particular data types.
- Information on the types that are used in a generic data type may be obtained at run-time by using reflection.

-------------------------------------------------------------------------------------------------------------


What are generics?
- Collections that are type-safe at compile time
- A faster, safer, more efficient way to deal with collections
- Introduced in C# version 2.0
- Make it possible to design classes and methods that defer the specification of one or more types until the class or method is declared and instantiated by client code

Why do we need generics?
- Generics provide the solution to a limitation in earlier versions of the common language runtime and the C# language
- Prior to C# version 2.0, collections such as ArrayList were non-generic
- Generalization was accomplished by casting types to and from the universal base type Object
- Items (value or reference types) that were added to an ArrayList were implicity upcast to Object
- Value types require boxing to be added and unboxing when retrieved
- Boxing can seriously affect performance



-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.udemy.com/csharp-advanced