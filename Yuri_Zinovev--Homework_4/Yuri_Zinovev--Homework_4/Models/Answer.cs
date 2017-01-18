using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_4
{
    public struct Answer
    {
        public Guid QuestionID { get; set; }
        public bool Value { get; set; }

        public Answer(Guid id, bool value)
        {
            QuestionID = id;
            Value = value;
        }
    }
}
