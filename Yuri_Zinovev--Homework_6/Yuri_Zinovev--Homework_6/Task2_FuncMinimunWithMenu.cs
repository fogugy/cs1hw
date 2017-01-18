using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_6
{
    public class Task2_FuncMinimunWithMenu : MyLib.Task
    {
        List<FuncLoader> _functions = new List<FuncLoader>();

        public Task2_FuncMinimunWithMenu()
        {
            Name = "Нахождение минимума функции на отрезке";
        }

        public override void Run()
        {
            base.Run();

            _functions.Add(new FuncLoader(Math.Sin, "Sin"));
            _functions.Add(new FuncLoader(Math.Cos, "Cos"));
            _functions.Add(new FuncLoader(Math.Asin, "ASin"));
            _functions.Add(new FuncLoader(Math.Acos, "ACos"));
            ConsoleInput funcPicker = new ConsoleInput($"(1-{_functions.Count}) ", ValidateFunctionPickerInput);
            ConsoleInput minXInput = new ConsoleInput("от", ValidateDouble);
            ConsoleInput maxXInput = new ConsoleInput("до", ValidateDouble);
            ConsoleInput stepInput = new ConsoleInput("с шагом (или оставьте пустым - по умолчанию шаг 0.1)", ValidateStep);

            int funcIndex;
            double minX;
            double maxX;
            double step;

            ConsoleCustom.PrintTable<FuncLoader>($"Выберете функцию (1-{_functions.Count})", ParseLoader, _functions);
            funcPicker.Render();
            minXInput.Render();
            maxXInput.Render();
            stepInput.Render();

            funcIndex = int.Parse(funcPicker.Input);
            minX = double.Parse(minXInput.Input);
            maxX = double.Parse(maxXInput.Input);
            if (!double.TryParse(stepInput.Input, out step))
            {
                step = 0.1;
            }

            var func = _functions.ElementAt(funcIndex - 1);
            func.XMin = minX;
            func.XMax = maxX;
            func.Step = step;
            string min = String.Format("{0:0.0000}", func.GetMin());

            ConsoleCustom.WriteLine($"Минимум ф-ции \"{func.Name}\" на отрезке [{func.XMin}, {func.XMax}] равен {min}");

            Finish();
        }

        string ValidateFunctionPickerInput(string input)
        {
            int funcIndex = 0;
            bool parsed = int.TryParse(input, out funcIndex);

            if (!parsed || funcIndex <= 0 || funcIndex > _functions.Count)
            {
                return "Неверный индекс. Попробуйте снова";
            }

            return "";
        }

        string ValidateStep(string input)
        {
            if (input.Length == 0)
            {
                return "";
            }

            return ValidateDouble(input);
        }

        string ValidateDouble(string input)
        {
            double d = 0;
            if (!double.TryParse(input, out d))
            {
                return "не похоже на тип double, попробуйте снова";
            }

            return "";
        }

        string ParseLoader(FuncLoader loader)
        {
            return loader.Name;
        }
    }
}
