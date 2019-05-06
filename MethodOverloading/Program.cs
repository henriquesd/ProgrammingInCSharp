using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling();
            p.CheckBilling(1, 2);
            p.CheckBilling("a", 2);

            Child c = new Child();
            c.CheckBilling("a", "b");

            Console.ReadLine();
        }
    }

    public class Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has been checked.");
        }

        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers.");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using a submitted string and integer.");
        }
    }

    public class Child : Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing has been checked by submiting two strings.");
        }
    }
}
