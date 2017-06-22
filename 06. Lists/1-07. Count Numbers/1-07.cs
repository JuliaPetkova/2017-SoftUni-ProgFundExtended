using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.Sort();

            int count = 1;
            for (int i = 0; i < (nums.Count - 1); i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;                    
                }
                else
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{nums[nums.Count-1]} -> {count}");
        }
    }
}
