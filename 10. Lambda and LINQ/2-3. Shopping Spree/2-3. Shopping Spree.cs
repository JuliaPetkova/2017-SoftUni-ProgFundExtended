using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3.Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            Dictionary<string, double> data = new Dictionary<string, double>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                var key = tokens[0];
                var value = double.Parse(tokens[1]);

                if (data.ContainsKey(key))
                {
                    if (data[key] > value)
                    {
                        data[key] = value;
                    }
                }
                else
                {
                    data[key] = value;
                }
                input = Console.ReadLine();
            }

            double sum = data.Sum(x => x.Value);

            if (sum > budjet)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                var orderedData =
                        data
                            .Reverse()
                            .OrderByDescending(x => x.Value)
                            .ThenBy(x => x.Key.Length)
                            .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in orderedData)
                {
                    Console.WriteLine($"{item.Key} costs {item.Value:F2}");
                }
            }
        }
    }
}
