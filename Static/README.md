Static

A static class is basically the same as a non-static class, but there is one difference: a static class cannot
be instantiated. In other words, you cannot use the new keyword to create a variable of the class type. Because
there is no instance variable, you access the members of a static class by using the class name itself.

For example, if you have a static class that is named UtilityClass that has a public static method named MethodA,
you call the method as shown in the following example:
	UtilityClass.MethodA();


A static class can be used as a convenient container for sets of methods that just operate on input parameters
and do not have to get or set any internal instance fields. For example, in the .NET Framework Class Library,
the static System.Math class contains methods that perform mathematical operations, without any requirement to
store or retrieve data that is unique to a particular instance of the Math class. That is, you apply the members
of the class by specifying the class name and the method name, as shown in the following example:

double dub = -3.14;  
Console.WriteLine(Math.Abs(dub));  
Console.WriteLine(Math.Floor(dub));  
Console.WriteLine(Math.Round(Math.Abs(dub)));  
  
// Output:  
// 3.14  
// -4  
// 3


As is the case with all class types, the type information for a static class is loaded by the .NET Framework
common language runtime (CLR) when the program that references the class is loaded. The program cannot specify
exactly when the class is loaded. However, it is guaranteed to be loaded and to have its fields initialized and
its static constructor called before the class is referenced for the first time in your program. A static
constructor is only called one time, and a static class remains in memory for the lifetime of the application
domain in which your program resides.

-------------------------------------------------------------------------------------------------------------


The static modifier changes the behavior of C# types (classes, etc) and members (methods, properties, fields, etc).

A static class or member cannot be accessed through an instance.

Classes and members can be marked as static
- In a static class, all methods in the class must be marked as static

A non-static class is used to create multiple objects based on the non-static type.
- Objects are created using the 'new' keyword

You cannot use the 'new' keyword with a static class
- Only one instance of the object ever exists

-------------------------------------------------------------------------------------------------------------

Use the static modifier to declare a static member, which belongs to the type itself rather than to a
specific object. The static modifier can be used with classes, fields, methods, properties, operators,
events, and constructors, but it cannot be used with indexers, finalizers, or types other than classes. 

-------------------------------------------------------------------------------------------------------------
Fonts:
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/