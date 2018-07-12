using System;
using csharp.Interfaces;
namespace csharp.Implementations
{
    public class ExamPaper : Transcript
    {
        public string Exam { get; set; }
        public string Student { get; set; }

        public ExamPaper(IFormatter formatter) : base(formatter){

        }
        public override void Print(){
            Console.WriteLine(_formatter.Format("Exam Title", Exam));
            Console.WriteLine(_formatter.Format("Student", Student));
        }
    }
}