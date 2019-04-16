The .NET Framework stores items in memory in one of two locations:
- Stack
- Heap

- Value types are stored on the Stack;
- Reference types are stored on the Heap (but there are partially stored on the Stack);

-------------------------------------------------------------------------------------------------------------

Value types:
Each variable is stored on the stack in the order it was created.
Each variable stores its own data.

A data type is a value type if it holds a data value within its own memory space. It means variables of these data types directly contain their values.


Reference types:
The variable is stored on the stack.
The data is stored on the heap.

The variable is stored on the stack, but the data for that reference type is stored on the heap, and then there is a pointer from the
variable on the stack to the heap (we have to use garbage collection or something a little more sotisticated to clean that data out).

Unlike value types, a reference type doesn't store its value directly. Instead, it stores the address where the value is being stored.
In other words, a reference type contains a pointer to another memory location that holds the data.

-------------------------------------------------------------------------------------------------------------

The following data types are all of value type:
bool
byte
char
decimal
double
enum
float
int
long
sbyte
short
struct
uint
ulong
ushort


The following data types are of reference type:
String
All arrays, even if their elements are value types
Class
Delegates


-------------------------------------------------------------------------------------------------------------
Fonts:

https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/