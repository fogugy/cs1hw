using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    static class ConsoleCustom
    {
        static ConsoleColor _colorBuffer;

        public static void SetColor(ConsoleColor newColor)
        {
            _colorBuffer = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
        }

        public static void ResetColor()
        {
            Console.ForegroundColor = _colorBuffer;
        }

        public static void Write(string text, ConsoleColor color)
        {
            SetColor(color);
            Console.Write(text);
            ResetColor();
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            Write($"{text}\n", color);
        }
    }
}
