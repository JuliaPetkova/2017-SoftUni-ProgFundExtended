using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minval = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (minval >= arr[i])
                {
                    minval = arr[i];
                }
            }
            Console.WriteLine(minval);
        }
    }
}
