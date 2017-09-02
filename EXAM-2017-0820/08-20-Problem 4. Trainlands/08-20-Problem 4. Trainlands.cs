using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_20_Problem_4.Trainlands
{
    class Wagon
    {
        public string WagonName { get; set; }
        public int WagonPower { get; set; }
        public Wagon(string wagonName, int wagonPower)
        {
            this.WagonName = wagonName;
            this.WagonPower = wagonPower;
        }

        public override string ToString()
        {
            return string.Format($"###{WagonName} - {WagonPower}");
        }
    }

    public class Train
    {
        private string trainName;
        private List<Wagon> Composition = new List<Wagon>();
        private long sumWagonsPower;


        public Train(string trainName)
        {
            this.trainName = trainName;
        }

        public string TrainName
        {
            get { return trainName; }
            set { this.trainName = value; }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            // 50/100
            var trains = new Dictionary<string, List<Wagon>>();

            var input = Console.ReadLine();

            string trainName = string.Empty;

            string wagonName;
            int wagonPower = 0;


            while (input != "It's Training Men!")
            {
                var param = input.Split(new string[] { " -> ", " : " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();


                if (param.Length == 3)
                {
                    trainName = param[0];

                    wagonName = param[1];

                    wagonPower = int.Parse(param[2]);

                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new List<Wagon>());
                    }

                    trains[trainName].Add(new Wagon(wagonName, wagonPower));
                }

                if (param.Length == 2)
                {
                    var firstTrain = param[0];
                    var secondTrain = param[1];

                    if (!trains.ContainsKey(firstTrain))
                    {
                        trains.Add(firstTrain, new List<Wagon>());
                    }
                    List<Wagon> addWagons = trains[secondTrain];
                    trains[firstTrain].AddRange(addWagons);
                    trains.Remove(secondTrain);
                }
                if (param.Length == 1)
                {
                    var splitParams = input.Split(new string[] { " = " }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

                    var firstTrain = splitParams[0];
                    var secondTrain = splitParams[1];

                    if (!trains.ContainsKey(firstTrain))
                    {
                        trains.Add(firstTrain, new List<Wagon>());
                        List<Wagon> addWagons = trains[secondTrain];
                        trains[firstTrain].AddRange(addWagons);
                    }

                    trains[firstTrain].Clear();
                    trains[firstTrain].AddRange(trains[secondTrain]);
                }

                input = Console.ReadLine();
            }


            foreach (KeyValuePair<string, List<Wagon>> train in trains)
            {
                Console.WriteLine($"Train: {train.Key}");

                train.Value.OrderByDescending(x => x.WagonPower);

                foreach (var wagon in train.Value.OrderByDescending(x => x.WagonPower))
                {

                    Console.WriteLine(wagon.ToString());
                }
            }
        }
    }
}
