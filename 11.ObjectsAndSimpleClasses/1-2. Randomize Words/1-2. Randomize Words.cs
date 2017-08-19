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
            string[] input = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var randomPosition = random.Next(0, input.Length);
                var temp = input[i];
                input[i] = input[randomPosition];
                input[randomPosition] = input[i];
            }

            Console.WriteLine(string.Join("\n\r", input));
        }
    }
}
