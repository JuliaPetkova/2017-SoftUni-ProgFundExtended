using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double p = double.Parse(Console.ReadLine());

            double[] result = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[i] * p;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
