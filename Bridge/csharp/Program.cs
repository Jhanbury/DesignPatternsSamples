using System;
using csharp.Interfaces;
using csharp.Implementations;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatter = new ReverseFormatter();
            var faq = new FAQ(formatter)
            {
                Title = "FAQ"
            };
            faq.Add("Whats up doc?", "Nothing much");
            var book = new Book(formatter){
                Title = "To kill a mockingbird",
                Author = "Harper Lee"
            };
            var exampaper = new ExamPaper(formatter){
                Exam = "English",
                Student = "John"
            };
            var documents = new List<Transcript>();

            documents.Add(faq);
            documents.Add(book);
            documents.Add(exampaper);

            foreach(var doc in documents)
            {
                Console.WriteLine("-------------------------------");
                doc.Print();
                Console.WriteLine("-------------------------------");
            }         
        }
    }
}
