using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_4
{
    public class CustomArray
    {
        public int[] Array;

        public int this[int i]
        {
            get
            {
                return Array[i];
            }

            set
            {
                Array[i] = value;
            }
        }

        public CustomArray()
        {
            Array = new int[0];
        }
        public CustomArray(int length, int startNumber, int step)
        {
            Array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Array[i] = startNumber + step * i;
            }
        }

        public void FillRandom(int length, int minValue, int maxValue)
        {
            Array = new int[length];
            var rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                Array[i] = rnd.Next(minValue, maxValue + 1);
            }
        }

        public void FillRandom(int minValue, int maxValue)
        {
            FillRandom(Array.Length, minValue, maxValue);
        }

        public int Sum()
        {
            int result = 0;
            foreach (int el in Array)
                result += el;
            return result;
        }

        public void Inverse()
        {
            Multi(-1);
        }

        public void Multi(int multiplicator)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] *= multiplicator;
            }
        }

        public int MaxCount()
        {
            int result = 0;
            int max;

            if (Array.Length == 0)
            {
                return 0;
            }

            max = int.MinValue;

            foreach (int el in Array)
            {
                if (max < el)
                {
                    max = el;
                    result = 1;
                }
                else if (max == el)
                {
                    result++;
                }
            }

            return result;
        }

        public string ToString(int length)
        {
            string str = "";
            for (int i = 0; i < Math.Min(length, Array.Length); i++)
            {
                str += Array[i] + " ";
            }
            return str;
        }
    }
}
