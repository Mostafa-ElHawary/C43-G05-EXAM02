using oop_exam_v2.examination_system;

namespace oop_exam_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a subject
            Subject programming = new Subject(1, "Programming");

            // Create a practical exam for the subject
            programming.CreatePracticalExam(TimeSpan.FromMinutes(30), 2);

            // Create MCQ questions
            MCQQuestion q1 = new MCQQuestion("Basic C#", "What is the correct way to declare a variable in C#?", 5);
            q1.AnswerList.Add(new Answer(1, "var x = 5;"));
            q1.AnswerList.Add(new Answer(2, "x = 5;"));
            q1.AnswerList.Add(new Answer(3, "int x = 5;"));
            q1.AnswerList.Add(new Answer(4, "variable x = 5;"));
            q1.CorrectAnswer = q1.AnswerList[2]; // "int x = 5;" is correct

            MCQQuestion q2 = new MCQQuestion("OOP Concepts", "Which is not a pillar of OOP?", 5);
            q2.AnswerList.Add(new Answer(1, "Encapsulation"));
            q2.AnswerList.Add(new Answer(2, "Inheritance"));
            q2.AnswerList.Add(new Answer(3, "Synchronization"));
            q2.AnswerList.Add(new Answer(4, "Polymorphism"));
            q2.CorrectAnswer = q2.AnswerList[2]; // "Synchronization" is correct

            // Add questions to exam
            programming.SubjectExam.AddQuestion(q1);
            programming.SubjectExam.AddQuestion(q2);

            // Show the exam
            Console.WriteLine($"Welcome to {programming.SubjectName} Exam!");
            programming.SubjectExam.ShowExam();
        }
    }
}
