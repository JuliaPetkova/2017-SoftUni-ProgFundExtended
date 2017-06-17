using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = HelloName();
            Console.WriteLine($"Hello, {str}!");
        }

        static object HelloName()
        {
            string name;
            name = Console.ReadLine();
            return name;
        }
    }
}
