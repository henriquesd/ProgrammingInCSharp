# Garbage Collection

.NET's garbage collector manages the allocation and release of memory for your application. Each time you
create a new object, the common language runtime allocates memory for the object from the managed heap.
As long as address space is available in the managed heap, the runtime continues to allocate space for
new objects. However, memory is not infinite. Eventually the garbage collector must perform a collection
in order to free some memory. The garbage collector's optimizing engine determines the best time to perform
a collection, based upon the allocations being made. When the garbage collector performs a collection, it
checks for objects in the managed heap that are no longer being used by the application and performs the
necessary operations to reclaim their memory.

-------------------------------------------------------------------------------------------------------------

### Garbage Collection Basics

- Memory management is a major concern for developers
- Unmanaged programming languages ofter exhibit one serios behavior
	- Memory leaks
	- Allocated memory that is never reclaimed
- The .NET Framework provides a functionality called Garbage Collection (GC) to avoid the vast majority of memory leaks
	- Unused, unreferenced objects are automatically removed from memory
	- GC works only on managed memory objects

There are a few details about GC that you should know
- GC does not happen immediately once an object is orphaned
- GC occurs periodically based on available memory, current memory allocation and time since the last collection
- The delay between collections can range from seconds to days
- Not all orphaned objects are reclaimed during every collection
- There are a few instances when helping the GC along is necessary
- You can force Garbage Collection to occur by calling GC.Collect();


### Dispose
- C# provides two ways to deal with memory management
	- Garbage Collection
	- Disposal

Garbage Collection
	- GC is an automatic process that takes care of memory management in most situations

Diposal
	- Some resources require explicit code to release resources fastar
	- Open files, database connections, locks, on handles and unmanaged objects
	- Disposal provides the teardown code to release resources
	- The GC reclaims the memory at a later date

- Disposal is supported via the IDisposable interface
	- Includes a single method
	- void Dispose();

- There are two ways to implement Disposal
	- Calling the Dispose() method
	- The 'using' statement

- The 'using' statement automatically calls Dispose on objects that implement IDisposable

	using (FileStream f = new FileStream("aFile.txt", FileMode.Open))
	{
		// Code that writes to the file...
	}

- The compiler converts this to a try/finally construct that includes Dispose() in the finally block
	- Ensures that Dispose is called even when an exception is thrown or the code exits the try block early

- When should Dispose() be used?
	- Simple rule: When in doubt, dipose
	- Windows forms controls, file or network streams, network connections, etc.
	- Whenever the connection/state on the resource side is as important as memory management is on the application side


### Finalizers

- A Finalizer is the opposite of a constructor
	- A constructor is the first opportunity to work with an object
	- A finalizer is the last opportunity to work with an object
	- A finalizer is a method whose name begins with a ~

- Finalizers should only be used when necessary
	- Slow the allocation and collection of memory
	- Prolong the life of objects
	- Impossible to predict the order in which finalizers for a set of objects will be called
	- If code in a finalizer blocks, references other finalizable objects, or throws exceptions, finalization will not occur


### IDisposable

- Applications function by creating objects
	- Create and maintain connections to resources
	- Required memory
- Objects should be 'cleaned up' when their use is no longer required
- Objects fall into two categories in a .NET application
	- Managed
	- Unmanaged

- Managed
	- Managed objects are automatically cleaned up by the Garbage Collection functionality

- Unmanaged
	- Non-.NET objects are not cleaned up by Garbage Collection and must be explicitly closed/removed
	- This process is called Disposal

- The .NET Framework defines an interface for types requiring explicit disposal actions
	- IDisposable
	- Defines a single method: void Dispose()
- A single method seems to suggest simplicity
	- Provide code for Dispose() and you're done, right? Not exactly...
		Microsoft suggests a pattern for implementing IDisposable

- IDisposable should only be implemented when unmanaged resources are being used
- Implementing IDisposable can introduce inefficiencies due to the overhead of the finalization processs
- Microsoft suggests using a pattern when implementing IDisposable
	- Let's examine the Basic Dispose Pattern

- The Dispose Pattern is intended to standardize the usage and implementation of finalizers and the IDisposable interface

-------------------------------------------------------------------------------------------------------------

- Garbage collection is automatic memory management
- De-referenced objects (orphans) are not collect immediately but periodically
	- Many factor influence Garbage Collection frequency
	- Not all orphans are collected at the same time
- Garbage Collection is computationally expensive

-------------------------------------------------------------------------------------------------------------

Forcing Garbage Collection
- In most cases, let the Garbage Collector do its thing
- For a periodic activity it may make sense to force the collector to run:
	- Windows Serrvice

GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();


- If an object consumes many resources when instantiated
- If you want to proactively free expensive resources
	- You don't want to force a full collection cycle
- Force Garbage Collection?
	- Implement IDisposable


Disposable Objects
- Some objects need explicit code to release resources
- The IDisposable interface marks that these types implement the Dispose method
- The simple dispose pattern works well for simple scenarios and sealed types
	- use the advanced pattern in most cases


	interface IDisposable
	{
		void Dispose();
	}

	public class Demo : IDisposable
	{
		public void Dispose()
		{
			// release resources
		}
	}

-------------------------------------------------------------------------------------------------------------
Fonts:

https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/
https://www.udemy.com/programming-in-microsoft-c-exam-70-483
Programming in C# (4/8) Code Reflection and Working with Garbage Collection (https://youtu.be/1G2IhEdb6lA)