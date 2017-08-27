using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1_4.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // var pattern = @"\b(?<day>\d{2})([\/. -/])(?<month>[A-Z][a-z]+)\1(?<year>\d{4})\b";
            // Groups[1] ==> separator    //day = Groups["day"]

            var pattern = @"\b(\d{2})([\/. -/])([A-Z][a-z]+)\2(\d{4})\b";

            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                var day = item.Groups[1].Value;             // var day = item.Groups["day"].Value;

                var month = item.Groups[3].Value;
                var year = item.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                // Day: 13, Month: Jul, Year: 1928
                //Day: 10, Month: Nov, Year: 1934
                //Day: 25, Month: Dec, Year: 1937
            }
        }
    }
}
