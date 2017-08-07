using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1_3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger f = 1;

            for (int i = 2; i <= num; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);





        }
    }
}

