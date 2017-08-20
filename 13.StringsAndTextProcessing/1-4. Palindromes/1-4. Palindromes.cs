using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ', '?', '.', '!' }
            , StringSplitOptions.RemoveEmptyEntries).ToArray();

            SortedSet<string> palindroms = new SortedSet<string>();

            foreach (var item in input)
            {
                if ((IsPalindrom(item) && !palindroms.Contains(item)) || item.Length == 1)
                {
                    palindroms.Add(item);
                }
            }

            Console.WriteLine(string.Join(", ", palindroms));
        }

        private static bool IsPalindrom(string input)
        {
            bool isPalindrom = false;

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] == input[input.Length - i - 1])
                {
                    isPalindrom = true;
                }

            }
            return isPalindrom;
        }
    }
}
