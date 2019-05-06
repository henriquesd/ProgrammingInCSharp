using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            GetTypeData();

            CreateAnInstanceOfAType();

            AccessingAProperty();

            InvokingAMethod();

            Console.WriteLine("------------");

            Demo();

            Console.ReadLine();
        }

        private static void Demo()
        {
            // without reflection
            var dogWithoutReflection = new Dog { NumberOfLegs = 4 };
            Console.WriteLine("A dog has {0} legs", dogWithoutReflection.NumberOfLegs);

            //// with reflection
            //object dog = Activator.CreateInstance(typeof (Dog));
            //PropertyInfo[] properties = typeof(Dog).GetProperties();
            //PropertyInfo numberOfLegsProperty1 = properties[0];

            // with reflection
            var dog = Activator.CreateInstance(typeof(Dog)) as Dog;
            // PropertyInfo properties = dog.GetType().GetProperty("NumberOfLegs");
            PropertyInfo[] properties = dog.GetType().GetProperties();
            PropertyInfo numberOfLegsProperty1 = properties[0];

            // or
            PropertyInfo numberOfLegsProperty2 = null;
            foreach (PropertyInfo propertyInfo in properties)
            {
                if (propertyInfo.Name.Equals("NumberOfLegs", StringComparison.InvariantCulture))
                {
                    numberOfLegsProperty2 = propertyInfo;
                }
            }

            numberOfLegsProperty1.SetValue(dog, 3, null);

            Console.WriteLine(numberOfLegsProperty2.GetValue(dog, null));

            // use reflection to invoke different constructors

            var defaultConstructor = typeof(Dog).GetConstructor(new Type[0]);
            var legConstructor = typeof(Dog).GetConstructor(new[] { typeof(int) });

            var defaultDog = (Dog)defaultConstructor.Invoke(null);
            Console.WriteLine(defaultDog.NumberOfLegs);

            var legDog = (Dog)legConstructor.Invoke(new object[] { 5 });
            Console.WriteLine(legDog.NumberOfLegs);
        }

        private static void InvokingAMethod()
        {
            Method();
        }

        static void Method()
        {
            var horse = new Animal();

            var type = horse.GetType();

            var method = type.GetMethod("Speak");

            var value = (string)method.Invoke(horse, null);
            // value = "Hello"

            Console.WriteLine(value);
        }

        private static void AccessingAProperty()
        {
            property();
        }

        static void property()
        {
            var horse = new Animal() { Name = "Ed" };

            var type = horse.GetType();

            var property = type.GetProperty("Name");

            var value = property.GetValue(horse, null);

            Console.WriteLine(value);
            // value = "Ed"
        }

        public class Animal
        {
            public string Name { get; set; }
            public string Speak() { return "Hello"; }
        }

        private static void CreateAnInstanceOfAType()
        {
            // There are two ways to dynamically instantiate a type:
            // - Activator.CreateInstance
            // - Calling Invoke on a ConstructorInfo object (advanced scenarios)

            var newDog = (Dog)Activator.CreateInstance(typeof(Dog));

            var genericDog = Activator.CreateInstance<Dog>();

            // uses default constructor
            // with no defined parameters
            var dogConstructor = typeof(Dog).GetConstructors()[0];

            var advancedDog = (Dog)dogConstructor.Invoke(null);
        }

        private static void GetTypeData()
        {
            // Two methods:
            // - Statically at compile time
            // - Dynamically at runtime

            var dog = new Dog { NumberOfLegs = 4 };

            // At compile time;
            Type t1 = typeof(Dog);

            // At runtime;
            Type t2 = dog.GetType();

            // output: Dog
            Console.WriteLine(t2.Name);

            Console.WriteLine(t2.Assembly);
        }

        internal class Dog
        {
            public int NumberOfLegs { get; set; }

            public Dog()
            {
                NumberOfLegs = 4;
            }

            public Dog(int legs)
            {
                NumberOfLegs = legs;
            }
        }
    }
}
