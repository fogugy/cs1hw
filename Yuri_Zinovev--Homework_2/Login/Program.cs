using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Юрий Зиновьев
namespace Login
{
    class Program
    {
        static string _login = "admin";
        static string _password = "admin";
        static int _maxAttemptCount = 3;

        static void Main(string[] args)
        {
            int i = _maxAttemptCount;

            do
            {
                if (!LoginAttempt())
                {
                    i--;
                    Console.Clear();
                    if (i != _maxAttemptCount)
                    {
                        Console.WriteLine($"{i} attempts left");
                    }
                } else
                {
                    Login();
                    break;
                }
            } while (i != 0);

            if(i == 0)
            {
                Console.WriteLine("All login attempts were used. Try to recover pasword with email service.");
            }
        }

        static bool LoginAttempt()
        {
            string inputLogin;
            string inputPassword;

            Console.Write("Login: ");
            inputLogin = Console.ReadLine();
            Console.Write("Password: ");
            inputPassword = Console.ReadLine();

            return inputLogin == _login && inputPassword == _password;
        }

        static void Login()
        {
            Console.WriteLine("Login success..");
        }
    }
}
