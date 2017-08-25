using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.Points_Counter
{

    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "Result")
            {
                var param = input.Replace("@", "").Replace("%", "")
                    .Replace("$", "").Replace("*", "").Split('|').ToList();

                string teamName = "";
                string playerName = "";
                int points = int.Parse(param[2]);

                if (param[0].Any(ch => char.IsLower(ch)))
                {
                    playerName = param[0];
                    teamName = param[1];
                }
                else
                {
                    playerName = param[1];
                    teamName = param[0];
                }

                var player = new Dictionary<string, int>();

                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, player);
                }

                teams[teamName][playerName] = points;

                input = Console.ReadLine();
            }

            foreach (var team in teams.OrderByDescending(p => p.Value.Values.Sum()))
            {
                Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");


                foreach (var player in team.Value.OrderByDescending(x => x.Value).Take(1))
                {
                    Console.WriteLine($"Most points scored by {player.Key}");
                }

            }

        }
    }
}
