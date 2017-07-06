using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    string value1 = arr[i];
                    string value2 = arr[j];

                    int comparator = value1.CompareTo(value2);
                    if (comparator == 1)
                    {
                        arr[i] = value2;
                        arr[j] = value1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
            
        }
    }
}
