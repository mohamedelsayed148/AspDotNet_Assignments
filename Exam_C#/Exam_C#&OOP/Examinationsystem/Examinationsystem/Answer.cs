﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer(int _answerId, string _answerText)
        {
            AnswerId = _answerId;
            AnswerText = _answerText;
        }

    }
}
