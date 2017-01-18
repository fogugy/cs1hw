using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public static class ConsoleCustom
    {
        static ConsoleColor _colorBuffer;
        static int _lastMessageLines;

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
            int cursorStartPos = Console.CursorTop;
            SetColor(color);
            Console.Write(text);
            ResetColor();
            _lastMessageLines = Console.CursorTop - cursorStartPos + 1;
        }

        public static void WriteLine(string text, ConsoleColor color)
        {
            var startPosY = Console.CursorTop;
            Write($"{text}", color);
            if (Console.CursorLeft != 0)
            {
                Console.WriteLine();
            }
        }

        public static void EraseLast()
        {
            Console.SetCursorPosition(0, Console.CursorTop - _lastMessageLines + 1);
            Write(new String(' ', Console.WindowWidth), Console.BackgroundColor);
            Console.SetCursorPosition(0, Console.CursorTop - _lastMessageLines + 1);
        }
    }
}
