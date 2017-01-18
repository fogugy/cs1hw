using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MyLib;

//Юрий Зиновьев
namespace Yuri_Zinovev__Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLib.Task task1 = new Task1_CustomArray();
            MyLib.Task task2 = new Task2_CustomArray();
            MyLib.Task task6 = new Task6_Quiz();

            task1.Run();
            task2.Run();
            task6.Run();
        }
    }
}
