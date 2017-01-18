using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_4
{
    public class Task1_CustomArray : MyLib.Task
    {
        public Task1_CustomArray()
        {
            Name = "Кастом массив. Количество пар элементов массива, в которых хотя бы одно число делится на 3";
        }

        public override void Run()
        {
            base.Run();

            var ca = new CustomArray();
            ca.FillRandom(20, -10000, 10000);
            //uncomment to try verified array
            //ca.Array = new int[5] { 6, 2, 9, -3, 6 };

            Console.WriteLine($"PairCount: {PairCount(ca.Array, 3)}");

            Finish();
        }

        int PairCount(int[] arr, int pairNumber)
        {
            int result = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % pairNumber == 0
                    || arr[i + 1] % pairNumber == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
