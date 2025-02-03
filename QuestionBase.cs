using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    abstract class QuestionBase
    {
        public abstract string Header {  get; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        
        public Answer[] Answerlist { get; set; }
        public Answer CorrectAnswer { get; set; }

        public Answer UserAnswer { get; set; }

        public override string ToString()
        {
            return $"{Header}        Mark({Mark})\n{Body}";
        }
        public QuestionBase() 
        {
            CorrectAnswer = new Answer();
            UserAnswer = new Answer();
        }
        
        public void GetQuestionBody()
        {
            Console.WriteLine("Please Enter The Body Of Question:");
            Body = Console.ReadLine();
        }
        public void GetQuestionMark()
        {
            int mark;
            do
            {
                Console.WriteLine("Please Enter The Mark Of Question");

            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 1);

            Mark = mark;
        }
     
        public abstract void AddQuestion();

      
    }
}
