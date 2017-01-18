using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //Обмен переменными
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = 0;
            var i = 0;
            Console.WriteLine('\u221E');
            //способ с третьей переменной
            int buffer = 0;
            x1 = 10;
            x2 = 20;
            Console.WriteLine("Способ с третьей переменной");
            Console.WriteLine($"До: \t{x1} - {x2}");
            buffer = x1;
            x1 = x2;
            x2 = buffer;
            Console.WriteLine($"После: \t{x1} - {x2}");

            //способ без третьей переменной
            x1 = 10;
            x2 = 20;
            Console.WriteLine("Способ без третьей переменной");
            Console.WriteLine($"До: \t{x1} - {x2}");
            x1 = x1 + x2;
            x2 = x1 - x2;
            x1 = x1 - x2;
            Console.WriteLine($"После: \t{x1} - {x2}");
           
            
        }
    }
}
