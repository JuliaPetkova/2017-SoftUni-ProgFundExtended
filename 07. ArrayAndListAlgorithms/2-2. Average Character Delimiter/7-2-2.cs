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

            int count = 0;

            int charSum = 0;
            string result = "";


            for (int i = 0; i < input.Length; i++)
            {
                foreach (var item in input[i])
                {
                    char number = item; // convert item (char) to an  integer 
                    charSum = charSum + number;
                    count++;
                }
            }
            charSum = charSum / 10;

            char sum = Convert.ToChar(charSum);
            sum = Char.ToUpper(sum);

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    result = result + input[i];
                }
                else
                {
                    result = result + input[i] + sum;
                }
            }
            Console.WriteLine(result);

            //Console.WriteLine($"count {count}, sum of chars in input {charSum}");
        }
    }
}
