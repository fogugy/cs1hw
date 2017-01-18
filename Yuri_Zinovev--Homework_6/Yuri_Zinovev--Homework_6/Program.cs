using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML = MyLib;

//Юрий Зиновьев
namespace Yuri_Zinovev__Homework_6
{
    public class Program
    {
        static void Main(string[] args)
        {
            ML.Task task1 = new Task1_MathFuncDelegate();
            ML.Task task2 = new Task2_FuncMinimunWithMenu();
            ML.Task task3 = new Task3_StudentCounter();

            task1.Run();
            task2.Run();
            task3.Run();
        }
    }
}
