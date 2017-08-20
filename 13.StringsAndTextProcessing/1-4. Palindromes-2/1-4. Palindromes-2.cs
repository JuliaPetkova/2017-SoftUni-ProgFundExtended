using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Palindromes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '?', '.', '!' }
                             , StringSplitOptions.RemoveEmptyEntries).ToArray();

            SortedSet<string> result = new SortedSet<string>();

            foreach (var item in input)
            {
                string reversedItem = new string(item.Reverse().ToArray());

                if (item == reversedItem)
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
