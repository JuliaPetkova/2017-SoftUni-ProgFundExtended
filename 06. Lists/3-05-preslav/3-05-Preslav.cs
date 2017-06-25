using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> noteStatistics = new List<string>
            { "C", "261.63","C#" , "277.18","D", "293.66", "D#", "311.13", "E", "329.63", "F", "349.23",
            "F#", "369.99", "G", "392.0", "G#", "415.3", "A", "440.0", "A#", "466.16", "B", "493.88" };

        List<string> altogetherNotes = new List<string>();
        List<string> onlyNaturals = new List<string>();
        List<string> onlySharps = new List<string>();
        List<decimal> sumNaturals = new List<decimal>();
        List<decimal> sumSharps = new List<decimal>();

        List<string> frequencies = Console.ReadLine().Split(' ').ToList();

        for (int i = 0; i < frequencies.Count; i++)
        {
            for (int j = 0; j < noteStatistics.Count; j++)
            {
                if (frequencies[i] == noteStatistics[j] && noteStatistics[j - 1].Contains("#"))
                {
                    altogetherNotes.Add(noteStatistics[j - 1]);
                    onlySharps.Add(noteStatistics[j - 1]);
                    sumSharps.Add(decimal.Parse(noteStatistics[j]));
                }
                else if (frequencies[i] == noteStatistics[j])
                {
                    altogetherNotes.Add(noteStatistics[j - 1]);
                    onlyNaturals.Add(noteStatistics[j - 1]);
                    sumNaturals.Add(decimal.Parse(noteStatistics[j]));
                }
            }
        }
        Console.WriteLine("Notes: " + string.Join(" ", altogetherNotes));
        Console.WriteLine("Naturals: " + string.Join(", ", onlyNaturals));
        Console.WriteLine("Sharps: " + string.Join(", ", onlySharps));
        Console.WriteLine("Naturals sum: {0:f2}", sumNaturals.Sum());
        Console.WriteLine("Sharps sum: {0:f2}", sumSharps.Sum());
    }
}