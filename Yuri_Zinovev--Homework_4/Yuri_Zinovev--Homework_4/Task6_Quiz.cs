using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace Yuri_Zinovev__Homework_4
{
    public class Task6_Quiz : MyLib.Task
    {
        public Task6_Quiz()
        {
            Name = "Игра Верю / Не верю";
        }

        public override void Run()
        {
            base.Run();

            var quiz = new Quiz();
            quiz.Questions = DataAccess.ReadQuestions(5);

            foreach (Question q in quiz.Questions)
            {
                quiz.Answers.Add(new Answer(q.ID, AskQuestion(q)));
            }

            var passed = quiz.CheckAnswers();

            if (passed)
            {
                ConsoleCustom.WriteLine("Quizz Passed!", ConsoleColor.Green);
                if (quiz.WrongAnswers.Count != 0)
                {
                    PrintMistakes(quiz);
                }
            }
            else
            {
                ConsoleCustom.WriteLine("Quizz Failed =(", ConsoleColor.Red);
                PrintMistakes(quiz);
            }

            Finish();
        }

        void PrintMistakes(Quiz quiz)
        {
            ConsoleCustom.WriteLine($"With {quiz.WrongAnswers.Count} mistake(s):", ConsoleColor.DarkRed);
            foreach (var q in quiz.WrongAnswers)
            {
                ConsoleCustom.WriteLine(q.Description, ConsoleColor.DarkRed);
                ConsoleCustom.WriteLine(q.RightAnswer ? "Правда" : "Ложь", ConsoleColor.DarkGreen);
            }
        }

        bool AskQuestion(Question q)
        {
            ConsoleKeyInfo key;

            ConsoleCustom.WriteLine(q.Description, ConsoleColor.DarkGreen);
            ConsoleCustom.Write("(press y/n) ", ConsoleColor.DarkGray);

            do
            {
                key = Console.ReadKey();
                if (!KeyAccepted(key))
                {
                    ConsoleCustom.EraseLast();
                    ConsoleCustom.Write("(press y/n) ", ConsoleColor.DarkGray);
                }
            } while (!KeyAccepted(key));

            Console.WriteLine();
            return key.Key == ConsoleKey.Y;
        }

        bool KeyAccepted(ConsoleKeyInfo key)
        {
            return key.Key == ConsoleKey.Y || key.Key == ConsoleKey.N;
        }
    }
}
