# Delegate

Delegate is an object that knows how to call a method.

A delegate is a reference type that can be used to encapsulate a named or an anonymous method.
Delegates are similar to function pointers in C++; however, delegates are type-safe and secure.


The declaration of a delegate type is similar to a method signature. It has a return value and any number of parameters of any type:
public delegate void TestDelegate(string message);
public delegate int TestDelegate(MyType m, long num);

A delegate is a type (like a class)
- It defines the method signature that can be called
- A delegate considers the method signature to include the return type and the parameter types


If you create a delegate type using this code:
	delete int d (int, int)
- The signature is: the return type (int) and the two parameters (int)
- You create a variable 'd' that is a type of delegate
- 'd' can now be used to call any method that returns an int and has two int parameters


Delegates are the basis for Events.
A delegate can be instantiated by associating it either with a named or anonymous method.
The delegate must be instantiated with a method or lambda expression that has a compatible return type and input parameters. 

-------------------------------------------------------------------------------------------------------------

# Delegates

### What is a Delegate?
- A delegate is an object that knows how to call a method (or a group of methods)
- A delegate is a reference (or a pointer) to a function
A Delegate is a pointer to a function or more accurately it's an object that knows how to call a method or a group of methods.

### Why do we need delegates?
These tecnique allows us to create applications that are extensible and flexibe. And often this is used in designing frameworks.
- For designing extensible and flexible applications (eg frameworks)
We use Delegates to achieve flexibility and extensibility. Of course, we don't need this all the time, but if you're designin an application or
a framework where extensibility or flexibility is a concern, we can use Delegates for that. Alternatively, we can use Interfaces.

Delegates are very powerful and it allows us to create applications or frameworks that are extensible and very flexible.


### Action and Func

In .NET we have two delegates that are generic: Action and Func.

The difference between Func and Action is Func points to a method that returns a value, and Action points to a method that returns void.
	System.Action<>
	System.Func<>


### Interfaces or Delegates?

Use a delegate when:
- An eventing design pattern is used.
- The caller doesn't need to access other properties or methods (or interfaces) on the object implementing the method.

In the case of the example on this project, our filters were just one basic simple method and there were no other properties
or methods. But imagine if our Photo Processor needed to access other properties or methods, obviously a Delegate wouldn't work and we
have to use an Interface.

-------------------------------------------------------------------------------------------------------------
Font:

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.udemy.com/csharp-advanced/