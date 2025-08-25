using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal class MCQ : Question
    {
        public MCQ(int mark, string header, string body, List<Answer> answers, Answer correctAnswer)
            : base(mark, header, body)
        {
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }

        
        
    }
}
