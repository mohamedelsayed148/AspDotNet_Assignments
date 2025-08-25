using System.Runtime.InteropServices;

namespace Examinationsystem
{
    internal class Program
    {

        static void PrintLine()
        {
            Console.WriteLine("--------------------------------------------------");
        }

        static TrueOrFalse CreateTFQ() {
            Console.Clear();
            Console.WriteLine("True Or False");

            Console.WriteLine("Enter the question Header:");
            string questionText = Console.ReadLine()!;
            Console.WriteLine("Enter the question Body:");
            string questionTitle = Console.ReadLine()!;

            int userAnswer = -1;
            while (userAnswer < 1 || userAnswer >2)
            {
                Console.WriteLine("Enter the correct answer 1 for true || 2 for false:");
                userAnswer = int.Parse(Console.ReadLine()!);
            }
            Answer correctAnswer = new Answer(userAnswer, userAnswer == 1 ? "true" : "false");

            Console.WriteLine("Enter the mark");
            int mark = int.Parse(Console.ReadLine()!);

            TrueOrFalse tfq = new TrueOrFalse(mark, questionText, questionTitle, correctAnswer);
            Console.Clear();
            return tfq;
        }
        static MCQ createMCQ()
        {
            Console.Clear();
            Console.WriteLine("MCQ");
            Console.WriteLine("Enter the question Header:");
            string questionText = Console.ReadLine()!;
            Console.WriteLine("Enter the question Body:");
            string questionTitle = Console.ReadLine()!;

            List<Answer> answers = new List<Answer>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Enter answer option {i}:");
                string answerText = Console.ReadLine()!;
                answers.Add(new Answer(i, answerText));
            }

            int correctAnswerNumber = -1;
            while (correctAnswerNumber <1 || correctAnswerNumber > 4)
            {
                Console.WriteLine("Enter the number of the correct answer (1-4):");
                correctAnswerNumber = int.Parse(Console.ReadLine()!);
            }
            Answer correctAnswer = answers.Find(a => a.AnswerId == correctAnswerNumber)!;

            Console.WriteLine("Enter the mark");
            int mark = int.Parse(Console.ReadLine()!);

            MCQ mcq = new MCQ(mark, questionText, questionTitle, answers, correctAnswer);
            Console.Clear();
            return mcq;
        }
        static PracticalExam CreatePracticalExam(int time, int numberOfQuestions)
        {
            Console.Clear();

            List<Question> questions = new List<Question>();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                questions.Add(createMCQ());
            }
            PracticalExam practicalExam = new PracticalExam(time, questions);
            return practicalExam;
        }

        static FinalExam CreateFinalExam(int time, int numberOfQuestions)
        {
            Console.Clear();

            List<Question> questions = new List<Question>();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("Enter the type of question (1 for MCQ || 2 for True/False):");
                int questionType = int.Parse(Console.ReadLine()!);
                if (questionType == 1)
                {
                    questions.Add(createMCQ());
                }
                else if (questionType == 2)
                {
                    questions.Add(CreateTFQ());
                }
                else
                {
                    Console.WriteLine("Invalid question type. Please enter 1 or 2.");
                    i--; // Decrement i to repeat this iteration
                }
            }
            FinalExam finalExam = new FinalExam(time, questions);
            return finalExam;
        }

        static void StartExam(Exam exam)
        {
            Console.Clear();

            Console.WriteLine("Do you want to start the exam? (Y | N)");
            string userResponse = Console.ReadLine()!;
            if (userResponse.ToLower() != "y")
            {
                Console.WriteLine("Exam not started.");
                return;
            }
            PrintLine();
            Console.WriteLine("Starting the exam...");
            PrintLine();
            
            //int totalScore = 0;
            
            //foreach (var question in exam.Questions)
            //{
            //    totalScore += question.AnswerQuestion();
            //    PrintLine();
            //}
            //Console.WriteLine($"Your total score is: {totalScore}/{exam.Questions.Count * 5}");
            //PrintLine();
            exam.ShowExam();
        }
        static void Main(string[] args)
        {

            ////FinalExam Xam = new FinalExam(120, new List<Question>
            ////{
            ////    new MCQ(5, "What is the capital of France?", "Choose the correct answer:", new List<Answer>
            ////    {
            ////        new Answer(1,"A) Berlin"),
            ////        new Answer(2,"B) Madrid"),
            ////        new Answer(3,"C) Paris"),
            ////        new Answer(4,"D) Rome")
            ////    }, new Answer(3,"C) Paris")),

            ////    new TrueOrFalse(5, "are you man?", "True or false", new Answer (1,"true")),



            ////});


            //Xam.ShowExam();

            Console.WriteLine("Enter the type of Exam: (1 for Practical || 2 for Final)");

            int userAnswer = int.Parse(Console.ReadLine()!);

            if (userAnswer == 1)    // Practical Exam
            {
                Console.WriteLine("Enter the duration of the Practical Exam from 30 mins to 100 mins");
                int time = int.Parse(Console.ReadLine()!);

                if (time >= 30 && time <= 100)
                {
                    Console.WriteLine("Enter the number of Questions");
                    int numberOfQuestions = int.Parse(Console.ReadLine()!);

                    if (numberOfQuestions > 0)
                    {
                        PracticalExam practicalExam = CreatePracticalExam(time, numberOfQuestions);

                        StartExam(practicalExam);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of questions. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a duration between 30 and 100 minutes.");
                }
            }
            else if (userAnswer == 2)   // Final Exam
            {
                Console.WriteLine("Enter the duration of the Final Exam from 30 mins to 100 mins");
                int time = int.Parse(Console.ReadLine()!);

                if (time >= 30 && time <= 100)
                {
                    Console.WriteLine("Enter the number of Questions");
                    int numberOfQuestions = int.Parse(Console.ReadLine()!);

                    if (numberOfQuestions > 0)
                    {
                        FinalExam finalExam = CreateFinalExam(time, numberOfQuestions);
                        StartExam(finalExam);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of questions. Please enter a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a duration between 30 and 100 minutes.");
                }
            }
            else
            {
                Console.WriteLine("Bad request");
            }


        }
    }
}
