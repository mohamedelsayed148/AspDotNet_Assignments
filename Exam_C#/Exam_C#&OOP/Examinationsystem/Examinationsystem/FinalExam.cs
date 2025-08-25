using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, List<Question> questions) : base(time, questions)
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
            Console.WriteLine($"Your final grade is: {grade}");
        }
    }
}
