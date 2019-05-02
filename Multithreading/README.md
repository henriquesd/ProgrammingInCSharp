# Thread

### Managing a Thread
Once a new thread is started, there are a number of properties and methods that cant be called to manage it
- The IsAlive property returns true until the thread ends
- Each thread has a Name property useful for debugging
- Thread.CurrentThread gives you the currently executing thread
- A running thread can be paused using Thread.Sleep
- you can wait for another thread to end by calling its Join method
- You check to see if a thread is blocked by cheking its ThreadState property
- a thread's Priority property determines how much execution time it gets relative to other threads


There are two types of threads
- Foreground threads
- Background threads

Foreground threads
- Keep the application alive for as long as they are running
- When completed, the application ends and any background threads terminate immediately
- By default, threads that are explicity created are foreground threads

Background threads
- Threads that are terminated automatically when all foreground threads are closed or completed
- Created by setting the IsBackground property to true
- IsBackground can be used to change a thread's status
- Excellent for tasks like polling services or logging info


-------------------------------------------------------------------------------------------------------------
Font:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483/