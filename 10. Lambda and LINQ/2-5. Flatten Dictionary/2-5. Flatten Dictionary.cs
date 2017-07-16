using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, string>>();

            var fltList = new List<string>();

            while (input != "end")
            {
                var tokens = input.Split();

                if (tokens.Length != 2)
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (fltList.Contains(key))
                    {
                        var concatedPairs = innerKey + innerValue;

                        if (data[key].Any(x => x.Key.Equals(concatedPairs)))
                        {
                            data[key].Remove(concatedPairs);
                        }
                    }

                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }

                    if (!data[key].ContainsKey(innerKey))
                    {
                        data[key].Add(innerKey,innerValue);
                    }
                    data[key][innerKey] = innerValue;

                }
                else
                {
                    var key = tokens[1];
                    var keyValuePapirs = new List<string>();

                    foreach (var kvp in data[key])
                    {
                        var innerKey = kvp.Key;
                        var value = kvp.Value;

                        var concatedKey = innerKey + value;
                        keyValuePapirs.Add(concatedKey);
                        keyValuePapirs.Add(value);
                    }

                    for (int i = 0; i < keyValuePapirs.Count - 1; i += 2)
                    {
                        data[key].Add(keyValuePapirs[i], string.Empty);
                    }

                    fltList.Add(key);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in data.OrderByDescending(x => x.Key.Length))
            {
                var nonFlattenKvp = kvp.Value.Where(x => x.Value != string.Empty).OrderBy(x => x.Key.Length);
                var flattenKvp = kvp.Value.Where(x => x.Value == string.Empty).ToDictionary(x => x.Key, x => x.Value);
                var count = 1;

                Console.WriteLine(kvp.Key);

                foreach (var innerKvp in nonFlattenKvp)
                {
                    var concated = innerKvp.Key + innerKvp.Value;

                    if (flattenKvp.Keys.Contains(concated))
                    {
                        continue;
                    }

                    Console.WriteLine($"{count}. {innerKvp.Key} - {innerKvp.Value}");
                    count++;
                }

                foreach (var innerKvp in flattenKvp)
                {
                    Console.WriteLine($"{count}. {innerKvp.Key}");
                    count++;
                }

            }
        }
    }
}