# Nullable Types

In C# a value type cannot have null. So if you define a bool, it can have either a true or a false.
But there are situations that you would also like to cater for null values. For example, if you're working
with a database and you have a table called Customers which has a column called Birthdate.
Birthdate can be nullable because not everyone wants to put in their birthdate. In that case, if you want
to map that table to a C# class, that's one of the cases where you use a nullable type (see the example on code).


-------------------------------------------------------------------------------------------------------------
Font:

https://www.udemy.com/csharp-advanced/