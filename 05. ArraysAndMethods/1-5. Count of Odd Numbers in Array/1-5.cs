using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                bool isOdd = arr[cnt] % 2 != 0;
                if (isOdd)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
