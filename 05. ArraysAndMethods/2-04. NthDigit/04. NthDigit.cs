using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            long currentNumber = 0;
            while (input != 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    currentNumber = input % 10;
                    input = input / 10;
                    if (i == num)
                    {
                        Console.WriteLine(currentNumber);
                        return;
                    }
                }
            }
            if (input ==0)
            {
                Console.WriteLine("1");
            }
        }
    }
}
