using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            input.Reverse();

            foreach (var item in input)
            {
                result.Add(item);
            }
            result[0] = input[input.Count-1];
            result[result.Count-1] = input[0];

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
