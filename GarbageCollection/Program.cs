using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            y.x();
        }

        public static class y
        {
            public static void x()
            {
                var path = "c:/temp/test.txt";

                var file = File.Open(path, FileMode.Open);

                // here will faill;
                // var file2 = File.Open(path, FileMode.Open);
                file.Close();

                // here will work;
                var file2 = File.Open(path, FileMode.Open);
                file2.Close();


                using (var file3 = File.Open(path, FileMode.Open))
                {
                    // TODO
                }

                var file4 = File.Open(path, FileMode.Open);
                file4.Close();

            }
        }
    }
}
