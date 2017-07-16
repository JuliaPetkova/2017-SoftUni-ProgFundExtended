using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4.SoftUni_Beer_Pong
{
    class Program
    {
        static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "stop the game")
            {
                string[] tokens = input.Split('|');

                string player = tokens[0];
                string team = tokens[1];
                int score = int.Parse(tokens[2]);

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());
                }

                if (data[team].Count < 3)
                {
                    data[team].Add(player, score);
                }

                input = Console.ReadLine();
            }

            var orderedData =
                data
                 .Where(r => r.Value.Count == 3)
                 .OrderByDescending(r => r.Value.Sum(x => x.Value));

            int rank = 1;
            foreach (var item in orderedData)
            {
                string teamName = item.Key;
                Dictionary<string, int> playersData = item.Value;

                var orderedPlayersData = playersData
                    .OrderByDescending(x => x.Value);

                Console.WriteLine("{0}. {1}; Players:", rank, teamName);

                foreach (var pair in orderedPlayersData)
                {
                    Console.WriteLine("###{0}: {1}", pair.Key, pair.Value);
                }
                rank++;
            }
        }
    }
}
