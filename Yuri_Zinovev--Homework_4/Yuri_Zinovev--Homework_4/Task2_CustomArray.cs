using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_4
{
    public class Task2_CustomArray : MyLib.Task
    {
        public Task2_CustomArray()
        {
            Name = "Кастом массив с реализацией методов Sum, Inverse, Multi, MaxCount";
        }

        public override void Run()
        {
            CustomArray ca = new CustomArray(10, 5, 2);

            base.Run();

            Console.WriteLine($"Array:\n{ca.ToString(10)}");
            Console.WriteLine($".Sum: {ca.Sum()}");
            ca.Inverse();
            Console.WriteLine($".Inverse:\n{ca.ToString(10)}");
            ca.Multi(2);
            Console.WriteLine($".Multi(2):\n{ca.ToString(10)}");
            Console.WriteLine($".MaxCount: {ca.MaxCount()}");
            ConsoleCustom.WriteLine("Fill with random for .MaxCount demo", ConsoleColor.Cyan);
            ca.FillRandom(0, 5);
            Console.WriteLine($"Array:\n{ca.ToString(10)}");
            Console.WriteLine($".MaxCount: {ca.MaxCount()}");

            Finish();
        }
    }
}
