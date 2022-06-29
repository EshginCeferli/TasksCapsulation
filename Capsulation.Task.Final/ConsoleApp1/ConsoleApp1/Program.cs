using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Verification verify = new Verification();
            verify.MailPass("cavid@code.edu.az", 12345);

            Factorial factorial = new Factorial();
            Console.WriteLine(factorial.Faktorial(5));
        }
    }
}
