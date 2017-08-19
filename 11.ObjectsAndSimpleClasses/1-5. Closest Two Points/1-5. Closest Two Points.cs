using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestPoints

{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return string.Format($"({X}, {Y})");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] nearPoints = FindPoints();

            double minDist = Distance(nearPoints[0], nearPoints[1]);
        }

        public static double Distance(Point point1, Point point2)
        {
            double a = point1.X - point2.X;
            double b = point1.Y - point2.Y;

            double distance = Math.Sqrt((a * a) + (b * b));

            return distance;
        }

        public static Point[] FindPoints()
        {
            Point[] nearPoints = new Point[2];
            double minDist = double.MaxValue;
            double distance = 0;

            for (int i = 0; i < po; i++)
            {

            }

            return nearPoints;
        }

        public static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoints(Console.ReadLine());
            }
            return points;
        }

        public static Point ReadPoints(string input)
        {
            double[] point = input.Split().Select(double.Parse).ToArray();
            return new Point() { X = point[0], Y = point[1]};
        }
    }
}
