using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            List<string> evenList = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                double num = i + 1;
                if (num % 2 == 0)
                {
                    evenList.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join("", evenList));
        }
    }
}
