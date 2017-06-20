using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] result = new string[input.Length];


            for (int cnt = 0; cnt < input.Length - 1; cnt++)
            {
                result[cnt + 1] = input[cnt];
                result[0] = input[input.Length - 1];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
