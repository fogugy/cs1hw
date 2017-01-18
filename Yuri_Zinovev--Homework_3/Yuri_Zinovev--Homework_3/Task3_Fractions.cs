using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    class Task3_Fractions : Task
    {
        public Task3_Fractions()
        {
            Name = "Определение операторов для класса \"Дробь\" и демонстрация";
        }

        public override void Run()
        {
            var f1 = new Class.Fraction(2,5);
            var f2 = new Class.Fraction(7,4);
            var f3 = new Class.Fraction();

            base.Run();

            Console.WriteLine($"F1= {f1}\nF2= {f2}");

            f3 = f1 + f2;
            f3.TrySimplify();
            Console.WriteLine($"\t{f1} + {f2} = {f3}");

            f3 = f1 - f2;
            f3.TrySimplify();
            Console.WriteLine($"\t{f1} - {f2} = {f3}");

            f3 = f1 * f2;
            f3.TrySimplify();
            Console.WriteLine($"\t{f1} * {f2} = {f3}");

            f3 = f1 / f2;
            f3.TrySimplify();
            Console.WriteLine($"\t{f1} / {f2} = {f3}");

            Finish();
        }
    }
}
