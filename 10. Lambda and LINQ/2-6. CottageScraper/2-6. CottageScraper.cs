using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<KeyValuePair<string, int>>();

            var input = Console.ReadLine();

            while (input != "chop chop")
            {
                string[] tokens = input.Split();
                string wood = tokens[0];
                int heigh = int.Parse(tokens[2]);

                data.Add(new KeyValuePair<string, int>(wood, heigh));

                input = Console.ReadLine();
            }

            string woodType = Console.ReadLine();
            int heighMin = int.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round(data.Average(d => d.Value), 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");

            var used = data.Where(d => d.Key == woodType && d.Value >= heighMin).Sum(d => d.Value);
            double usedPrice = Math.Round((used * pricePerMeter), 2);

            var unused = data.Where(d => d.Key != woodType || d.Value < heighMin).Sum(d => d.Value);
            double unusedPrice = Math.Round((unused * pricePerMeter * 0.25), 2);

            Console.WriteLine($"Used logs price: ${usedPrice:F2}");

            Console.WriteLine($"Unused logs price: ${unusedPrice:F2}");

            Console.WriteLine($"CottageScraper subtotal: ${(usedPrice + unusedPrice):F2}");

            //foreach (KeyValuePair<string, int> item in data)
            //{
            //    string wood = item.Key;
            //    var heihg = item.Value;
            //    Console.WriteLine($"{wood} -> {heihg}");
            //}
        }
    }
}
