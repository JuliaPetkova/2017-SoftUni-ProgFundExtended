using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var point2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int a = Math.Abs(point1[0] - point2[0]);
            int b = Math.Abs(point1[1] - point2[1]);

            var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"{c:F3}");
        }
    }
}
