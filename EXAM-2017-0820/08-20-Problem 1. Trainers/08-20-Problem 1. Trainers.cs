using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _08_20_Problem_1.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            // 100/100
            var technical = new List<double>(); // team money
            var teoretic = new List<double>();
            var practic = new List<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var distance = long.Parse(Console.ReadLine());
                var cargo = double.Parse(Console.ReadLine());
                var teamName = Console.ReadLine();

                double money = cargo * 1.5f * 1000 - 0.7f * distance * 1600 * 2.5f;

                switch (teamName)
                {
                    case "Technical":
                        technical.Add(money);
                        break;

                    case "Theoretical":
                        teoretic.Add(money);
                        break;

                    case "Practical":
                        practic.Add(money);
                        break;                    
                }               
            }

            double techSum = technical.Sum();
            double teorSum = teoretic.Sum();
            double practSum = practic.Sum();

            double maxSum = Math.Max(Math.Max(techSum, teorSum), practSum);

            string winner = string.Empty;

            if (maxSum == techSum)
            {
                winner = "The Technical Trainers";
            }
            else if (maxSum == teorSum)
            {
                winner = "The Theoretical Trainers";
            }
            else
            {
                winner = "The Practical Trainers";
            }

            Console.WriteLine($"{winner} win with ${maxSum:F3}.");
        }

    }
}
