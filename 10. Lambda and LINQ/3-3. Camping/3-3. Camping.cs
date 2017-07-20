using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3.Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> days = new Dictionary<string, int>();
            
            while (input != "end")
            {
                var parameters = input.Split(' ');
                var name = parameters[0];
                var car = parameters[1];
                var day = int.Parse(parameters[2]);

                if (!data.ContainsKey(name))
                {
                    data.Add(name, new Dictionary<string, int>());
                    
                }
                if (!data[name].ContainsKey(car))
                {
                    data[name].Add(car, 0);
                }
                data[name][car] = day;


                if (!days.ContainsKey(name))
                {
                    days.Add(name, 0);
                }
                days[name] += day;

                input = Console.ReadLine();
            }

            var orderedData =
                     data
                        .OrderByDescending(x => x.Value.Count)
                        .ThenBy(x => x.Key.Length)
                        .ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in orderedData)
            {
                var name =item.Key;
                var cars = item.Value;
                
                Console.WriteLine("{0}: {1}", name, cars.Count);

                foreach (var car in cars)
                {
                    Console.WriteLine("***{0}", car.Key);
                }

                Console.WriteLine("Total stay: {0} nights", days[name]);

            }
        }
    }
}
