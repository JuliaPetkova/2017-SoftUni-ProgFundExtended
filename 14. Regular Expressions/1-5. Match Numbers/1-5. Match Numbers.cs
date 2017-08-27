using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_5.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))\b";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var output = matches.Cast<Match>().Select(num => num.Value).ToArray();

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
