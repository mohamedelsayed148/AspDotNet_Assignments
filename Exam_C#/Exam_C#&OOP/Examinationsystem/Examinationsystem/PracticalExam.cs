using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, List<Question> questions) : base(time, questions)
        {
        }
        public override void ShowExam()
        {
            Console.Clear();

            int grade = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                grade += Questions[i].AnswerQuestion();

            }
            Console.Clear();
            // Show the right answers after the exam
            Console.WriteLine("The correct answers are:");
            Console.WriteLine(
                string.Join("\n", Questions.Select(q => $"{q.Header}\n{q.Body}\nCorrect Answer: {q.CorrectAnswer!.AnswerText}\n"))
            );
        }
    }
   
}
