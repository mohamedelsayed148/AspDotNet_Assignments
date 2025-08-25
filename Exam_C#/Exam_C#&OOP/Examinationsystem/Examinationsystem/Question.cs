using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsystem
{
    internal abstract class Question
    {
        public int Mark { get; set; }
        public string? Header { get; set; }
        public string? Body { get; set; }


        public List<Answer> Answers { get; set; }

        public  Answer ? CorrectAnswer { get; set; }

        public  int AnswerQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");

            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].AnswerText}");
            }

            return TakeAnswer();


        }

        public int TakeAnswer()
        {
            Console.WriteLine("Please enter the number of your answer:");

            int userAnswer = int.Parse(Console.ReadLine()!);
            if (CorrectAnswer!.AnswerId == userAnswer)
            {
                Console.WriteLine("Correct Answer!");
                return Mark;
            }

            Console.WriteLine($"Wrong Answer! The correct answer is: {CorrectAnswer.AnswerText}");
            return 0;
        }

        public Question(int _Mark, string _Header, string _Body)
        {
            Mark = _Mark;
            Header = _Header;
            Body = _Body;

            Answers = new List<Answer>();          
        }
    }
}
