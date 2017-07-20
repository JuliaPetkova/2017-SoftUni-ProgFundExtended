using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var inpit = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            while (inpit[0] != "lambada")
            {
                if (inpit[0] != "dance")
                {
                    dict[inpit[0]] = inpit[1];
                }
                if (inpit[0] == "dance")
                {
                    dict = dict.ToDictionary(x => x.Key, x => $"{x.Key}.{x.Value}");
                }

                inpit = Console.ReadLine().Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
