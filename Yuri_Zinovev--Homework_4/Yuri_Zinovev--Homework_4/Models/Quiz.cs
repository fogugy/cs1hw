using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yuri_Zinovev__Homework_4
{
    public class Quiz
    {
        public List<Question> Questions = new List<Question>();
        public List<Answer> Answers = new List<Answer>();

        public List<Question> RightAnswers { get; private set; }
        public List<Question> WrongAnswers { get; private set; }

        public Quiz()
        {
            RightAnswers = new List<Question>();
            WrongAnswers = new List<Question>();
        }

        public bool CheckAnswers()
        {
            foreach (var q in Questions)
            {
                var a = Answers.Find(x => x.QuestionID == q.ID);

                if (q.CheckAnswer(a.Value))
                {
                    RightAnswers.Add(q);
                }
                else
                {
                    WrongAnswers.Add(q);
                }
            }

            return IsPassed();
        }

        public bool IsPassed()
        {
            return Questions.Count <= RightAnswers.Count + 1;
        }
    }
}
