using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class ConsoleInput
    {
        public string Title { get; set; }
        public string Input { get; set; }
        public string SuccessMessage { get; set; }
        public bool Success { get; private set; }

        public ConsoleColor TitleColor { get { return _titleColor | _titleColorDefault; } set { _titleColor = value; } }
        public ConsoleColor InputColor { get { return _inputColor | _inputColorDefault; } set { _inputColor = value; } }
        public ConsoleColor ErrorColor { get { return _errorColor | _errorColorDefault; } set { _errorColor = value; } }
        public ConsoleColor SuccessColor { get { return _sucessColor | _sucessColorDefault; } set { _sucessColor = value; } }

        const ConsoleColor _titleColorDefault = ConsoleColor.DarkGreen;
        const ConsoleColor _inputColorDefault = ConsoleColor.Gray;
        const ConsoleColor _errorColorDefault = ConsoleColor.DarkRed;
        const ConsoleColor _sucessColorDefault = ConsoleColor.DarkGreen;
        ConsoleColor _titleColor;
        ConsoleColor _inputColor;
        ConsoleColor _errorColor;
        ConsoleColor _sucessColor;
        int _inputPos = -1;
        int _errorPos = -1;

        Message _titleMsg;
        Message _errorMsg;
        Message _successMsg;

        Validator.ValidateWithError _validate;

        public ConsoleInput(string title, Validator.ValidateWithError validate)
        {
            Title = title;
            _validate = validate;
        }

        public ConsoleInput(string title)
            : this(title, null)
        { }

        public void Render()
        {
            RenderTitle();
            while (!Success)
            {
                RenderInput();
            }
        }

        void RenderTitle()
        {
            _titleMsg = new Message(Title, TitleColor);
        }

        void RenderInput()
        {
            ClearInput();
            ConsoleCustom.SetColor(InputColor);
            _inputPos = Console.CursorTop;
            Input = Console.ReadLine();
            ConsoleCustom.ResetColor();
            Validate();
        }

        void RenderError(string errorMsg)
        {
            _errorPos = Console.CursorTop;
            _errorMsg = new Message(errorMsg, ErrorColor);
        }

        void EraseError()
        {
            if (_errorMsg == null) return;

            _errorMsg.Erase();
        }

        void RenderSuccess()
        {
            _successMsg = new Message(SuccessMessage, SuccessColor);
        }

        void Validate()
        {
            if (_validate != null && _validate(Input).Length != 0)
            {
                RenderError(_validate(Input));
                Success = false;
            }
            else
            {
                EraseError();
                if (_errorPos != -1)
                {
                    Console.SetCursorPosition(0, _errorPos);
                }
                RenderSuccess();
                Success = true;
            }
        }

        void ClearInput()
        {
            if (_errorMsg == null) return;

            Console.SetCursorPosition(0, _inputPos);
            ConsoleCustom.WriteLine(new String(' ', Console.WindowWidth), Console.ForegroundColor);
            Console.SetCursorPosition(0, _inputPos);
        }
    }
}
