using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MyLib;

namespace Yuri_Zinovev__Homework_5
{
    public class Task1_Login : MyLib.Task
    {
        Regex loginPattern = new Regex(@"^[A-Za-z]\w{1,9}$");

        public Task1_Login()
        {
            Name = "Проверка логина паттерном";
        }

        public override void Run()
        {
            base.Run();

            ConsoleInput ci = new ConsoleInput("Введите пароль", LoginValidation);
            ci.SuccessMessage = "Логин подходит";
            ci.Render();

            Finish();
        }

        string LoginValidation(string s)
        {
            return loginPattern.IsMatch(s) ? "" : "Логин не соответствует паттерну";
        }
    }
}
