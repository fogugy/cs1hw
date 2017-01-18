using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    class Task2_NumbersInputException : Task
    {
        List<int> _numbers = new List<int>();

        public Task2_NumbersInputException()
        {
            Name = "Ввод с клавиатуры чисел, подсчет суммы положительных нечетных. try catch, exception loging";
        }

        public override void Run()
        {
            int lastInput = 0;

            base.Run();
            Console.WriteLine("Вводите числа:");

            do
            {
                lastInput = InputSumm();

            } while (lastInput != 0);

            Console.WriteLine($"Сумма чисел = {_numbers.Sum()}");

            Finish();
        }

        int InputSumm()
        {
            int number = 0;

            try
            {
                number = int.Parse(Console.ReadLine());
                _numbers.Add(number);
            }
            catch (Exception e)
            {
                ConsoleCustom.WriteLine(e.Message, ConsoleColor.Red);
            }

            return number;
        }
    }
}
