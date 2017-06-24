using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frequencies = Console.ReadLine().Split(' ').ToList();

            List<string> notes = new List<string>();

            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double natSum = 0;
            double sharpSum = 0;


            foreach (var item in frequencies)
            {
                switch (item)
                {
                    case "261.63":
                        notes.Add("C");
                        natSum += double.Parse(item);
                        break;
                    case "277.18":
                        notes.Add("C#");
                        sharpSum += double.Parse(item);
                        break;

                    case "293.66":
                        notes.Add("D");
                        natSum += double.Parse(item);
                        break;

                    case "311.13":
                        notes.Add("D#");
                        sharpSum += double.Parse(item);
                        break;
                    case "329.63":
                        notes.Add("E");
                        natSum += double.Parse(item);
                        break;
                    case "349.23":
                        notes.Add("F");
                        natSum += double.Parse(item);
                        break;
                    case "369.99":
                        notes.Add("F#");
                        sharpSum += double.Parse(item);
                        break;
                    case "392.0":
                        notes.Add("G");
                        natSum += double.Parse(item);
                        break;
                    case "415.30":
                        notes.Add("G#");
                        sharpSum += double.Parse(item);
                        break;
                    case "440.0":
                        notes.Add("A");
                        natSum += double.Parse(item);
                        break;
                    case "466.16":
                        notes.Add("A#");
                        sharpSum += double.Parse(item);
                        break;
                    case "493.88":
                        notes.Add("B");
                        natSum += double.Parse(item);
                        break;

                    default:
                        break;
                }
            }
            Console.WriteLine("Notes: " + string.Join(" ", notes));

            foreach (var item in notes)
            {
                if (!item.Contains("#"))
                {
                    naturals.Add(item);
                }
                else
                {
                    sharps.Add(item);
                }
            }
            Console.WriteLine("Naturals: " + string.Join(", ", naturals));
            Console.WriteLine("Sharps: " + string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0.F2}", natSum);
            Console.WriteLine("Sharps sum: {0:F2}", sharpSum);       

        }
    }
}
