using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var warderob = new Dictionary<string, Dictionary<string, int>>();

            var num = int.Parse(Console.ReadLine());

            var tokens = Console.ReadLine().Split();

            string color = tokens[0];
            var clothes = tokens[3].Split();


            for (int i = 0; i < num; i++)
            {
                if (!warderob.ContainsKey(color))
                {
                    warderob[color] = new Dictionary<string, int>();
                }
                foreach (var item in clothes)
                {
                    if (!warderob[color].ContainsKey(item))
                    {
                        warderob[color][item] = 0;
                    }
                    warderob[color][item]++;
                }
            }

            string[] search = Console.ReadLine().Split();
            string searchColor = search[0];
            string searchCloth = search[1];

            Console.WriteLine($"{color} clothes:");

            foreach (var item in warderob)
            {
                //var ==> KeyValuePair<string, Dictionary<string, int>>
                string colorPrint = item.Key;
                Dictionary<string, int> clothesPrint = item.Value;

                Console.Write($"* {item.Key} - {item.Value}");

                if (color == searchColor && clothesPrint == clothesPrint)
                {
                    Console.Write(" (found!)");
                }

                Console.WriteLine();
            }

        }
    }
}
