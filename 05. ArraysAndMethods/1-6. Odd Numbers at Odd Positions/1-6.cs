using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6.Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        private static readonly int i;

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isOddIndex = false;
            bool isOddItem = false;

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                isOddIndex = (cnt % 2 != 0);
                isOddItem = (arr[cnt] % 2 != 0);
                if (isOddItem && isOddIndex)
                {
                    Console.WriteLine($"Index {cnt} -> {arr[cnt]}");
                }
            }
        }
    }
}
