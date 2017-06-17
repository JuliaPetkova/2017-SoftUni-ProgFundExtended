using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            long input1 = long.Parse(Console.ReadLine());
            long input2 = long.Parse(Console.ReadLine());
            long input3 = long.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(input1, GetMin(input2, input3)));
        }

        static long GetMin(long input1, long input2)
        {
            return Math.Min(input1, input2);
        }
    }
}
