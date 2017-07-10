using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            SortedDictionary<string, long> dict = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var tokens = input.Split();

                var key = tokens[0];
                var value = tokens[tokens.Length - 1];

                long number;
                bool isKeyNumber = long.TryParse(key, out number);

                if (isKeyNumber)
                {
                    dict.Add(value, number);
                }
                else
                {
                    dict.Add(key, long.Parse(value));
                }

                input = Console.ReadLine();                 
            }

            foreach (KeyValuePair<string, long> item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
