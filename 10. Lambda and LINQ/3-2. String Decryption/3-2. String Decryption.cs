using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2.String_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoInt = Console.ReadLine();

            int[] twoIntParams = twoInt.Split().Select(int.Parse).ToArray();
            var m = twoIntParams[0];
            var n = twoIntParams[1];

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<char> output =
                    input
                         .Where(x => (x < 91 && x > 64))
                         .Skip(m)
                         .Take(n)
                         .Select(x => (char)x)
                         .ToList();

            Console.WriteLine(string.Join("", output));
        }
    }
}

