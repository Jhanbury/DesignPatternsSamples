using System;
using Template.Developer;

namespace Template.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var frontEnd = new FrontEndDeveloper();
            var backEnd = new BackEndDeveloper();
            var sa = new SolutionArchitect();
            Console.WriteLine("----Front End Dev Routine----");
            frontEnd.DailyRoutine();
            Console.WriteLine("----Back End Dev Routine----");
            backEnd.DailyRoutine();
            Console.WriteLine("----Solution Architect Routine----");
            sa.DailyRoutine();
        }
    }
}
