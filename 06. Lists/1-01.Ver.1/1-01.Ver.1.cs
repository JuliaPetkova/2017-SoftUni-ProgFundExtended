using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_01.Ver._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            input.Reverse();

            int count = 0;
            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (input[cnt] >= 0)
                {
                    result.Add(input[cnt]);
                    count++;
                }
            }
            if (count > 0)
            {

                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
