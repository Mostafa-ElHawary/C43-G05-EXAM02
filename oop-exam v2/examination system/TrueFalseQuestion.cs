using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, double mark)
            : base(header, body, mark)
        {
            AnswerList.Add(new Answer(1, "True"));
            AnswerList.Add(new Answer(2, "False"));
        }

        public override object Clone()
        {
            var clone = new TrueFalseQuestion(Header, Body, Mark);
            clone.CorrectAnswer = CorrectAnswer;
            return clone;
        }
    }
}
