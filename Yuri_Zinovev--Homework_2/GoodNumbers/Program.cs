using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Юрий Зиновьев
namespace GoodNumbers
{
    class Program
    {   
        static void Main(string[] args)
        {
            int number = 1000000;
            int count = 0;
            DateTime startTime = DateTime.Now;
            DateTime finishTime = new DateTime();
            TimeSpan timeDelta = new TimeSpan();

            for (int i = 1; i <= number; i++)
            {
                if (IsDivisionable(i))
                {
                    count++;
                }
            }

            finishTime = DateTime.Now;
            timeDelta = finishTime - startTime;

            Console.WriteLine($"There are {count} good numbers for range 0 - {number}");
            Console.WriteLine($"And it took {timeDelta.TotalMilliseconds} milliseconds");
        }

        static bool IsDivisionable(int number)
        {
            int summ = Summ(number);

            return number % summ == 0;
        }

        static int Summ(int number)
        {
            int pow = number.ToString().Length;
            int summ = 0;
            
            for(int i = 1; i <= pow; i++)
            {
                summ += (int) (number % Math.Pow(10, i));
                number /=  (int) Math.Pow(10, i);
            }
            
            return summ;
        }
    }
}
