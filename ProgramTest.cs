using System;

namespace LearnCSharp
{
    class ProgramNotes
    {
        static void Test()
        {
            try
            {
                var a = 1;
                var b = 2;
                var c = 3;

                System.Console.WriteLine(c > b || c == a);
                System.Console.WriteLine(a == b);
                System.Console.WriteLine((a + b) * c);

            }
            catch (System.Exception)
            {


            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (System.Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");


            }


        }
    }

}


// Postfix and PreFix Increments
// Postfix
// int a = 1;
// int b = a++;
// a = 2 and b = 1
// Prefix
// int a = 1;
// int b = ++a;
// a = 2 and b = 2