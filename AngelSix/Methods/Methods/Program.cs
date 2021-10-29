using System;

namespace Methods
{
    class Program
    {
        // static defaults the method to private
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            System.Console.WriteLine(GetUserDateOfBirth("Bug"));
            System.Console.WriteLine(GetUserDateOfBirth("Amadeus"));
        }

        public static string GetUserDateOfBirth(string fullName)
        {
            return fullName + " was born on Tuesday";
        }
    }
}
