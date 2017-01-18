using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task1_ComplexNumbers();
            task1.Run();
            Task task2 = new Task2_NumbersInputException();
            task2.Run();
            Task task3 = new Task3_Fractions();
            task3.Run();
        }
    }
}
