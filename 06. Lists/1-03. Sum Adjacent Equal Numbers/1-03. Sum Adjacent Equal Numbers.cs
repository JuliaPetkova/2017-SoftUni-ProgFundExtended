using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();

            int sum = 0;

            bool isEqual = false;

            for (int i = 1; i < input.Count; i++)
            {
                isEqual = (input[i] == input[i- 1]);
                if (isEqual)
                {
                    sum = input[i] + input[i - 1];
                    newList.Add(sum);
                }
                i = -1;

            }

            Console.WriteLine(string.Join(" ", newList));
        }


    }
}

