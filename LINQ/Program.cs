﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectExample();

            OrderByExample();

            ExecuteQueriesOnObjectExample();

            LambdaExpressionExample();

            SelectWhereAndForEachExample();

            GroupingExample();

            JoinExample();

            FilteringACollectionByTypeOfTheItemsInIt();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-----------------------------");

            ExampleWithAndWithoutLinq();

            LinqSyntaxExample();

            ExamplesExtensionMethods();

            Console.ReadLine();
        }

        private static void ExampleWithAndWithoutLinq()
        {
            var books = new BookRepository().GetBooks();

            // without using LINQ:
            var cheapBooksWithoutLinq = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooksWithoutLinq.Add(book);
            }

            foreach (var book in cheapBooksWithoutLinq)
                Console.WriteLine(book.Title + " " + book.Price);

            Console.WriteLine("-----------------------------");

            // with LINQ:
            var cheapBooks = books.Where(b => b.Price < 10)
                                  .OrderBy(b => b.Title);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);
           
            Console.WriteLine("-----------------------------");
        }

        private static void LinqSyntaxExample()
        {
            var books = new BookRepository().GetBooks();

            // In terms of power and flexibility, the LINQ Extension Methods syntax is more powerfull than the LINQ Query Operators
            // because internally, those keywords (from LINQ Query Operators) is translated to the LINQ Extension Methods;
            // And in more complext scenarios, there are not keywords for every extension methods that you have on LINQ Extension Methods;
            // But also in other scenarios like when you are doing it GroupBy or Grouping lists, the LINQ Query Operators syntax is more friendly and cleaner;
            // So there is no right or wrong, it really depends on the situation and on your personal choice.

            // LINQ Extension Methods (equivalent to LINQ Query Operators)
            var cheapBooksStringList = books
                                            .Where(b => b.Price < 10)
                                            .OrderBy(b => b.Title)
                                            .Select(b => b.Title);

            foreach (var book in cheapBooksStringList)
                Console.WriteLine(book);

            Console.WriteLine("-----------------------------");

            // LINQ Query Operators (equivalent to LINQ Extension Methods)
            var cheaperBooksQueryOperators = from b in books
                                             where b.Price < 10
                                             orderby b.Title
                                             select b;
            // select b.Title;

            foreach (var book in cheaperBooksQueryOperators)
                Console.WriteLine(book.Title);

            Console.WriteLine("-----------------------------");
        }

        private static void ExamplesExtensionMethods()
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods

            // Single method expects that there must be one and only one object in your collection that satisfies this condition;
            var bookSingle = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(bookSingle.Title);

            // If you are not sure if that object exist or not, you cans use SingleOrDefault; The difference is, if there are no
            // objects matching the condition, default will be returned, wich in this case would be null;
            // SingleOrDefault is safter to use because Single, if it cannot find any books that matches the given condition
            // it throws an exception, whereas, SingleOrDefault returns none;
            var bookSingleOrDefault = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Console.WriteLine(bookSingleOrDefault == null);

            // this will crash:
            // var bookError = books.Single(b => b.Title == "ASP.NET MVC++");

            Console.WriteLine("-----------------------------");

            // We also have a few other similar methods to Single, one of them is First;
            // First is used to get the first object in a collection. Optionally, you can supply a predicate, the filter;
            var bookFirst = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(bookFirst.Title + " " + bookFirst.Price);

            // Similarly, we also have a FirstOrDefault, and this is similar to SingleOrDefault;
            // So if there are no books that match this condition, this method returns null instead of throwing an exception;
            var bookFirstOrDefault = books.FirstOrDefault(b => b.Title == "C# Advanced Topics++");
            Console.WriteLine(bookFirstOrDefault == null);

            Console.WriteLine("-----------------------------");

            // We also have a method called Last or LastOrDefault
            var bookLastOrDefault = books.LastOrDefault(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(bookLastOrDefault.Title + " " + bookLastOrDefault.Price);

            Console.WriteLine("-----------------------------");

            // Another useful link extension method is Skip and Take;
            // These are used for paging data.
            // With Skip you're saying skip x records or x objects and take y;
            var pagedBooks = books.Skip(2).Take(3);
            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            Console.WriteLine("-----------------------------");


            // We also have a bunch of aggregate functions like we have in SQL:

            // For example, let's say you would like to count the number of books;
            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine("-----------------------------");

            // We also have a useful method here called Max, which is used to return an object that as assumed max of something
            // in a collection; For example, this will return a book that has the highest price:
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            // Similarly, we can have minimum price:
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);

            // We also have Sum;
            // For example, if you would like to sum this collection based on the price of books:
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);

            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice);

            Console.WriteLine("-----------------------------");
        }

        #region Select example
        private static void SelectExample()
        {
            string[] animals = { "lion", "dog", "cat", "sheep", "chiken", "bird", "spider", "duck", "salmon", "shark" };

            ExecuteAnimalsWithA(animals);

            Console.WriteLine("-----------------------------");

            int maxLength = 3;

            ExecuteAnimalsWithA(animals, maxLength);

            Console.WriteLine("-----------------------------");
        }

        private static void ExecuteAnimalsWithA(string[] animals, int? maxLength = null)
        {
            IEnumerable<string> animalsWithA;

            if (maxLength == null)
            {
                animalsWithA = from animal in animals
                               where animal.Contains("a")
                               select animal;
                Console.WriteLine("Animals with 'a':");
            }
            else
            {
                animalsWithA = from animal in animals
                               where animal.Contains("a") && (animal.Length <= 3)
                               select animal;
                Console.WriteLine("Animals with 'a' and length <= 3:");
            }

            Console.WriteLine(string.Join(",", animalsWithA));
        }
        #endregion

        #region Order by example
        private static void OrderByExample()
        {
            int[] numbers = { 5, 6, 3, 9, 12, 4, 115, 119, 512, 64, 128, 1024 };


            var numberOrderByAsc = from number in numbers
                                   orderby number ascending
                                   select number;

            Console.WriteLine("Numbers order by ascending: " + string.Join(",", numberOrderByAsc));

            var numberOrderByDesc = from number in numbers
                                    orderby number descending
                                    select number;

            Console.WriteLine("Numbers order by descending: " + string.Join(",", numberOrderByDesc));

            Console.WriteLine("-----------------------------");
        }
        #endregion

        #region Queries on Objects

        public static void ExecuteQueriesOnObjectExample()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Tod", 180, 70, Gender.Male),
                new Person("Julie", 160, 60, Gender.Female),
                new Person("Anne", 150, 45, Gender.Female),
                new Person("Anne", 165, 55, Gender.Female),
                new Person("Bob", 185, 85, Gender.Male),
                new Person("Sarah", 165, 65, Gender.Female),
                new Person("John", 175, 75, Gender.Male),
                new Person("John", 185, 95, Gender.Male),
                new Person("Karine", 170, 70, Gender.Female),
                new Person("Mary", 168, 65, Gender.Female)
            };

            var fourCharPeople = from p in people
                                 where (p.Name.Length == 4)
                                 orderby p.Weight
                                 select p;

            foreach (var item in fourCharPeople)
            {
                Console.WriteLine($"Name: {item.Name}, Weight: {item.Weight}");
            }

            var fourCharPeopleNames = from p in people
                                      where (p.Name.Length == 4)
                                      orderby p.Name
                                      select p.Name;

            foreach (var item in fourCharPeopleNames)
            {
                Console.WriteLine($"Name: {item}");
            }

            var fourCharPeopleWithTowOrders = from p in people
                                              where (p.Name.Length == 4)
                                              orderby p.Name descending, p.Height ascending
                                              select p;

            foreach (var item in fourCharPeopleWithTowOrders)
            {
                Console.WriteLine($"Name: {item.Name}, Height: {item.Height}");
            }

            Console.WriteLine("-----------------------------");
        }

        internal class Person
        {
            private string name;
            private int height;
            private int weight;
            private Gender gender;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public int Height
            {
                get
                {
                    return this.height;
                }
                set
                {
                    this.height = value;
                }
            }

            public int Weight
            {
                get
                {
                    return this.weight;
                }
                set
                {
                    this.weight = value;
                }
            }

            public Gender Gender { get; set; }

            public Person(string name, int height, int weight, Gender gender)
            {
                this.Name = name;
                this.Height = height;
                this.Weight = weight;
                this.Gender = gender;
            }
        }

        internal enum Gender
        {
            Male,
            Female
        }

        #endregion

        #region Lambda Expression example
        private static void LambdaExpressionExample()
        {
            List<int> numbers = new List<int>() { 5, 6, 3, 2, 1, 5, 6, 7, 8, 4, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            var oddNumbers = from n in numbers
                             where n % 2 == 1
                             select n;
            Console.WriteLine(string.Join(",", oddNumbers));

            var oddNumbers2 = numbers.Where(n => (n % 2 == 1));
            Console.WriteLine(string.Join(",", oddNumbers2));

            Console.WriteLine("-----------------------------");
        }
        #endregion

        #region Select, Where and ForEach example
        public static void SelectWhereAndForEachExample()
        {
            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior() { Height = 100 },
                new Warrior() { Height = 80 },
                new Warrior() { Height = 100 },
                new Warrior() { Height = 70 }
            };

            var whereExample = warriors.Where(wh => wh.Height == 100);
            var selectExample = warriors.Select(wh => (wh.Height));
            var whereAndSelectExample = warriors.Where(wh => wh.Height == 100)
                                                       .Select(wh => (wh.Height));

            foreach (var item in whereExample)
            {
                Console.WriteLine("Where example: " + item.Height);
            }

            foreach (var item in selectExample)
            {
                Console.WriteLine("Select example: " + item);
            }

            foreach (var item in whereExample)
            {
                Console.WriteLine("Where and Select example: " + item.Height);
            }

            List<int> shortWarriors = warriors.Where(wh => wh.Height == 100)
                                        .Select(wh => wh.Height)
                                        .ToList();

            Console.WriteLine(string.Join(", ", warriors));

            warriors.ForEach(w => Console.Write(w.Height + " "));

            shortWarriors.ForEach(sw => Console.WriteLine(sw));

            Console.WriteLine("-----------------------------");
        }

        internal class Warrior
        {
            public int Height { get; set; }
        }
        #endregion

        #region Grouping example
        public static void GroupingExample()
        {
            List<User> people = new List<User>()
            {
                new User("Anne", 18, Gender.Female),
                new User("Sarah", 21, Gender.Female),
                new User("Julie", 25, Gender.Female),
                new User("Bob", 25, Gender.Male),
                new User("Luke", 21, Gender.Male),
                new User("Billy", 25, Gender.Male),
                new User("Mary", 24, Gender.Female),
                new User("Maddie", 24, Gender.Female)
            };

            #region Group By
            var genderGroup = from p in people
                              group p by p.Gender;

            foreach (var person in genderGroup)
            {
                Console.WriteLine($"{person.Key}");

                foreach (var p in person)
                {
                    Console.WriteLine($"{p.Name} - {p.Gender}");
                }
            }

            Console.WriteLine("-----------------------------");

            var groupWithConditions = from p in people
                                      where p.Age > 20
                                      group p by p.Age;

            foreach (var key in groupWithConditions)
            {
                Console.WriteLine($"{key.Key}");

                foreach (var item in key)
                {
                    Console.WriteLine($"    {item.Age} {item.Name}");
                }
            }

            Console.WriteLine("-----------------------------");


            var alphabeticalGroup = from p in people
                                    orderby p.Name
                                    group p by p.Name[0];

            foreach (var key in alphabeticalGroup)
            {
                Console.WriteLine($"{key.Key}");

                foreach (var item in key)
                {
                    Console.WriteLine($"    {item.Name}");
                }
            }

            #endregion

            Console.WriteLine("-----------------------------");

            #region Grouping Introduction and Grouping By MultiKey

            var simpleGrouping = people.Where(p => p.Age > 20)
                                        .GroupBy(p => p.Gender);

            foreach (var item in simpleGrouping)
            {
                Console.WriteLine($"Gender: {item.Key}");

                foreach (var p in item)
                {
                    Console.WriteLine($" {p.Name}, {p.Age}");
                }
            }

            var alphabeticalGroup2 = people.OrderBy(p => p.Name)
                                           .GroupBy(p => p.Name[0]);

            foreach (var item in alphabeticalGroup2)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var p in item)
                {
                    Console.WriteLine($"    {p.Name}");
                }
            }

            Console.WriteLine("-----------------------------");

            var multiKey = people.GroupBy(p => new { p.Gender, p.Age }).OrderBy(p => p.Count());

            foreach (var item in multiKey)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var p in item)
                {
                    Console.WriteLine($" {p.Name}");
                }

            }
            #endregion

            Console.WriteLine("-----------------------------");
        }

        internal class User
        {
            private string name;
            private int age;
            private Gender gender;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }

            public int Age
            {
                get
                {
                    return this.age;
                }
                set
                {
                    this.age = value;
                }
            }

            public Gender Gender { get; set; }

            public User(string name, int age, Gender gender)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }

        }
        #endregion

        #region Join example
        public static void JoinExample()
        {
            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer { Name ="Johny", District ="Fantasy District", Age = 22 },
                new Buyer { Name ="Peter",  District ="Scientists District", Age = 40},
                new Buyer { Name ="Paul",  District ="Fantasy District",  Age =30},
                new Buyer { Name ="Maria",  District ="Scientists District", Age = 35},
                new Buyer { Name ="Joshua",  District ="EarthIsFlat District", Age = 40},
                new Buyer { Name ="Sylvia",  District ="Developers District", Age = 22},
                new Buyer { Name ="Rebecca",  District ="Scientists District",  Age = 30},
                new Buyer { Name ="Jaime",  District ="Developers District",  Age = 35},
                new Buyer { Name = "Pierce", District = "Fantasy District", Age = 40}
            };

            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier { Name = "Harrison", District = "Fantasy District", Age = 22 },
                new Supplier { Name = "Charles", District =  "Developers District", Age = 40 },
                new Supplier { Name = "Hailee", District =  "Scientists District", Age = 35 },
                new Supplier { Name = "Taylor", District =  "EarthIsFlat District", Age = 30 }
            };


            var innerJoin = suppliers.Join(buyers, s => s.District, b => b.District,
                (s, b) => new
                {
                    SupplierName = s.Name,
                    BuyuerName = b.Name,
                    District = s.District
                });

            foreach (var item in innerJoin)
            {
                Console.WriteLine($"District: {item.District}, Supplier: {item.SupplierName}, Buyer: {item.BuyuerName}");
            }

            var compositeJoin = suppliers.Join(buyers,
                s => new { s.District, s.Age },
                b => new { b.District, b.Age },
                (s, b) => new
                {
                    SupplierName = s.Name,
                    BuyerName = b.Name,
                    District = s.District,
                    Age = s.Age
                });

            foreach (var item in compositeJoin)
            {
                Console.WriteLine($"{item.District}, Age: {item.Age}");
                Console.WriteLine($" Supplier: {item.SupplierName}");
                Console.WriteLine($" Buyer: {item.BuyerName}");
            }


            // for inner join doesn't matter which  collection you choose first;
            var innerJoin2 = from s in suppliers
                             orderby s.District
                             join b in buyers on s.District equals b.District
                             select new
                             {
                                 SupplierName = s.Name,
                                 BuyerName = b.Name,
                                 b.District
                             };

            foreach (var item in innerJoin2)
            {
                Console.WriteLine($"District: {item.District}, Supplier: {item.SupplierName}, Buyer: {item.BuyerName}");
            }

            Console.WriteLine("-----------------------------");
        }

        internal class Buyer
        {
            public string Name { get; set; }
            public string District { get; set; }
            public int Age { get; set; }
        }

        internal class Supplier
        {
            public string Name;
            public string District;
            public int Age;
        }
        #endregion

        #region Filtering a Collection by the Type of the Items in it
        public static void FilteringACollectionByTypeOfTheItemsInIt()
        {
            object[] mix = { 1, "string", 'd', new List<int>() { 1, 2, 3, 4 }, new List<int>() { 5, 2, 3, 4 }, "dd", 'd', "Test", 1, 2, 3, 4, };

            var allIntegers = mix.OfType<int>();

            Console.WriteLine(string.Join(", ", allIntegers));

            Console.WriteLine("-----------------------------");
        }
        #endregion
    }
}
