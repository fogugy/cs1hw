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
        public delegate string RowParser<T>(T item);

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

        public static void WriteLine(string text)
        {
            WriteLine(text, Console.ForegroundColor);
        }


        public static void EraseLast()
        {
            Console.SetCursorPosition(0, Console.CursorTop - _lastMessageLines + 1);
            Write(new String(' ', Console.WindowWidth), Console.BackgroundColor);
            Console.SetCursorPosition(0, Console.CursorTop - _lastMessageLines + 1);
        }

        public static void PrintTable<T>(string title, RowParser<T> parser, IEnumerable<T> list, bool indexer = true)
        {
            int i = 0;

            WriteLine(title, ConsoleColor.DarkYellow);
            foreach (T item in list)
            {
                ConsoleColor color = i % 2 == 0 ? ConsoleColor.Gray : ConsoleColor.DarkGray;
                if (indexer)
                {
                    Write(i + 1 + "\t", color);
                }
                WriteLine(parser(item), color);
                i++;
            }
        }
    }
}
