using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Bob"); // use the Patient functionalities;

            Child c = new Child();
            c.Examine("Billy"); // Use both Patient and Child functionalities;
            c.Inoculate();

            UnderFive uf = new UnderFive();
            uf.Examine("Luke");
            uf.Inoculate();

            Console.ReadLine();
        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pName)
        {
            Console.WriteLine("Examination of " + pName + " completed.");
        }

        public void Billing(long ssn)
        {
            Console.WriteLine("Billing completed");
        }
    }

    public class Child : Patient
    {
        public void Inoculate()
        {
            Console.WriteLine("Child has been innoculated.");
        }
    }
    
    public class UnderFive : Child
    {
        public void UnderFiveMethod()
        {
            Console.WriteLine("UnderFive method has been called.");
        }
    }
}
