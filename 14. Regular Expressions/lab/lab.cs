using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------");
            var input = "Nakov: 123, Branson: 456";
            var pattern = @"([A-Z][a-z]+): \d+";
            var match = Regex.Match(input, pattern);

            Console.WriteLine(match.Groups.Count);
            Console.WriteLine("----------------------");

            Console.WriteLine("Matched text: \"{0}\"", match.Groups[0]);

        }
    }
}
