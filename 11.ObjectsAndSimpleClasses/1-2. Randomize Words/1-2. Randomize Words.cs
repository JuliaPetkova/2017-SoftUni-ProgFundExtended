using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var randomPosition = random.Next(0, input.Length);

                var temp = input[randomPosition];
                input[randomPosition] = input[i];
                input[i] = temp;
            }

            Console.WriteLine(string.Join("\r\n", input));

        }
    }
}
