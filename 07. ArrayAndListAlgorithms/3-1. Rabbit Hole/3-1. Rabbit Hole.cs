using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obstracles = Console.ReadLine().Split(' ').ToList();

            int energy = int.Parse(Console.ReadLine());

            int index = 0;

            bool isBombThere;

            while (energy > 0)
            {
                isBombThere = false;

                string[] command = obstracles[index].Split('|');
                
                if (command[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }

                int value = int.Parse(command[1]);

                switch (command[0])
                {

                    case "Left":
                        index = Math.Abs(index - value) % obstracles.Count;
                        energy -= value;
                        break;

                    case "Right":
                        index = (index + value) % obstracles.Count;
                        energy -= value;
                        break;

                    case "Bomb":
                        obstracles.RemoveAt(index);
                        index = 0;
                        energy -= value;
                        isBombThere = true;
                        break;
                }

                if (obstracles[obstracles.Count - 1] != "RabbitHole")
                {
                    obstracles.RemoveAt(obstracles.Count - 1);
                }

                obstracles.Add("Bomb|" + energy);


                if (energy <= 0 && isBombThere)
                {
                    Console.WriteLine("You are dead due to bomb explosion!");
                }
                else if (energy <= 0 && !isBombThere)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                }
            }
        }
    }
}