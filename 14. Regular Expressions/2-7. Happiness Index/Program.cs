using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_7.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string happyPattern = @"(:\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;)";
            string sadPattern = @"(:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];)";

            double happyIndex = 0;

            string input = Console.ReadLine();

            var happyEmoticons = Regex.Matches(input, happyPattern);
            var sadEmoticons = Regex.Matches(input, sadPattern);

            happyIndex = (double)happyEmoticons.Count / sadEmoticons.Count;

            string status = string.Empty;

            if (happyIndex >= 2)
            {
                status = ":D";
            }
            else if (happyIndex > 1)
            {
                status = ":)";
            }
            else if (happyIndex == 1)
            {
                status = ":|";
            }
            else if (happyIndex < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {status}");
            Console.WriteLine($"[Happy count: {happyEmoticons.Count}, Sad count: {sadEmoticons.Count}]");
        }
    }
}
