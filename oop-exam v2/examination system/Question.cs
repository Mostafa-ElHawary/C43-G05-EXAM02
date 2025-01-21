using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public abstract class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        public List<Answer> AnswerList { get; set; }
        public Answer CorrectAnswer { get; set; }

        protected Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }

        public abstract object Clone();

        public int CompareTo(Question other)
        {
            return Mark.CompareTo(other.Mark);
        }

        public override string ToString()
        {
            return $"Header: {Header}\nQuestion: {Body}\nMark: {Mark}";
        }
    }
}
