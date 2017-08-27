using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_3.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var inputHex = Console.ReadLine();

            MatchCollection matches = Regex.Matches(inputHex, pattern);

            var output = matches.Cast<Match>().Select(h => h.Value).ToArray();
            Console.WriteLine(string.Join(" ", output));
            //1F 0x1F 0xAB 0x10 10 AB FF
        }
    }
}
