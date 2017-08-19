using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Acount> acounts = new List<Acount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] param = input
                    .Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string bank = param[0];
                string name = param[1];
                decimal balance = decimal.Parse(param[2]);

                var acount = new Acount(bank, name, balance);
                acounts.Add(acount);

                input = Console.ReadLine();
            }

          var acc = acounts.OrderByDescending(a => a.Balance)
                .ThenBy(a=>a.Bank.Length);

            foreach (var item in acc)
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }
        }
    }
    class Acount
    {
        public string Bank { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Acount(string bank, string name, decimal balance)
        {
            Bank = bank;
            Name = name;
            Balance = balance;
        }
    }
}
