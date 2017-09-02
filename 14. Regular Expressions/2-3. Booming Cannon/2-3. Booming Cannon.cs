using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_3.Booming_Cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            // 50/100 -->https://judge.softuni.bg/Contests/Practice/Index/444#2  //

            var inputLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = inputLine[0];
            int m = inputLine[1];

            var input = Console.ReadLine();

            var target = new List<string>();

            var pattern = @"(?<=\\[<]{3})\w+";
            var reg = new Regex(pattern);

            var text = reg.Matches(input).Cast<Match>().Select(v => v.Value).ToList();

            foreach (var item in text)
            {
                if (item.Length >= (n + m)&& n>=0 && m>=0)
                {
                    target.Add(item.Remove(0, n).Substring(0, m));
                }
                else
                {
                    return;
                }
            }
            Console.WriteLine(string.Join("/\\", target));
        }
    }
}
