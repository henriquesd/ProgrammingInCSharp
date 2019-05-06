Inheritance

Inheritance is one of the fundamental attributes of object-oriented programming. It allows you to define a child class
that reuses (inherits), extends, or modifies the behavior of a parent class. The class whose members are inherited is
called the base class. The class that inherits the members of the base class is called the derived class.

C# and .NET support single inheritance only. That is, a class can only inherit from a single class. However, inheritance
is transitive, which allows you to define an inheritance hierarchy for a set of types. In other words, type D can inherit
from type C, which inherits from type B, which inherits from the base class type A. Because inheritance is transitive,
the members of type A are available to type D.

Not all members of a base class are inherited by derived classes. The following members are not inherited:
- Static constructors, which initialize the static data of a class.
- Instance constructors, which you call to create a new instance of the class. Each class must define its own constructors.
- Finalizers, which are called by the runtime's garbage collector to destroy instances of a class.

-------------------------------------------------------------------------------------------------------------

- Inheritance is one of the three pillars of object oriented programming.
- Inheritance enables you to create new classes that reuse, extend, and modify the behavior that is defined in other classes.
- Inheritance provides the ability to write code once and use it in many different locations
	- It also adds a few design options and considerations

-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/inheritance
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
