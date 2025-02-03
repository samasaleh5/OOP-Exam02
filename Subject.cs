using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class Subject
    {
       public int subid {  get; set; }
        public string subname { get; set; }
        public Exam exam { get; set; }
        public QuestionBase question { get; set; }
        public Subject() { }
        public Subject(int subjectId,string Subjectname)
        {
            subid = subjectId;
            subname = Subjectname;
        }
        int TypeOfExam, NumQuestions, TypeofQuestion;
        int time;
        public void CreateExam()
        {
            do
            {
                Console.Write("Please Enter The Type Of Exam You Want To Create ( 1 for practical and 2 for final ): ");
            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam) && TypeOfExam < 1 || TypeOfExam > 2);

            do
            {
                Console.Write("Please Enter The Time Of The Exam in Minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out time));

            do
            {
                Console.Write("Please Enter The Number Of Questions You Wanted To Create: ");
            }while (!int.TryParse(Console.ReadLine(),out NumQuestions));

            Console.Clear();
            QuestionBase[] questions=new QuestionBase[NumQuestions];

            if (TypeOfExam == 1)
            {
                exam = new PracticalExam(time, NumQuestions);
            }
            else
            {
                exam= new FinalExam(time, NumQuestions);
            }
            Console.Clear();
            exam.CreateListOfQuestions();
        }
    }
}
