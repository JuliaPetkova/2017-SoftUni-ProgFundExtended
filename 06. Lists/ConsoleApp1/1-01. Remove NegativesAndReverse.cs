using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int count = 0;
            for (int cnt = input.Count-1; cnt >=0; cnt--)
            {
                if (input[cnt] > 0)
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
