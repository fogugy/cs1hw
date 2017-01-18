using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_4
{
    public class Question
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public bool RightAnswer { get; set; }

        public Question(string description, bool rightAnswer)
        {
            ID = Guid.NewGuid();
            Description = description;
            RightAnswer = rightAnswer;
        }

        public bool CheckAnswer(bool answer)
        {
            return RightAnswer == answer;
        }
    }
}
