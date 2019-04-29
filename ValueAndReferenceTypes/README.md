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

A reference type, as the name suggests, contains a reference to the real value; a value type
contains the value directly. 

An example of a reference type is a uniform resource locator (URL). If you read something
interesting on the web, you can send the URL to a friend and point to the correct location where
the information is stored. A value type is different. If you read an interesting article in a
magazine and you want to give it to your friend, you need to make a copy of the article and give
it directly.

This same behavior can be seen with value and reference types. In the common language
runtime (CLR) that underpins C#, there are two locations in which a type can be stored in
memory: the heap and the stack. The value of a reference type is stored on the heap, and
the address to this value is stored on the stack. Although a value type is normally stored on
the stack, there are exceptions (for example, a class that contains a value type as one of its
fields, a lambda expression that closes over a value type, or a value type that is boxed), but
this is the general idea. The benefit of storing data on the stack is that it’s faster, smaller, and
doesn’t need the attention of the garbage collector.

Value types are useful when it comes to small data structures that belong together. For example,
a point with an x and y coordinate is a candidate for a value type. As a rule of thumb, you can
check the following three criteria to determine whether you want to create a value type:
- The object is small.
- The object is logically immutable.
- There are a lot of objects.

Of course, these are still vague requirements. The only one who can determine whether
you need a value type is you. If you’re optimizing for speed or for memory usage, the only
way to determine whether a value type can improve performance is by measuring. 

All objects in C# inherit from System.Object. Value types, however, inherit from System.
ValueType (which inherits from System.Object). System.ValueType overrides some of the default
functions (such as GetHashCode, Equals, and ToString) to give them a more meaningful implementation
for a value type.

In C#, you cannot directly inherit from System.ValueType. Instead, you can use the struct
keyword to create a new value type.


- Tip
It’s important to know the different types that are available in C#. A value type should be
used for small, immutable objects that are used a lot. In all other situations, use a reference
type. 



-------------------------------------------------------------------------------------------------------------
Fonts:

https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
Book "Exam Ref 70-483: Programming in C#"