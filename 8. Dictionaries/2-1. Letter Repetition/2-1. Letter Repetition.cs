using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 0);
                }
                chars[input[i]]++;
            }

            foreach (KeyValuePair<char, int> item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
