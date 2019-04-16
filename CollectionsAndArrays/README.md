﻿There are two ways to create and manage groups of related objects in C#:
- Creating an array of objects
- Creating a collection of objects

- Arrays store multiple variables of the same type in an array data structure.
- Collections provide a flexible way to work with groups of objects
	- Unlike arrays, the group of objects can grow and shrink dynamically
	- There are a number of different kinds of collections


-------------------------------------------------------------------------------------------------------------
Collections

For many applications, you want to create and manage groups of related objects.
There are two ways to group objects: by creating arrays of objects, and by creating collections of
objects.

Arrays are most useful for creating and working with a fixed number of strongly-typed objects.

Collections provide a more flexible way to work with groups of objects. Unlike arrays, the group of
objects you work with can grow and shrink dynamically as the needs of the application change. For
some collections, you can assign a key to any object that you put into the collection so that you
can quickly retrieve the object by using the key.

A collection is a class, so you must declare an instance of the class before you can add elements to
that collection.

If your collection contains elements of only one data type, you can use one of the classes in the
System.Collections.Generic namespace. A generic collection enforces type safety so that no other
data type can be added to it. When you retrieve an element from a generic collection, you do not
have to determine its data type or convert it.

-------------------------------------------------------------------------------------------------------------
Arrays

You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements.

type[] arrayName;


-------------------------------------------------------------------------------------------------------------
Fonts:
https://www.udemy.com/programming-in-microsoft-c-exam-70-483/
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/index