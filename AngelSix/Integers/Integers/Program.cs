using System;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Declaring variable
            int counter = 5;

            //  Output value to console
            System.Console.WriteLine("Counter is " + counter);

            //  Change counter to 7
            counter = 7;

            //  Add 1 to counter int
            counter += 1;

            System.Console.WriteLine("Counter is now " + counter);


            // Can also add 1 via this way below
            counter++;

            System.Console.WriteLine("Counter is now " + counter);

            counter *= 3;

            System.Console.WriteLine("Counter is now " + counter);
        }
    }
}
