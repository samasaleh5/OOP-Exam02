using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class TFQuestion : QuestionBase
    {
        public override string Header => "True | False Question";
        public TFQuestion()
        {
            Answerlist = new Answer[2];
            Answerlist[0]=new Answer(1,"True");
            Answerlist[1]=new Answer(2,"False");
        }
        public override void AddQuestion()
        {
            Console.WriteLine(Header);
            GetQuestionBody();
            GetQuestionMark();

            int RightAnswerId;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Of Question (1 For True || 2 For False ) : ");
            } while (!int.TryParse(Console.ReadLine(), out RightAnswerId) || RightAnswerId < 1 || RightAnswerId > 3);
            CorrectAnswer.AnswerId = RightAnswerId;
            CorrectAnswer.AnswerText = Answerlist[RightAnswerId - 1].AnswerText;


            Console.Clear();

        }
    }
}
