using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_09_Problem_3.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var didiPattern = @"[^A-Za-z\-]+";
            var didiMatch = Regex.Matches(input, didiPattern);
            var didiList = didiMatch.Cast<Match>().Select(x => x.Value).ToList();

            var bojoPattern = @"(([A-Za-z]+)\-([A-Za-z]+))";
            var bojoMatch = Regex.Matches(input, bojoPattern);
            var bojoList = bojoMatch.Cast<Match>().Select(x => x.Value).ToList();


            var longerList = Math.Max(didiList.Count, bojoList.Count);

            for (int i = 0; i < longerList; i++)
            {
                if (didiList.Count >= 1)
                {
                    Console.WriteLine(didiList[i]);
                  //  didiList.Remove(didiList[i]);                  
                }

                if (bojoList.Count >= 1)
                {
                    Console.WriteLine(bojoList[i]);
                   // bojoList.Remove(bojoList[i]);
                }

            }
        }
    }
}
