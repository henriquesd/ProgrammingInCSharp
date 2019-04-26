using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // the original string is removed, and than it's created a new object with the concatenated results;
            string s1 = "This is an example of ";
            s1 = s1 + "string concatenation";
            Console.WriteLine(s1);

            // it's actual what we would think of with concatenation where it just append that to the current string;
            StringBuilder sb2 = new StringBuilder("This is an example of");
            sb2.Append(" string concatenation");
            Console.WriteLine(sb2);

            sb2.AppendLine();
            sb2.Append(" using StringBuilder...");
            Console.WriteLine(sb2);

            // change "StringBuilder" to "the String Builder class" without dropping and recreating objects;
            sb2.Replace("StringBuilder", "the String Builder class...");
            Console.WriteLine(sb2);

            Console.ReadLine();
        }
    }
}
