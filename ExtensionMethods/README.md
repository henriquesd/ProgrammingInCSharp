Extension Methods

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or
otherwise modifying the original type. Extension methods are a special kind of static method, but they are called as if
they were instance methods on the extended type. For client code written in C#, F# and Visual Basic, there is no apparent
difference between calling an extension method and the methods that are actually defined in a type.

The most common extension methods are the LINQ standard query operators that add query functionality to the existing
System.Collections.IEnumerable and System.Collections.Generic.IEnumerable<T> types.


Sometimes you'd like to add a particular functionality to a class that already exists
Extension methods provide a way to do this
- Without creating a new derived type
- Without recompiling
- Without modifying the original type

An extension method is actually a static method in a static class
- The 'this' modifier is applied to the first method parameter
- The type of the first parameter is the type that will be extended

-------------------------------------------------------------------------------------------------------------

What are Extension Methods?

Allow us to add methods to an existing class without:
- changing its source code or,
- creating a new class that inherits from it

-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.udemy.com/csharp-advanced