using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class FinalExam : Exam

    {
        public FinalExam(int time,int numberofQuestion):base(time,numberofQuestion) { }
        public override void CreateListOfQuestions()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                int typeOfQuestion;
                do
                {
                    Console.Write($"Please Choose The Type Of Question Number({i + 1}) (1 for MCQ || 2 for True/False) : ");
                } while (!int.TryParse(Console.ReadLine(), out typeOfQuestion) || typeOfQuestion < 1 || typeOfQuestion > 2);
                Console.Clear();

                Questions[i] = typeOfQuestion == 1 ? new MCQ1Choice() : new TFQuestion();
                Questions[i].AddQuestion();
            }
        }
        protected override void ShowCustomResults(int grade, int totalmark)
        {
            Console.WriteLine("Questions,Your Answers and Grades:");

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q{i + 1}) {Questions[i].Body}");
                Console.WriteLine($"Your Answer: {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Grade for this question: {Questions[i].Mark}");
            }

            Console.WriteLine($"Your Final Exam Grade Is {grade}/{totalmark}");
        }
    }
}
