using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string first = string.Empty;
                string last = string.Empty;
                string index = string.Empty;

                for (int i = 0; i < input.Length / 2; i++)
                {
                    first = first + input[i];

                    last = input[input.Length - 1 - i] + last;

                    if (first == last)
                    {
                        index = first;
                    }
                }

                if (index.Length > 0)
                {
                    string core = input
                        .Substring(index.Length, input.Length - (index.Length * 2));

                    if (core.Length > 0)
                    {
                        Console.WriteLine(core + index + core);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
