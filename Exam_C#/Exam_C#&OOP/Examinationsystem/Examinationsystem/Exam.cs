using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal abstract class Exam
    {
        public int Time { get; set; }

        public int NumberOfQuestions => Questions.Count;

        public List<Question> Questions = new List<Question>();


        protected Exam(int time, List<Question> questions)
        {
            Time = time;
            Questions = questions;
        }

        public abstract void ShowExam();
    }
}
