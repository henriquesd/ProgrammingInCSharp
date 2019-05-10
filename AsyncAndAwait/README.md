Async and Await

What's the difference between synchronous and asynchronous proccesing?
- This is synchronous processing:
	- Man walks into a bar, orders a drink, waits, gets drink, calss home
- This is asynchronous processing:
	- Man walks into bar, orders a drink, calls home while bartender prepares the drink


Computers are designed to carry out actions synchronously
- Complete task A, then complete task B

Assynchronous processing makes this more efficient
- Task A runs on the main thread
- Task B runs on a separate thread at the same time

Programming asynchronously is challenging
- C# 5 introduced two keywords to simplify asynchronous processing
	- Async and Await

Async is used to mark a method to inform the compiler to look for the Await keyword
- The await keyword tells the compiler that the Async method can't continue past that point until the awaited
asynchronous process is complete
- In the meantime, control returns to the caller of the Async method
- Async caller and Await method run simultaneously

-------------------------------------------------------------------------------------------------------------

Synchronous Program Execution
- Program is executed line by line, one at a time.
- When a function is called, program execution has to wait until the function returns. before it continues execution to the next line.


Asynchronous Program Execution
- When a function is called, program execution continues to the next line, without waiting for the function to complete.


So what's the difference?
- Asynchronous programming improves responsiveness.

When to use asynchronous?
- Acessing the Web
- Working with files and databases
- Working with images

How do we do that?
- Traditional approaches:
	- Multi-threading
	- Callbacks
- New approach since .NET 4.5
	- Async / Await



-------------------------------------------------------------------------------------------------------------
Fonts:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://www.udemy.com/csharp-advanced/