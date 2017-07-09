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
            string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (input[0] != "end")
            {
                string dictKey = input[0];
                var dictValue = 0;

                if (int.TryParse(input[1], out dictValue))
                {
                    if (dict.ContainsKey(input[0]))
                    {
                        dict[input[0]] = dictValue;
                    }
                    else
                    {
                        dict.Add(dictKey, dictValue);
                    }
                }
                else
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        dict[dictKey] = dict[input[1]];
                    }
                    else
                    {
                        break;
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }

        }
    }
}
