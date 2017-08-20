using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, int> stock = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var tokens = input.Split();
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!stock.ContainsKey(product))
                {
                    stock[product] = 0;
                }
                stock[product] += quantity;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exam time")
            {
                var tokens = input.Split();

                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!stock.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {
                    if (stock[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        stock[product] -= quantity;

                        if (stock[product] < 0)
                        {
                            stock[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> item in stock)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

            }
        }
    }
}
