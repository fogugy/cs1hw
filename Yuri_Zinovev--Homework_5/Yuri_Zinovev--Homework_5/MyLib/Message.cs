using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Message
    {
        int _startPos { get; set; }
        int _rowsCount { get; set; }
        ConsoleColor _color { get; set; }

        public Message(string text, ConsoleColor color)
        {
            Render(text, color);
        }

        public Message(string text)
            : this(text, Console.ForegroundColor)
        { }

        void Render(string text, ConsoleColor color)
        {
            _color = color;
            _startPos = Console.CursorTop;
            ConsoleCustom.WriteLine(text, color);
            _rowsCount = Console.CursorTop - _startPos;
        }

        public void Erase()
        {
            var eraserMsgLength = _rowsCount * Console.WindowWidth;
            var eraserMsg = new String(' ', eraserMsgLength);
            Console.SetCursorPosition(0, _startPos);
            Console.WriteLine(eraserMsg);
        }

        public void Replace(string text)
        {
            Erase();
            Console.SetCursorPosition(0, _startPos);
            Render(text, _color);
        }
    }
}
