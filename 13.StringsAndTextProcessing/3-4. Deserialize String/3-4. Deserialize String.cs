using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4.Deserialize_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dict = new SortedDictionary<int, char>();

            int index = 0;
            char letter;

            while (input != "end")
            {
                var param = input.Split(new[] { ':', '/' }).ToArray();

                letter = char.Parse(param[0]);

                for (int i = 1; i < param.Length; i++)
                {
                    index = int.Parse(param[i]);
                    dict.Add(index, letter);
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("", dict.Values));
        }
    }
}
