using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(a => a).ToList();

            foreach (var item in input)
            {
                var temp = Math.Sqrt(item);
                if (temp == (int)temp)
                    Console.Write(item + " ");
            }
        }
    }
}
