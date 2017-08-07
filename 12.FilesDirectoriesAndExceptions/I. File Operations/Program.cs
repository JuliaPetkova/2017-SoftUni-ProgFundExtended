using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace I.File_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("../../txt-txt.txt");
            Console.WriteLine( file.CreationTime);
            Console.WriteLine(file.Directory);
            Console.WriteLine(file.Extension);

        }
    }
}
