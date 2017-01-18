using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML = MyLib;

namespace Yuri_Zinovev__Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ML.Task task1 = new Task1_Login();
            ML.Task task2 = new Task2_MyString();
            ML.Task task3 = new Task3_StringReshuffle();
            ML.Task task4 = new Task4_EGE();

            task1.Run();
            task2.Run();
            task3.Run();
            task4.Run();
        }
    }
}
