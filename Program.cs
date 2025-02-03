using System.Diagnostics;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1,"C#");
            subject.CreateExam();
            Console.Clear();

            Console.WriteLine("Do You Want To Start The Exam (Y | N ) : ");
            char ans =char.Parse(Console.ReadLine());
            Console.Clear();

            if (ans == 'Y' || ans == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subject.exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine("Waiting you :)");
            }
        }
    }
}
