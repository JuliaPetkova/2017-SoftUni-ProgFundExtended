using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_5.Sort_Array_Using_Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i < arr.Length; i++)
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