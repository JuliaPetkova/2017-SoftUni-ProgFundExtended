﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_04.Flip_List_Sides_Ver._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            for (int i = 1; i < list.Count / 2; i++)
            {
                int temp = list[i];
                list[i] = list[list.Count -1 - i];
                list[list.Count - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
