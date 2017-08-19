using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Distance
{

    class Program
    {
        static void Main()
        {
            Point p1 = ReadPoint(Console.ReadLine());
            Point p2 = ReadPoint(Console.ReadLine());

            Console.WriteLine("{0:F3}", DistanceCalculation(p1, p2));

        }

        private static double DistanceCalculation(Point p1, Point p2)
        {
            double aSqr = Math.Pow((p1.X - p2.X), 2);
            double bSqr = Math.Pow((p1.Y - p2.Y), 2);

            double distance = Math.Sqrt(aSqr+bSqr);

            return distance;
        }

        private static Point ReadPoint(string input)
        {
            double[] parameters = input.Split().Select(double.Parse).ToArray();

            Point point = new Point() { X = parameters[0], Y = parameters[1] };
            return point;
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}