using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                var key = tokens[0];
                var value = tokens[2];

                data[key] = value;

                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine(); 

            data.Where(x => x.Value != "null")
                    .OrderByDescending(x => x.Value.Length)
                    .ToList()
                    .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, x.Value));

            data.Where(x => x.Value == "null")
                    .ToList()
                    .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, defaultValue));
        }
    }
}
