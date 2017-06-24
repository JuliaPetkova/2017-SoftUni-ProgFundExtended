using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelsize = int.Parse(Console.ReadLine());

            int rounds = 0;

            while (input.Count > camelsize)
            {
                rounds++;
                input.RemoveAt(0);
                input.RemoveAt(input.Count - 1);
            }

            if (rounds == 0)
            {
                Console.WriteLine("already stable: " + string.Join(" ", input));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", input));
            }
        }
    }
}
