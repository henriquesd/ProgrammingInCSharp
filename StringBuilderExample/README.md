StringBuilder

In C#, a string is an object of type String whose values is text.
- Internally, the text is stored as sequential read-only collection of Char objects.

The string keyword is an alias for String.

The String class provides many methods for safely creating, manipulating, and comparing strings.

String objects are immutable
- They cannot be changed after they have been created.
- All methods and operators that appear to modify a string in C#, actually delete the old string and create a new one that look just
like the old one with the approprieted changes made to the content.

String operations in .NET are highly optimized
- Under most conditions their use will not impact performance.
- Looping functions that execute hundreds of thousands of times performing string operations can affect performance.

The StringBuild class creates a string buffer that provides better performance in these situations (The StringBuild class
creates a string in a little different way it creates a buffer (almost like an array), and instead of dropping and recreating it,
actually goes into the buffer and makes the appropriate changes).


-------------------------------------------------------------------------------------------------------------
Font:

https://www.udemy.com/programming-in-microsoft-c-exam-70-483
