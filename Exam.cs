using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_Exam
{
    abstract class Exam
    {
        public int time {  get; set; }
        public int NumberOfQuestion {  get; set; }
        public QuestionBase[] Questions { get; set; }

        public Exam() { }
        public Exam(int time,int numberOfQuestion)
        {
            this.time = time;
            this.NumberOfQuestion = numberOfQuestion;
            Questions = new QuestionBase[numberOfQuestion];
        }

        public abstract void CreateListOfQuestions();
        public virtual void ShowExam()
        {
            int useranswer, totalmark = 0, grade = 0;

            foreach (var Question in Questions)
            {
                Console.WriteLine(Question);
                for (int i = 0; i < Question.Answerlist.Length; i++)
                {
                    Console.WriteLine(Question.Answerlist[i]);
                }
                Console.WriteLine("=================================");

                do
                {
                    Console.WriteLine("Please Enter Number of your answer : ");

               } while (!int.TryParse(Console.ReadLine(), out useranswer) || useranswer < 1 || useranswer > 3);
                Question.UserAnswer = Question.Answerlist[useranswer - 1];
                Console.WriteLine("=================================");


              
                totalmark += Question.Mark;
            }
            Console.Clear();
            Console.WriteLine("Your Answers:");
            for (int i = 0; i < Questions.Length; i++)
            {
                if (Questions[i].CorrectAnswer.AnswerId == Questions[i].UserAnswer.AnswerId)
                {
                    grade += Questions[i].Mark;
                }
                Console.WriteLine($"Q{i + 1})   {Questions[i].Body} : {Questions[i].UserAnswer.AnswerText}");
                //Console.Write($"Q{i + 1})   {Questions[i].Body} : ");
                //Console.WriteLine($"{Questions[i].UserAnswer.AnswerText}");
                //Console.WriteLine($"The Correct Answer is : {Questions[i].CorrectAnswer.AnswerText}");
            }
            ShowCustomResults(grade, totalmark);
            //Console.WriteLine($"Your Exam Grade Is {grade}/{totalmark}");
        }
        protected virtual void ShowCustomResults(int grade, int totalmark)
        {
            Console.WriteLine($"Your Exam Grade Is {grade}/{totalmark}");
        }



    }
}
