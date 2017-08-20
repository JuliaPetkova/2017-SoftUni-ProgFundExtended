using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalogue = new Dictionary<string, Dictionary<string, List<string>>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!catalogue.ContainsKey(continent))
                {
                    catalogue[continent] = new Dictionary<string, List<string>>();
                }
                if (!catalogue[continent].ContainsKey(country))
                {
                    catalogue[continent][country] = new List<string>();
                }
                catalogue[continent][country].Add(city);
            }
            foreach (KeyValuePair<string, Dictionary<string, List<string>>> data in catalogue)
            {
                var continent = data.Key;
                var countries = data.Value;
                Console.WriteLine($"{continent}:");

                foreach (var item in countries)
                {
                    var country = item.Key;
                    var cities = item.Value;

                    Console.WriteLine(" {0} -> {1}", country, string.Join(", ", cities));
                }
            }
        }
    }
}

