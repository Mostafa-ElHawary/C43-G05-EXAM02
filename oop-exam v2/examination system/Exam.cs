using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public abstract class Exam
    {
        public TimeSpan TimeAllowed { get; set; }
        public int NumberOfQuestions { get; set; }
        protected List<Question> Questions { get; set; }

        protected Exam(TimeSpan timeAllowed, int numberOfQuestions)
        {
            TimeAllowed = timeAllowed;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>();
        }

        public abstract void ShowExam();
        public abstract void AddQuestion(Question question);
    }

}
