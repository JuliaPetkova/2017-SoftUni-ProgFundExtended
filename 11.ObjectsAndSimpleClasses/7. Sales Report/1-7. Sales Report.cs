using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                Sale sale = ReadSale(Console.ReadLine());

                if (!sales.Contains(sale))
                {
                    sales.Add(sale);
                }
            }

            List<string> towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToList();

            foreach (var town in towns)
            {
                double sum = sales.Where(s => s.Town == town)
                    .Select(s => s.Price * s.Qnt)
                    .Sum();
                Console.WriteLine($"{town} -> {sum:f2}");
            }
 

        }

        private static Sale ReadSale(string input)
        {
            string[] param = input.Split().ToArray();
            return new Sale()
            {
                Town = param[0],
                Product = param[1],
                Price = double.Parse(param[2]),
                Qnt = double.Parse(param[3])
            };
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Qnt { get; set; }
    }


}

