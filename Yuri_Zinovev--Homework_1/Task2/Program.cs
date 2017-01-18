using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //Дистанция
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();
            float distance = 0F;
            Console.WriteLine("---Расстояние между точками---");
            PointInput(out point1, "Введите координаты первой точки (через запятую)");
            PointInput(out point1, "Введите координаты второй точки (через запятую)");
            distance = Point.Distance(point1, point2);
            Console.WriteLine($"Расстояние между точками = {distance}");
        }

        static void PointInput(out Point point, string message)
        {
            Console.Write(message + "\t");
            string[] parameters = Console.ReadLine().Split(',');
            float x;
            float y;
            float.TryParse(parameters[0], out x);
            float.TryParse(parameters[1], out y);

            point = new Point(x, y);
        }
    }

    class Point {
        float X { set; get; }
        float Y { set; get; }

        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static float Distance(Point p1, Point p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
