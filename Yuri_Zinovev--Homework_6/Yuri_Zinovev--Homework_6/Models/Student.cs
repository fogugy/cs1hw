using MyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student : ISetAttribute
    {
        public string LastName;
        public string FirstName;
        public string Univercity;
        public string Faculty;
        public int Course;
        public string Department;
        public int Group;
        public string City;
        public int Age;

        public override string ToString()
        {
            return String.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,5}{8,10}", FirstName, LastName, Univercity, Faculty, Department, Age, Course, Group, City);
        }

        public void SetAttributes(string[] attrs)
        {
            FirstName = attrs[0];
            LastName = attrs[1];
            Univercity = attrs[2];
            Faculty = attrs[3];
            Department = attrs[4];
            Age = int.Parse(attrs[5]);
            Course = int.Parse(attrs[6]);
            Group = int.Parse(attrs[7]);
            City = attrs[8];
        }

        static public int CompareByAge(Student std1, Student std2)
        {
            if (std1.Age == std2.Age)
            {
                return 0;
            }

            return std1.Age > std2.Age ? 1 : -1;
        }

        static public int CompareByGroupThenAge(Student std1, Student std2)
        {
            if (std1.Group == std2.Group)
            {
                return CompareByAge(std1, std2);
            }

            return std1.Group > std2.Group ? 1 : -1;
        }
    }
}
