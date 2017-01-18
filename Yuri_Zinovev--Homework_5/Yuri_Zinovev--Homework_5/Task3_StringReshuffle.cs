using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_5
{
    public class Task3_StringReshuffle : MyLib.Task
    {
        public Task3_StringReshuffle()
        {
            Name = "Перестановка строк методом частотного массива";
        }

        public override void Run()
        {
            base.Run();

            ConsoleInput i1 = new ConsoleInput("Введите первое слово", HasLength);
            i1.Render();

            ConsoleInput i2 = new ConsoleInput("Введите второе слово", HasLength);
            i2.Render();

            string str1 = i1.Input;
            string str2 = i2.Input;
            bool isReshuffle = MyString.IsReshuffle(str1, str2, true);

            Console.WriteLine($"Строки: {str1} {str2}");
            Message result = new Message(isReshuffle ? "Являются перестановками" : "Не являются перестановками", isReshuffle ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed);

            Finish();
        }

        string HasLength(string s)
        {
            return s.Length != 0 ? "" : "Пустое поле - не слово";
        }
    }
}
