using csharp.Interfaces;
using System;

namespace csharp.Implementations
{
    public class Book : Transcript
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(IFormatter formatter) : base(formatter){

        }

        public override void Print(){
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Author", Author));
        }
    }
}