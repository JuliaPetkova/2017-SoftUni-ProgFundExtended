﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_2.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
