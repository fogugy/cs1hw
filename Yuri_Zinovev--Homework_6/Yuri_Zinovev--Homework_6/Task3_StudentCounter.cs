using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using System.IO;
using Models;

namespace Yuri_Zinovev__Homework_6
{
    public class Task3_StudentCounter : MyLib.Task
    {
        public Task3_StudentCounter()
        {
            Name = "Student File counters";
        }

        public override void Run()
        {
            base.Run();

            string filePath = FileAPI.FilePath("students_1.csv");
            List<Student> students = new List<Student>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    Student student = Mapper.Parse<Student>(sr.ReadLine(), ';');
                    students.Add(student);
                }
            }

            ConsoleCustom.WriteLine($"На 5 и 6 курсе учится {students.Where(x => x.Course == 5 || x.Course == 6).ToList().Count} студентов", ConsoleColor.Gray);

            var _18To20YO = students.Where(x => IsYO(x, 18, 20)).ToList();
            var _groupedByCourse = _18To20YO.OrderBy(x => x.Course).GroupBy(x => x.Course);

            ConsoleCustom.PrintTable<IGrouping<int, Student>>($"Всего {_18To20YO.Count} студентов, учащихся на", StudentGroupedParser, _groupedByCourse, false);

            students.Sort(Student.CompareByAge);
            ConsoleCustom.PrintTable<Student>("Отсортированные по возрасту (первые 20):", StudentParser, students.Take(20), false);

            students.Sort(Student.CompareByGroupThenAge);
            ConsoleCustom.PrintTable<Student>("Отсортированные по группе, потом возрасту (первые 20):", StudentParser, students.Take(20), false);

            Finish();
        }

        bool IsYO(Student student, int min, int max)
        {
            return student.Age >= min && student.Age <= max;
        }

        string StudentGroupedParser(IGrouping<int, Student> group)
        {
            return String.Format($"{group.Key} курсе - {group.Count()} студентов");
        }
        
        string StudentParser(Student std)
        {
            return String.Format($"Age: {std.Age}\tGroup: {std.Group}\t Name: {std.FirstName}");
        }
    }
}
