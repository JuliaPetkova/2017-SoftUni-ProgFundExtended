using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5.Boxes
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public static double Distance(Point point1, Point point2)
        {
            double a = point1.X - point2.X;
            double b = point1.Y - point2.Y;

            double distance = Math.Sqrt((a * a) + (b * b));

            return distance;
        }
    }
    class Box
    {
        public Point TopLeft { get; set; }
        public Point TopRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }
        public Box(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.TopRight = topRight;
            this.BottomLeft = bottomLeft;
            this.BottomRight = bottomRight;
        }
        public double Width
        {
            get
            { return Point.Distance(TopLeft, TopRight); }
        }
        public double Height
        {
            get
            { return Point.Distance(TopLeft, BottomLeft); }
        }
        public override string ToString()
        {
            return string.Format("Box: {0}, {1}", Width, Height);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            while (input != "end")
            {
                List<Point> points = new List<Point>();

                var param1 = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                foreach (var item in param1)
                {
                    var param2 = item.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                    int p1 = int.Parse(param2[0]);
                    int p2 = int.Parse(param2[1]);

                    var point = new Point(p1, p2);

                    points.Add(point);
                }

                Box boxsche = new Box(points[0], points[1], points[2], points[3]);
                Console.WriteLine(boxsche);
                Console.WriteLine($"Perimeter: {(2*boxsche.Width) + (2*boxsche.Height)}");

                Console.WriteLine($"Area: {boxsche.Width*boxsche.Height}");

                input = Console.ReadLine();
            }
        }
    }
}
