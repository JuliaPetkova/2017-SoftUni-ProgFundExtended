using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3.Serialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                var index = i;

                if (!dict.ContainsKey(letter))
                {
                    dict.Add(letter, new List<int>());
                    dict[letter].Add(index);
                }
                else
                {
                    dict[letter].Add(index);
                }
            }

            foreach (KeyValuePair<char, List<int>> item in dict)
            {
                Console.WriteLine($"{item.Key}:" + string.Join("/", item.Value));
            }
        }
    }
}
