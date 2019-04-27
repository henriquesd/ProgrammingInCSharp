using System;
using System.IO;
using System.Text;

namespace StringWriterAndStringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReadWrite srw = new StringReadWrite();
            Console.ReadLine();
        }
    }

    public class StringReadWrite
    {
        StringBuilder sb = new StringBuilder();

        public StringReadWrite()
        {
            WriteData();
            ReadData();
        }

        private void WriteData()
        {
            StringWriter sw = new StringWriter(sb);

            Console.WriteLine("Please enter your first and last name...");
            string name = Console.ReadLine();

            sw.WriteLine("Name: " + name);

            // Close the sw stream object;
            sw.Flush();
            sw.Close();
        }

        private void ReadData()
        {
            StringReader sr = new StringReader(sb.ToString());

            Console.WriteLine("Reading the information...");

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine("Thank you!");

            sr.Close();
        }
    }
}
