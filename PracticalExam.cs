using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class PracticalExam : Exam
    { 
        public PracticalExam(int time,int numberofquestion):base(time,numberofquestion) { }

        public override void CreateListOfQuestions()
        {
   
            for(int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQ1Choice();
                Questions[i].AddQuestion();
                Console.Clear();

            }
           
        }
        protected override void ShowCustomResults(int grade,int totalmark)
        {
            Console.WriteLine("Your Exam Results with Correct Answers:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q{i + 1})   {Questions[i].Body} : {Questions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"The Correct Answer is: {Questions[i].CorrectAnswer.AnswerText}");
            }
        }

    }
}
