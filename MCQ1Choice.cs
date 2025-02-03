using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class MCQ1Choice : QuestionBase
    {
        public override string Header => "MCQ :Choose Only one Answer Question";

        public MCQ1Choice() 
        { 
            Answerlist = new Answer[3];
            CorrectAnswer = new Answer(); 

        }

        public override void AddQuestion()
        {
            int mark;
            Console.WriteLine(Header);

            GetQuestionBody();
            GetQuestionMark();

            Console.WriteLine("The Choices Of The Question");
            for (int i = 0; i < 3; i++)
            {
                Answerlist[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.Write($"Please Enter The Choice Number {i + 1} : ");
                Answerlist[i].AnswerText = Console.ReadLine();
            }

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 || 2 || 3 : )");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 3);
            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = Answerlist[RightAnswerId - 1].AnswerText;
            Console.Clear();
           
        }
    }
}
