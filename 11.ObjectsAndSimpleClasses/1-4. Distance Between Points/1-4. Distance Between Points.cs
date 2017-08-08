using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point first = ReadCoordinates(Console.ReadLine());
            Point second = ReadCoordinates(Console.ReadLine());

            Console.WriteLine("{0:F3}", CalcDist(first, second));

        }

        private static double CalcDist(Point first, Point second)
        {
            double distance = Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2));
            return distance;
        }

        private static Point ReadCoordinates(string input)
        {
            var coord = input.Split().Select(int.Parse).ToArray();
            return new Point() { X = coord[0], Y = coord[1]};
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
