using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_1.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(?<=[SHDC]|^)([2-9JQKA]|10)[SHDC]";

            var matches = Regex.Matches(input, pattern);

            string[] output = matches.Cast<Match>().Select(card=>card.Value).ToArray();

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
