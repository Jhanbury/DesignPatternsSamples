using Builder.Core;
using System;

namespace BuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Builder Demo --------------------");
            var builder = new PersonBuilder();
            var person = builder
                .Id(1)
                .FirstName("John")
                .LastName("Doe")
                .Age(24)
                .Weight(89.5)
                .Height(183.0)
                .Gender(Gender.Male)
                .Build();

            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Weight: {person.Weight}");
            Console.WriteLine($"Height: {person.Height}");
            Console.WriteLine($"Gender: {person.Gender.ToString()}");
        }
    }
}
