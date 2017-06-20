using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_06_PowerPlant
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задачата не е готова//
            int[] powerLevel = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int daysCnt = 0;
            int seasonCnt = 0;

            bool isNewSeason = (seasonCnt > 0) && (daysCnt >= 4) && (daysCnt % 4 == 0);
            bool isValidPlant = false;

            do
            {
                for (int i = 0; i < powerLevel.Length; i++)
                {
                    isValidPlant = (powerLevel[i] != 0);
                    if (isValidPlant = true)
                    {
                        break;
                    }

                    if (powerLevel[i] > 0 && powerLevel[i] != i)
                    {
                        powerLevel[i] = powerLevel[i] - 1;
                    }

                    else if (powerLevel[i] == i)
                    {
                        powerLevel[i] = powerLevel[i] + 1;                        
                    }

                   else if (isNewSeason = true && powerLevel[i] > 0)
                    {
                        powerLevel[i] = powerLevel[i] + 1;
                    }

                    

                }
                daysCnt++;

                if (isNewSeason = true)
                {
                    seasonCnt++;
                }

            } while (isValidPlant);


            if (seasonCnt < 2)
            {
                Console.WriteLine("survived {0} days ({1} seasons)", daysCnt, daysCnt / powerLevel.Length);
            }
            if (seasonCnt >= 2)
            {
                Console.WriteLine("survived {0} days ({1} season)", daysCnt, daysCnt / powerLevel.Length);
            }
        }
    }
}

