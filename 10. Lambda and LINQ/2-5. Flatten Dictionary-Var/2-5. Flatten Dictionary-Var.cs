using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.Flatten_Dictionary_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();

                if (tokens[0] != "flatten")
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!data.ContainsKey(key)) //използва се, когато има вложено Dictionary
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }

                    if (!data[key].ContainsKey(innerKey))
                    {
                        data[key].Add(innerKey, innerValue);
                    }
                    data[key][innerKey] = innerValue;
                }
                else
                {
                    string key = tokens[1];
                    data[key] =
                        data[key]
                            .ToDictionary(x => x.Key + x.Value, x => "flatten");
                }

                input = Console.ReadLine();
            }
           
            // сортираме по големина на key

            Dictionary<string, Dictionary<string, string>> orderedDataDict =
                data
                  .OrderByDescending(x => x.Key.Length)
                  .ToDictionary(x => x.Key, x => x.Value);

            // две нови Dictionary: от нормални стойности и с флатнати стойности, сортирани по условие

            foreach (var item in orderedDataDict)
            {
                Console.WriteLine($"{item.Key}");

                Dictionary<string, string> orderedInnerDict =
                    item.Value
                        .Where(x => x.Value != "flatten")
                        .OrderBy(x => x.Key.Length)
                        .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenDict =
                      item.Value
                        .Where(x => x.Value == "flatten")
                        .ToDictionary(x => x.Key, x => x.Value);

                int id = 1;

                foreach (var pair in orderedInnerDict)
                {
                    Console.WriteLine("{0}. {1} - {2}", id, pair.Key, pair.Value);
                    id++;
                }

                foreach (var pair in flattenDict)
                {
                    Console.WriteLine("{0}. {1}", id, pair.Key);
                    id++;
                }
            }
        }
    }
}
