using System;
using csharp.Interfaces;
using System.Collections.Generic;
namespace csharp.Implementations
{
    public class FAQ : Transcript
    {
        public string Title { get; set; }
        public Dictionary<string,string> Questions { get; set; }
        
        public FAQ(IFormatter formatter) : base(formatter){
            Questions = new Dictionary<string,string>();
        }

        public void Add(string question, string answer){
            Questions.Add(question,answer);
        }
        public override void Print(){
            Console.WriteLine(_formatter.Format("Title", Title));
            foreach (var Question in Questions)
            {
                Console.WriteLine(_formatter.Format("Question", Question.Key));
                Console.WriteLine(_formatter.Format("Answer", Question.Value));
            }
            
        }
    }
}