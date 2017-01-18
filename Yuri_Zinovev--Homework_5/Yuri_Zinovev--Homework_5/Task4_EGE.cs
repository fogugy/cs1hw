using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using System.Text.RegularExpressions;
using Models;
using System.IO;

namespace Yuri_Zinovev__Homework_5
{
    public class Task4_EGE : MyLib.Task
    {
        public Task4_EGE()
        {
            Name = "ЕГЭ джедаев";
        }

        public override void Run()
        {
            base.Run();

            string allText = FileAPI.Read("EGEResults.txt");
            List<string> studentsRows = new List<string>();
            List<StudentResult> studentResults = new List<StudentResult>();
            List<StudentResult> worstResults = new List<StudentResult>();
            int studentsCount = 0;

            GetStudentsCount(allText, ref studentsCount);
            GetStudentsRows(allText, ref studentsRows, studentsCount);
            ParseStudents(studentsRows, ref studentResults);
            GetWorstResults(studentResults, ref worstResults);

            ConsoleCustom.WriteLine("Лучший студент:");
            ConsoleCustom.WriteLine(studentResults.OrderByDescending(x=>float.Parse(x.AverageMark)).First().ToString(), ConsoleColor.DarkGreen);

            ConsoleCustom.WriteLine("Худшие студенты:");
            foreach (var s in worstResults)
                ConsoleCustom.WriteLine(s.ToString(), ConsoleColor.DarkRed);

            Finish();
        }

        void GetStudentsCount(string txt, ref int count)
        {
            string studentsCountStr = new Regex(@"^[\d]+").Match(txt).Value;

            int studentsCount;
            int.TryParse(studentsCountStr, out studentsCount);
        }

        void GetStudentsRows(string txt, ref List<string> studentsRows, int count)
        {
            string pattern = @"([A-zА-яЁё]+\s){2}(\d{1}\s){2}\d{1}";

            foreach (Match m in Regex.Matches(txt, pattern))
            {
                studentsRows.Add(m.Value);
            }
        }

        void ParseStudents(List<string> source, ref List<StudentResult> results)
        {
            results = Mapper.ParseList<StudentResult>(source);
        }

        void GetWorstResults(List<StudentResult> studentResults, ref List<StudentResult> worstResults)
        {
            List<StudentResult> worst3 = studentResults.OrderBy(x => float.Parse(x.AverageMark)).Take(3).ToList();
            List<StudentResult> others = studentResults.FindAll(x => x.AverageMark == worst3.Last().AverageMark).ToList();
            List<StudentResult> all = new List<StudentResult>();

            foreach (var el in others)
                all.Add(el);
            foreach (var el in worst3)
                all.Add(el);

            worstResults = all.Distinct().ToList().OrderBy(x => float.Parse(x.AverageMark)).ToList();
        }
    }
}
