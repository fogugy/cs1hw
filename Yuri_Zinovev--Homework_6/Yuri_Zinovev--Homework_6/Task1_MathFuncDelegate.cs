using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_6
{
    public class Task1_MathFuncDelegate : MyLib.Task
    {
        public delegate double MathFunc(double factor, double x);

        public Task1_MathFuncDelegate()
        {
            Name = "Таблица значений функции делегата";
        }

        public override void Run()
        {
            base.Run();

            double a = 1;

            ConsoleCustom.Write("a*sin(x)", ConsoleColor.DarkGreen);
            ConsoleCustom.WriteLine($", factor: {a}");
            PrintFunctionTable(ASinX, "{0:0.0}\t{1:0.000000}", 0, 90, factor: a);

            Console.WriteLine();

            a = 1.3;
            ConsoleCustom.Write("a*x^2", ConsoleColor.DarkGreen);
            ConsoleCustom.WriteLine($", factor: {a}");
            PrintFunctionTable(XPow2, "{0:0}\t{1:0.0}", 0, 10, factor: a);

            Finish();
        }

        public void PrintFunctionTable(MathFunc func, string format, double xStart, double xEnd, double factor = 1, double step = 1)
        {
            double currentX = xStart;
            int i = 0;

            ConsoleCustom.WriteLine("--X--\t--Y--", ConsoleColor.White);

            while (currentX <= xEnd)
            {
                double y = func(factor, currentX);
                var rowColor = i % 2 == 0 ? ConsoleColor.DarkGray : ConsoleColor.Gray;

                ConsoleCustom.WriteLine(String.Format(format, currentX, y), rowColor);

                currentX += step;
                i++;
            }
        }

        public double ASinX(double factor, double angleDegree)
        {
            return factor * Math.Sin((angleDegree / 180) * Math.PI);
        }

        public double XPow2(double factor, double x)
        {
            return factor * Math.Pow(x, 2);
        }
    }
}
