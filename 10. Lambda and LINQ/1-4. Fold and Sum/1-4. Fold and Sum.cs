using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int k = input.Count / 4;

            List<int> first = input.Take(k).Reverse().ToList();
            input.Reverse();
            List<int> last = input.Take(k).ToList();

            // 
            List<int> up = first.Concat(last).ToList();
            input.Reverse();
            List<int> down = input.Skip(k).Take(2 * k).ToList();

            List<int> newlist = new List<int>();


            for (int i = 0; i < up.Count; i++)
            {

                newlist.Add(up[i] + down[i]);
            }

            Console.WriteLine(string.Join(", ", newlist));
        }
    }
}
