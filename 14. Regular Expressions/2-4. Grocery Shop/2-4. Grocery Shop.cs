using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_4.Grocery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var pattern = @"(?<product>^[A-Z][a-z]+):(?<price>\d+\.\d{2}$)";
            var reg = new Regex(pattern);

            var priceList = new Dictionary<string, decimal>();

            while (input != "bill")
            {
                var productData = Regex.Match(input, pattern);

                if (productData.Success)
                {
                    string product = productData.Groups["product"].Value;
                    decimal price = decimal.Parse(productData.Groups["price"].Value);

                    if (!priceList.ContainsKey(product))
                    {
                        priceList.Add(product, price);
                    }
                    else
                    {
                        priceList[product] = price;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in priceList.OrderByDescending(v => v.Value))
            {
                Console.WriteLine($"{item.Key} costs {item.Value}");
            }
        }
    }
}

