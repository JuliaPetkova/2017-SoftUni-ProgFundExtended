using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] nearPoints = FindNearPoint(points);

            double minDistance = Distance(nearPoints[0], nearPoints[1]);

            Console.WriteLine("{0:f3}", minDistance);

            foreach (var item in nearPoints)
            {
                Console.WriteLine(item);
            }
        }

        private static Point[] FindNearPoint(Point[] points)
        {
            Point[] nearPoints = new Point[2];
            double distance = 0;
            double minDist = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    Point point1 = points[i];
                    Point point2 = points[j];

                    distance = Distance(point1, point2);
                    if (distance < minDist)
                    {
                        minDist = distance;
                        nearPoints[0] = point1;
                        nearPoints[1] = point2;
                    }
                }
            }

            return nearPoints;
        }

        private static double Distance(Point point1, Point point2)
        {
            double a = point1.X - point2.X;
            double b = point1.Y - point2.Y;

            double distance = Math.Sqrt((a * a) + (b * b));

            return distance;

        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint(Console.ReadLine());
            }

            return points;
        }

        private static Point ReadPoint(string input)
        {
            double[] point = input.Split().Select(double.Parse).ToArray();

            return new Point() { X = point[0], Y = point[1] };
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString() { return string.Format($"({X}, {Y})"); }
    }
}
