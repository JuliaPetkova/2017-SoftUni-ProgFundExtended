using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacities = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var hour = int.Parse(Console.ReadLine());

            var result = new StringBuilder();

            for (int i = 0; i < capacities.Length; i++)
            {
                var capacity = capacities[i];
                var batteryUsagePerHour = usagePerHour[i];

                var mAh = capacity - (batteryUsagePerHour * hour);

                if (mAh > 0)
                {
                    result.AppendLine($"Battery {i + 1}: {mAh:f2} mAh ({(mAh * 100.0) / capacity:f2})%");
                }
                else
                {

                    result.AppendLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(capacity / batteryUsagePerHour)} hours)");
                }
            }

            Console.Write(result);
        }
    }
}
