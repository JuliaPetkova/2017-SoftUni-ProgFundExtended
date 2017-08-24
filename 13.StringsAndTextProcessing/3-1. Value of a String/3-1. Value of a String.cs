using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _3_1.Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            string key = Console.ReadLine();

            BigInteger sum = 0;

            if (key == "LOWERCASE")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] >= 97 && input[i]<=122)
                    {
                        sum += input[i];
                    }
                }
            }
            if (key == "UPPERCASE")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] >= 65 && input[i] <= 90)
                    {
                        sum += input[i];
                    }
                }
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
