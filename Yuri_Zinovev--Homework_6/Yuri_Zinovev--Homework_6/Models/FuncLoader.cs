using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class FuncLoader
    {
        public MathHelper.Func Func { get; set; }
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double Step { get; set; }
        public string Name { get; set; }

        public FuncLoader(MathHelper.Func func, string name)
        {
            Func = func;
            Name = name;
        }

        public double GetMin()
        {
            return MathHelper.GetFuncMinimum(Func, XMin, XMax, Step);
        }
    }
}
