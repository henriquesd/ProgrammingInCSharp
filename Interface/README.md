# Interface

An interface contains definitions for a group of related functionalities that a class or a struct can implement.

By using interfaces, you can, for example, include behavior from multiple sources in a class. That capability is important in C#
because the language doesn't support multiple inheritance of classes. In addition, you must use an interface if you want to
simulate inheritance for structs, because they can't actually inherit from another struct or class.

-------------------------------------------------------------------------------------------------------------
What is an interface?
A contract that requires a class to implement specific functionalities

What do interfaces accomplish?
Consistent functionality
Polymorphism (the ability to call the same thing using the same names on different objects)

An interface in C# provides similar functionality for our classes
- It defines what functionalities a class must provide
- It does not provide the specific functionalities

Classes cannot inherit from more than one class.
Classes can implement more than one interface.


An interface contains definitions for a group of related functionalities that a class or a struct must provide
- Software version of a contract

An interface tells a class what it must do
- It does not tell the class how to do it

What can an interface define?
- Methods
- Properties
- Events
- Indexers

Interface members are automatically public.
Interface members can't include any access modifiers.

A class 'implements an interface
- It agrees to the terms of the contract
- It must provide an implementation for all the members defined in the interface


-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/