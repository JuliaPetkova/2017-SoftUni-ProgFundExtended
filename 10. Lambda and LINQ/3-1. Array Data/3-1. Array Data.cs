using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1.Array_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            double average = input.Average();

            var output = input.Where(x => x >= average).ToArray();

            string cmd = Console.ReadLine();
            if (cmd == "Min")
            {
                Console.WriteLine(output.Min(x => x));
            }

            if (cmd == "Max")
            {
                Console.WriteLine(output.Max(x => x));
            }
            if (cmd == "All")
            {
                Console.WriteLine(string.Join(" ", output.OrderBy(x => x)));
            }
        }
    }
}
