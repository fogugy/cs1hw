using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        //Анкета
        static void Main(string[] args)
        {
            string name;
            string lastname;
            int age;
            float height;
            float weight;

            Console.WriteLine("---Анкета---");

            UserInput(out name, "Введите имя");
            UserInput(out lastname, "Введите фамилию");
            UserInput(out age, "Введите возраст");
            UserInput(out height, "Введите рост(см)");
            UserInput(out weight, "Введите вес");

            Console.WriteLine("using concatenation:");
            Console.WriteLine(name+"\t"+lastname+"\t"+age+"\t"+height+"\t"+weight);
            Console.WriteLine("using formatting");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", name, lastname, age, height, weight);
            Console.WriteLine("using new formatting thing");
            Console.WriteLine($"{name}\t{lastname}\t{age}\t{height}\t{weight}");

            Console.Write("Индекс массы тела = ");
            Console.WriteLine(weight / Math.Pow(height/100, 2));
        }

        static void UserInput(out string value, string message)
        {
            Console.Write(message + "\t");
            value = Console.ReadLine();
        }

        static void UserInput(out int value, string message)
        {
            Console.Write(message + "\t");
            int.TryParse(Console.ReadLine(), out value);
        }

        static void UserInput(out float value, string message)
        {
            Console.Write(message + "\t");
            float.TryParse(Console.ReadLine(), out value);
        }
    }
}
