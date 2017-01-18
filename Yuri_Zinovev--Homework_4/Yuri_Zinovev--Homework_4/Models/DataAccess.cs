using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MyLib;

namespace Yuri_Zinovev__Homework_4
{
    public static class DataAccess
    {
        static string _rootPath = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
        static string _fileName = "questions.txt";
        static string _filePath = _rootPath + "\\Data\\" + _fileName;

        public static List<Question> ReadQuestions(int? count)
        {
            string localPath = new Uri(_filePath).LocalPath;
            List<Question> q = new List<Question>();

            try
            {
                using (StreamReader sr = new StreamReader(localPath))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        q.Add(ParseQuestion(line));
                    }
                }
            }
            catch (Exception e)
            {
                ConsoleCustom.WriteLine("The file could not be read:", ConsoleColor.Red);
                ConsoleCustom.WriteLine(e.Message, ConsoleColor.Red);
            }

            return q;
        }

        public static List<Question> ReadQuestions()
        {
            return ReadQuestions(null);
        }

        public static Question ParseQuestion(string line)
        {
            var rgxDescription = new Regex(@"^.*\t");
            var rgxAnswer = new Regex(@"(true)|(false)");

            var description = rgxDescription.Match(line).Value;
            var value = Boolean.Parse(rgxAnswer.Match(line).Value);
            
            return new Question(description, value);
        }
    }
}
