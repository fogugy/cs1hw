using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //Custom Output
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Юрий Зиновьев";
            string city = "Саратов";
            int xStart = 10;
            int yStart = 5;

            Output.PrintLine(fullName, ref xStart, ref yStart);
            xStart = 10;
            Output.PrintLine(city, ref xStart, ref yStart);

            Output.Pause();
        }
    }

    class Output
    {
        public static void Print(string message, ref int xPos, ref int yPos)
        {
            Console.SetCursorPosition(xPos, yPos++);
            Console.Write(message);
            xPos += message.Length + 1;
        }

        public static void PrintLine(string message, ref int xPos, ref int yPos)
        {
            Output.Print(message+"\n", ref xPos, ref yPos);
        }

        public static void Pause()
        {
            Console.Read();
        }

        public static void PauseLine()
        {
            Console.ReadLine();
        }
    }
}
