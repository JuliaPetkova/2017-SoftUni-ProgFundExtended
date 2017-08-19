using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = ReadR(Console.ReadLine());
            Rectangle r2 = ReadR(Console.ReadLine());

            bool isInside = CalcInside(r1, r2);

            var print = isInside ? "Inside" : "Not inside";
            Console.WriteLine(print);

        }

        private static bool CalcInside(Rectangle r1, Rectangle r2)
        {
            bool isInside = r1.X1 >= r2.X1 && r1.Y1 >= r2.Y1
                && r1.X2 <= r2.X2 && r1.Y2 <= r2.Y2;

            return isInside;
        }

        private static Rectangle ReadR(string input)
        {
            double[] param = input.Split().Select(double.Parse).ToArray();
           return new Rectangle() {X1 = param[0], Y1 = param[1], Width = param[2], Height = param[3] };
        }
    }
    class Rectangle
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double X2
        {
            get { return X1 + Width; }
        }
        public double Y2
        { get { return Y1 + Height; } }


    }
}