# ThreadPool

Starting a new thread requires resources
- Normally a few hundred microseconds
- This can become noticeable if very many threads are being created for short operations

The ThreadPool avoids this overhead by maintaining a pool of pre-created, recyclabe threads.

There are a few things to consider about the ThreadPool
- You cannot set the Name of a pooled thread, making debugging more difficult
- Pooled threads are always background threads
- Blocking pooled threads can degrade performance
- A pooled thread's priority can be changed...it will be restored to normal when released back to the pool

The Task.Run method is new in the .NET Framework 4.5
- It starts a task that is executed on a thread from the ThreadPool
- Remember that threads from the ThreadPool are background threads


-------------------------------------------------------------------------------------------------------------
Font:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483/