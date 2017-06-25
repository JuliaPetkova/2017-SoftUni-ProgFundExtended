using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6.Insertion_Sort_Using_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < arr.Count; i++)
            {
                int unsorted = arr[i];
                int j;

                for (j = i - 1; (j >= 0) && (arr[j] > unsorted); j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[j + 1] = unsorted;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
