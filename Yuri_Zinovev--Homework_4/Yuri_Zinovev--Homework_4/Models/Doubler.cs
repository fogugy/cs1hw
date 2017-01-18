using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_4
{
    public class Doubler
    {
        public const int Start = 1;
        public int Target { get; private set; }
        public int Current { get; private set; }

        public Doubler(int target)
        {
            Target = target;
            Current = Start;
        }
    }
}
