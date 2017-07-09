using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3.Mirror_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            while (true)
            {
                string print = Console.ReadLine().ToLower();
                if (print == "print")
                {
                    break;
                }
                int index = int.Parse(print);
                for (int i = 0; i < index / 2; i++)
                {
                    string temp = input[i];
                    input[i] = input[index - i - 1];
                    input[index - i - 1] = temp;
                }

                Array.Reverse(input);
                for (int i = 0; i < (input.Length - 1 - index) / 2; i++)
                {
                    string temp = input[i];
                    input[i] = input[input.Length - 2 - index - i];
                    input[input.Length - 2 - index - i] = temp;
                }

                Array.Reverse(input);

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
