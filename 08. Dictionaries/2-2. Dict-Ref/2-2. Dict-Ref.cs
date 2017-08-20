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
            Dictionary<string, long> dict = new Dictionary<string, long>();

            var input = Console.ReadLine();

            //string[] input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "end")
            {
                var tokens = input.Split();

                var key = tokens[0];
                var value = tokens[tokens.Length - 1];

                var number = 0L;
                if (long.TryParse(value, out number))
                {
                    if (dict.ContainsKey(key))
                    {
                        dict[key] = number;
                    }
                    else
                    {
                        dict.Add(key, number);
                    }
                }
                else
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[key] = dict[value];
                    }                  
                }
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> item in dict)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }

        }
    }
}
