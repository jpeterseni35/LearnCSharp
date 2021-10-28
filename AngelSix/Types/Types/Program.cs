using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat;

            myFloat = 112451.05f;
            System.Console.WriteLine(myFloat);

            bool myBool = true;
            char myChar;
            string myString;

            System.Console.WriteLine($"A bool is {sizeof(bool)} bytes");

            DateTime myDate;

            // can represent a span of time (like 1 hour)
            TimeSpan myTime;


        }
    }
}
