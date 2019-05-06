using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine();

            Adult a = new Adult();
            a.Examine();

            Patient pa = new Adult();
            pa.Examine();

            Console.ReadLine();
        }
    }

    public class Patient
    {
        // The virtual keyword is used to modify a method, property, indexer, or event declaration
        // and allow for it to be overridden in a derived class;
        public virtual void Examine()
        {
            Console.WriteLine("The patient has been examined");
        }
    }

    public class Adult : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The adult has been examined");
        }
    }
}
