using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!words.ContainsKey(input[i]))
                {
                    words.Add(input[i], 2);
                }
                words[input[i]]++;
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> item in words)
            {
                //Console.WriteLine($"{item.Key} ==> {item.Value}");
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
