using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_5
{
    public class Task2_MyString : MyLib.Task
    {
        public Task2_MyString()
        {
            Name = "MyString методы ДЗ задача 2";
        }

        public override void Run()
        {
            base.Run();

            ConsoleCustom.WriteLine("Введите текст");

            int maxLength = 3;
            char filterSymbol = 'a';
            var text = Console.ReadLine();

            Console.WriteLine();
            PrintSub($"Фильтрация по длине {maxLength}:", MyString.FilterByWordLength(text, maxLength));
            PrintSub($"Фильтрация по последнему символа '{filterSymbol}':", MyString.FilterByLastSymbol(text, filterSymbol));
            PrintSub($"Слова с максимальной длиной:", MyString.GetMaxLengthWords(text));

            Finish();
        }

        void PrintSub(string title, string text)
        {
            ConsoleCustom.WriteLine(title, ConsoleColor.White);
            Console.WriteLine(text);
        }
    }
}