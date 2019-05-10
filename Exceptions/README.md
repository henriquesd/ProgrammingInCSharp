Exceptions
An exception is any error condition or unexpected behavior that is encountered by an executing program.
Exceptions can be thrown because of a fault in your code or in code that you call (such as a shared library), unavailable operating system resources,
unexpected conditions that the runtime encounters (such as code that can't be verified), and so on. Your application can recover from some of these
conditions, but not from others. Although you can recover from most application exceptions, you can't recover from most runtime exceptions.

In .NET, an exception is an object that inherits from the System.Exception class. An exception is thrown from an area of code where a problem has occurred.
The exception is passed up the stack until the application handles it or the program terminates.

-------------------------------------------------------------------------------------------------------------

In C# we can use exception handling to deal with unexpected or exceptional situations that arise when a program is running.


-------------------------------------------------------------------------------------------------------------
Font:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483
https://docs.microsoft.com/en-us/dotnet/standard/exceptions/
https://www.udemy.com/csharp-advanced/