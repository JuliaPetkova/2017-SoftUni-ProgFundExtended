using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Most_Valued_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            var productPrice =
      new Dictionary<string, double>();

            var clientProductPair =
                new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] tokns = input.Split(' ');
                string product = tokns[0];
                double price = double.Parse(tokns[1]);

                productPrice[product] = price;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Print")
            {
                string[] tokens = input
                    .Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Discount")
                {
                    var discount = productPrice
                        .OrderByDescending(p => p.Value)
                        .Take(3)
                        .Select(p => new KeyValuePair<string, double>(p.Key, p.Value * 0.9));

                    foreach (var item in discount)
                    {
                        productPrice[item.Key] = item.Value;
                    }
                }

                string customer = tokens[0];

                if (!clientProductPair.ContainsKey(customer))
                {
                    clientProductPair.Add(customer, new List<string>());
                }

                for (int index = 1; index < tokens.Length; index++)
                {
                    string boughtProducts = tokens[index];

                    if (productPrice.ContainsKey(boughtProducts))
                    {
                        clientProductPair[customer].Add(boughtProducts);
                    }
                }
                input = Console.ReadLine();
            }

            var spender = clientProductPair
                .OrderByDescending(x => x.Value.Sum(prod => productPrice[prod]))
                .First();

            string name = spender.Key;

            List<string> bothProd = spender.Value;
            double total = bothProd.Sum(p => productPrice[p]);

            Console.WriteLine("Biggest spender: {0}", name);
            Console.WriteLine("^Products bought:");


            var orderedProducts = bothProd.Distinct().OrderByDescending(p => productPrice[p]);

            foreach (var item in orderedProducts)
            {
                Console.WriteLine("^^^{0}: {1:F2}", item, productPrice[item]);
            }

            Console.WriteLine("Total: {0:F2}", total);
        }
    }
}
