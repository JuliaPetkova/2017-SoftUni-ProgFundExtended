using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            int count = 0;      // number of chars in the input
            int charSum = 0;    // sum of chars in the input

            string result = "";


            for (int i = 0; i < input.Length; i++)
            {
                foreach (var item in input[i])
                {
                    char number = item;
                    charSum = charSum + number;
                    count++; 
                }
            }
            charSum = charSum / count;
            char sum = char.ToUpper((char)charSum);

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    result = result + input[i]; // add elements in result
                }
                else
                {
                    result = result + input[i] + sum; // add last element
                }
            }
            Console.WriteLine(result);
        }
    }
}
