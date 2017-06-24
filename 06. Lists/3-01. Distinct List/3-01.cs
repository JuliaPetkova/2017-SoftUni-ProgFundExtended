using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //input.Distinct();

            List<int> result = new List<int>();

            foreach (var item in input)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
