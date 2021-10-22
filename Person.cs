using System;

namespace LearnCSharp
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
