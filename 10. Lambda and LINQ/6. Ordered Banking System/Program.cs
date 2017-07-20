using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {

            var onlineBanking = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            while (input[0] != "end")
            {

                if (!onlineBanking.ContainsKey(input[0]))
                {
                    onlineBanking[input[0]] = new Dictionary<string, decimal>();
                }
                if (!onlineBanking[input[0]].ContainsKey(input[1]))
                {
                    onlineBanking[input[0]][input[1]] = decimal.Parse(input[2]);
                }
                else
                {
                    onlineBanking[input[0]][input[1]] += decimal.Parse(input[2]);
                }

                input = Console.ReadLine().Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            onlineBanking.OrderByDescending(bank => bank.Value.Sum(acount => acount.Value))
                .ThenByDescending(bank => bank.Value.Max(acount => acount.Value)).ToList()
                .ForEach(bank => bank.Value.OrderByDescending(acount => acount.Value).ToList()
                .ForEach(acount => Console.WriteLine($"{acount.Key} -> {acount.Value} ({bank.Key})")));
        }
    }
}
