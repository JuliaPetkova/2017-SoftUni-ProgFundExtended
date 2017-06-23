using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstline = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondline = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstline.Count; i++)
            {
                for (int j = 0; j < secondline.Count; j++)
                {
                    if (firstline[i] == secondline[j])
                    {
                        secondline.Remove(secondline[j]);
                    }
                }
            }
            var sum1 = firstline.Sum();
            var sum2 = secondline.Sum();
            var sum = Math.Abs(sum1 - sum2);

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                Console.WriteLine( $"No. Diff: {sum}");
            }
        }
    }
}
