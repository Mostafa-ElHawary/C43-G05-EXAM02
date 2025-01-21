using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_v2.examination_system
{
    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan timeAllowed, int numberOfQuestions)
            : base(timeAllowed, numberOfQuestions)
        {
        }

        public override void AddQuestion(Question question)
        {
            if (question is TrueFalseQuestion || question is MCQQuestion)
            {
                if (Questions.Count < NumberOfQuestions)
                {
                    Questions.Add(question);
                }
            }
        }

        public override void ShowExam()
        {
            double totalScore = 0;
            Console.WriteLine("\n=== FINAL EXAM ===");
            Console.WriteLine($"Time Allowed: {TimeAllowed.TotalMinutes} minutes");

            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                Console.WriteLine(Questions[i]);

                foreach (var answer in Questions[i].AnswerList)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("\nYour answer (enter the answer number): ");
                if (int.TryParse(Console.ReadLine(), out int selectedAnswer))
                {
                    if (Questions[i].AnswerList.FirstOrDefault(a => a.AnswerId == selectedAnswer) == Questions[i].CorrectAnswer)
                    {
                        totalScore += Questions[i].Mark;
                    }
                }
            }

            Console.WriteLine($"\nFinal Grade: {totalScore}/{Questions.Sum(q => q.Mark)}");
        }
    }
}
