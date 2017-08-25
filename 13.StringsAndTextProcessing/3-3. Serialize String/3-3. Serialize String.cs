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

            Dictionary<char, List<int>> parameters = new Dictionary<char, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                var index = i;

                if (!parameters.ContainsKey(letter))
                {
                    parameters.Add(letter, new List<int>());
                    parameters[letter].Add(index);
                }
                else
                {
                    parameters[letter].Add(index);
                }
            }

            foreach (KeyValuePair<char, List<int>> item in parameters)
            {
                Console.WriteLine($"{item.Key}:" + string.Join("/", item.Value));
            }
        }
    }
}
