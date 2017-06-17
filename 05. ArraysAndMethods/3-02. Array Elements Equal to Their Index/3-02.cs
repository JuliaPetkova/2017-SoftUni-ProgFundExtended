using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == i)
                {
                    result += i + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
