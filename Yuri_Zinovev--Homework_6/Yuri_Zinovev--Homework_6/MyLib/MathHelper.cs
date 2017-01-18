using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class MathHelper
    {
        public delegate double Func(double x);

        public static double GetFuncMinimum(Func func, double xMin, double xMax, double step = 0.1)
        {
            double min = double.MaxValue;
            double currentX = xMin;
            
            while (currentX <= xMax)
            {
                double value = func(currentX);
                currentX += step;
                min = Math.Min(min, value);
            }

            return min;
        }
    }
}
