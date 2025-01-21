using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam SubjectExam { get; private set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateFinalExam(TimeSpan duration, int questionCount)
        {
            SubjectExam = new FinalExam(duration, questionCount);
        }

        public void CreatePracticalExam(TimeSpan duration, int questionCount)
        {
            SubjectExam = new PracticalExam(duration, questionCount);
        }
    }
}
