using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(int _Mark, string _Header, string _Body, Answer _correctAnswer) : base(_Mark, _Header, _Body)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));

            CorrectAnswer = _correctAnswer;
        }

    }
}
