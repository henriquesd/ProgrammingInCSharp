Delegate
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
Font:

https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/