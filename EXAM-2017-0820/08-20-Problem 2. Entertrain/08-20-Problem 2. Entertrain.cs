using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _08_20_Problem_2.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            // 90 /100
            int locoPower = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var vagonsTotal = new List<int>();

            while (input != "All ofboard!")
            {
                int vagonWeight = int.Parse(input);

                vagonsTotal.Add(vagonWeight);

                var average = vagonsTotal.Average();

                if (vagonsTotal.Sum() > locoPower)
                {
                    int closest = vagonsTotal
                        .Aggregate((x, y) => Math.Abs(x - average) < Math.Abs(y - average) ? x : y);

                    //var closest = wagonTrain.OrderBy(x => Math.Abs(x - wagonTrain.Average())).First();
                    //wagonTotal.Remove(closest);

                    vagonsTotal.Remove(closest);
                }


                input = Console.ReadLine();
            }

            vagonsTotal.Reverse();

            vagonsTotal.Add(locoPower);

            Console.WriteLine(string.Join(" ", vagonsTotal));
        }
    }
}
