using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2.Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int num = int.Parse(Console.ReadLine());

            int linearIterations = 0;
            int binaryIterations = 0;

            bool isFound = false;
            LinearSearch(list, num, ref linearIterations, ref isFound);
            BinarySearch(list, num, ref binaryIterations, isFound);

            if (isFound)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Linear search made {linearIterations} iterations");
                Console.WriteLine($"Binary search made {binaryIterations} iterations");

            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {linearIterations} iterations");
                Console.WriteLine($"Binary search made {binaryIterations} iterations");

            }
        }

        private static void BinarySearch(List<int> list, int num, ref int binaryIterations, bool isFound)
        {
            int firstIndex = 0;
            int lastIndex = list.Count-1;

            isFound = false;
            list.Sort();

            while (firstIndex <= lastIndex)
            {
                int midPoint = (lastIndex + firstIndex) / 2;
                binaryIterations++;

                if (list[midPoint] == num)
                {
                    isFound = true;
                    return;
                }

                if (list[midPoint] > num)
                {
                    lastIndex = midPoint - 1;
                    isFound = false;
                }
                if (list[midPoint] < num)
                {
                    firstIndex = midPoint + 1;
                    isFound = false;
                }

            }
        }

        private static void LinearSearch(List<int> list, int num, ref int linearIterations, ref bool isFound)
        {
            foreach (int item in list)
            {
                linearIterations++;
                if (item == num)
                {
                    isFound = true;
                    return;
                }               
            }
        }
    }
}
