﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var temp = input[i];

                var rndPos = rnd.Next(0, input.Length);

                input[i] = input[rndPos];
                input[rndPos] = temp;
            }

            Console.WriteLine(string.Join("\r\n", input));
        }
    }
}
