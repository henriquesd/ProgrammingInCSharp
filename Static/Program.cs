using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Math class is static; Notice that we don't need to instantiate the Math object
            // to call the Round method;
            double r = Math.Round(35.3);
            Console.WriteLine(r);

            // Accelerate is static; static says that we don't have to instantiate
            // an object of car, to be able to access 'Accelerate';
            // The car class exposes the static Accelerate method, but not the SlowDown method;
            Car.Accelerate();
            
            // An instantiated object will not see the Accelerate method because it is static;
            Car c = new Car();
            c.SlowDown();


            Console.ReadLine();
        }
    }

    // The Car class has a static method, and a non-static method;
    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating...");
        }

        public void SlowDown()
        {
            Console.WriteLine("Car is slowing down...");
        }
    }
}
