using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    abstract class Task
    {
        public string Name { get; set; }

        virtual public void Run()
        {
            ConsoleCustom.WriteLine("Старт программы", ConsoleColor.Green);
            ConsoleCustom.WriteLine($"{Name}\n", ConsoleColor.Yellow);
        }

        public void Finish()
        {
            Console.WriteLine();
            ConsoleStripe();
        }

        void ConsoleStripe()
        {
            ConsoleCustom.WriteLine(new String('-', Console.WindowWidth), ConsoleColor.DarkYellow);
        }
    }
}
