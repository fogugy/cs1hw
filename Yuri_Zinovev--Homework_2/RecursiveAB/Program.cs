using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Юрий Зиновьев
namespace RecursiveAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Enter A: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter B: ");
            int.TryParse(Console.ReadLine(), out b);

            PrintRecursive(a, b);
        }

        static void PrintRecursive(int a, int b)
        {
            if(a > b)
            {
                return;
            }

            Console.WriteLine(a++);
            PrintRecursive(a, b);
        }
    }
}
