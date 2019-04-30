Boxing and Unboxing

Boxing is the process of converting a value type to the type object or to any interface type implemented by
this value type. When the CLR boxes a value type, it wraps the value inside a System.Object and stores it on
the managed heap. Unboxing extracts the value type from the object. Boxing is implicit; unboxing is explicit.
The concept of boxing and unboxing underlies the C# unified view of the type system in which a value of any
type can be treated as an object.

Performance
In relation to simple assignments, boxing and unboxing are computationally expensive processes. When a value
type is boxed, a new object must be allocated and constructed. To a lesser degree, the cast required for
unboxing is also expensive computationally.

-------------------------------------------------------------------------------------------------------------
C# is based on a unified type system
- Everything can be an object
- But there are two main types, value types and reference types
(The value types are stored on the stack, and reference types have kind of a pointer stored on the stack,
but the actual data is out there on the heap).
- Value and reference types are stored and managed differently
- Boxing provides a common way to handle both types

Example: A collection of objects has been created.
And we want to add an integer variable into the collection. (integer is a value type, and the objects
are reference types). Boxing allow this. The integer variable (the integer data) is wrapped in a System.Object
construct.
Now that integer is stored on the heap as a reference type and not on the stack as a value type.

Boxing is an implicit conversion.
Unboxing is an explicit conversion.
Excessive boxing (and unboxing) can get expensive in terms of resources and if we're doing it a lot of it
can slow our code down.

-------------------------------------------------------------------------------------------------------------
What is boxing in C#?
When a value type is converted to object type, it is called boxing.

What is unboxing in C#?
When an object type is converted to a value type, it is called unboxing.

-------------------------------------------------------------------------------------------------------------
Fonts:
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.tutorialspoint.com/csharp/csharp_interview_questions.htm