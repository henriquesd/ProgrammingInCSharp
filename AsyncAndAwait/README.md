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
Font:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
