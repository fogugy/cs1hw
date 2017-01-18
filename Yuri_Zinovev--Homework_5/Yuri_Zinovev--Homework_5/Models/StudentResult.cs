using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using System.Collections;

namespace Models
{
    public class StudentResult : ISetAttribute, IEqualityComparer<StudentResult>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<int> Marks { get; set; }

        public string AverageMark
        {
            get
            {
                return String.Format("{0:0.0}", (float)Marks.Sum() / Marks.Count);
            }
        }

        public StudentResult() { }

        public void SetAttributes(string[] attrs)
        {
            Name = attrs[0];
            LastName = attrs[1];
            Marks = attrs.Skip(2).Select(x => int.Parse(x)).ToList();
        }

        public override string ToString()
        {
            return String.Format($"{Name} {LastName} {AverageMark}");
        }

        bool IEqualityComparer<StudentResult>.Equals(StudentResult x, StudentResult y)
        {
            return x.Name == y.Name && x.LastName == y.LastName;
        }

        int IEqualityComparer<StudentResult>.GetHashCode(StudentResult obj)
        {
            return Name.GetHashCode() + LastName.GetHashCode();
        }
    }
}
