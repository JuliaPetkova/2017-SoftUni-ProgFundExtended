using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2.Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int leftIndex = -1;
            int rightIndex = -1;

            int carats = 0;

            bool isDiamant = false;

            while ((leftIndex = input.IndexOf("<", leftIndex + 1)) > -1
                && (rightIndex = input.IndexOf(">", leftIndex + 1)) > -1)
            {
                string data = input.Substring(leftIndex + 1, rightIndex - leftIndex-1);

                carats = CalsCarats(data);
                isDiamant = true;
                Console.WriteLine($"Found {carats} carat diamond");

            }


            if (isDiamant== false)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int CalsCarats(string data)
        {
            int carats = 0;

            foreach (char item in data)
            {
                if (char.IsDigit(item))
                {
                    carats += int.Parse(item.ToString());
                }
            }
            return carats;
        }
    }
}
