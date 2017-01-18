using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    class Task1_ComplexNumbers : Task
    {
        public Task1_ComplexNumbers()
        {
            Name = "Определение операторов +,-,* \nдля структуры и класса \"Комплексное число\" \nи демонстрация";
        }

        override public void Run()
        {
            base.Run();

            var sc1 = new Struct.Complex(1, 1);
            var sc2 = new Struct.Complex(0, 0.5);
            var cc1 = new Class.Complex(2, 3.6);
            var cc2 = new Class.Complex(0, 0.5);

            Demo("Структура:", sc1, sc2);
            Demo("Класс:", cc1, cc2);

            Finish();
        }

        void Demo(string title, dynamic c1, dynamic c2)
        {
            Console.WriteLine(title);
            Console.WriteLine($"\t{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"\t{c1} - {c2} = {c1 - c2}");
            Console.WriteLine($"\t{c1} * {c2} = {c1 * c2}");
            Console.WriteLine();
        }
    }
}
