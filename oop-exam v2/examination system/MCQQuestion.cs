using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, double mark)
            : base(header, body, mark)
        {
        }

        public override object Clone()
        {
            var clone = new MCQQuestion(Header, Body, Mark);
            clone.AnswerList = AnswerList.ToList();
            clone.CorrectAnswer = CorrectAnswer;
            return clone;
        }
    }
}
