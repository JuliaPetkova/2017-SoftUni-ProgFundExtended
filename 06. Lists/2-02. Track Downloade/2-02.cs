using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_02.Track_Downloade
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blacklist = Console.ReadLine().Split(' ');

            List<string> playlist = new List<string>();

            string song = Console.ReadLine();

            while (song != "end")
            {
                bool isContains = false;

                for (int i = 0; i < blacklist.Length; i++)
                {
                    if (song.Contains(blacklist[i]))
                    {
                        isContains = true;
                    }                   
                }
                if (!isContains)
                {
                    playlist.Add(song);
                }
                song = Console.ReadLine();
            }
            // playlist.Distinct();
            playlist.Sort();
            Console.WriteLine(string.Join("\r\n", playlist));

        }
    }
}
