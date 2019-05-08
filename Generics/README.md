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

### Constraints on type parameters

Constraints inform the compiler about the capabilities a type argument must have. Without any constraints, the type argument
could be any type. The compiler can only assume the members of System.Object, which is the ultimate base class for any .NET type.

If client code tries to instantiate your class by using a type that is not allowed by a constraint, the result is a compile-time
error. Constraints are specified by using the where contextual keyword.


### The following table lists the seven types of constraints:

Constraint					Description
where T : struct			The type argument must be a value type. Any value type except Nullable<T> can be specified.
where T : class				The type argument must be a reference type. This constraint applies also to any class, interface, delegate, or array type.
where T : unmanaged			The type argument must not be a reference type and must not contain any reference type members at any level of nesting.
where T : new()				The type argument must have a public parameterless constructor. When used together with other constraints, the new() constraint must be specified last.
where T : <base class name>	The type argument must be or derive from the specified base class.
where T : <interface name>	The type argument must be or implement the specified interface. Multiple interface constraints can be specified. The constraining interface can also be generic.
where T : U					The type argument supplied for T must be or derive from the argument supplied for U.

Some of the constraints are mutually exclusive. All value types must have an accessible parameterless constructor
The struct constraint implies the new() constraint and the new() constraint cannot be combined with the struct constraint.
The unmanaged constraint implies the struct constraint. The unmanaged constraint cannot be combined with either the struct or
new() constraints.


### Why use constraints
By constraining the type parameter, you increase the number of allowable operations and method calls to those supported by the
constraining type and all types in its inheritance hierarchy. When you design generic classes or methods, if you will be
performing any operation on the generic members beyond simple assignment or calling any methods not supported by System.Object,
you will have to apply constraints to the type parameter. For example, the base class constraint tells the compiler that only
objects of this type or derived from this type will be used as type arguments. Once the compiler has this guarantee,
it can allow methods of that type to be called in the generic class.


-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.udemy.com/csharp-advanced
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters