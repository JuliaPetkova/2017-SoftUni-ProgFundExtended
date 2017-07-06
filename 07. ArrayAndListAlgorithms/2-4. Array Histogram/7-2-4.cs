using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            List<string> str = new List<string>();
            List<int> strCount = new List<int>();

            int count = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (!str.Contains(input[i]))
                {
                    str.Add(input[i]);
                    //count = 1;
                    strCount.Add(1);
                }
                else
                {
                    strCount[i]++;
                }
                count = 0;
            }
            Console.WriteLine(string.Join(" ", str));
            Console.WriteLine(string.Join(" ", strCount));


            // Console.WriteLine($"{str} -> {strCount} times ({strCount} * 100.0 / input.Length:f2%)");
        }
    }
}

