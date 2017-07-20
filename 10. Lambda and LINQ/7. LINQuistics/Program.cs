using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LINQuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var collections = new Dictionary<string, HashSet<string>>();
            while (!(input = Console.ReadLine()).Equals("exit"))
            {
                var inputSplit = input.Split('.');

                if (inputSplit.Length == 1)
                {
                    int digit;
                    bool isDigit = int.TryParse(inputSplit[0], out digit);
                    if (isDigit)
                    {
                        if (collections.Count > 0)
                        {
                            var methodNames = collections.Values
                                .First(m => m.Count == collections.Values.Max(c => c.Count))
                                .OrderBy(m => m.Length)
                                .Take(digit);
                            foreach (var method in methodNames)
                            {
                                Console.WriteLine($"* {method}");
                            }
                        }
                    }
                    else
                    {
                        if (collections.ContainsKey(inputSplit[0]))
                        {
                            var methodNames = collections[inputSplit[0]]
                                .OrderByDescending(m => m.Length)
                                .ThenByDescending(m => m.Distinct().Count());
                            foreach (var methodName in methodNames)
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                    }
                }
                else
                {
                    string collectionName = inputSplit[0];
                    var methods = inputSplit.Skip(1);
                    if (!collections.ContainsKey(collectionName))
                    {
                        collections[collectionName] = new HashSet<string>();
                    }
                    foreach (var method in methods)
                    {
                        var noBrackets = method.Trim('(', ')');
                        collections[collectionName].Add(noBrackets);
                    }
                }
            }

            string[] lastLine = Console.ReadLine().Split();
            var searchedMethod = lastLine[0];
            var selection = lastLine[1];

            var result = collections
                .Where(c => c.Value.Contains(searchedMethod))
                .OrderByDescending(c => c.Value.Count)
                .ThenByDescending(c => c.Value.Min(m => m.Length));
            foreach (var collection in result)
            {
                Console.WriteLine(collection.Key);
                if (selection.Equals("all"))
                {
                    var methods = collection.Value
                        .OrderByDescending(m => m.Length);
                    foreach (var method in methods)
                    {
                        Console.WriteLine($"* {method}");
                    }
                }
            }
        }
    }
}
