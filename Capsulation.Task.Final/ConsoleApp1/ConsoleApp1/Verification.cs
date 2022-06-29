using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Verification
    {
        public string email;
        public int password;

        public void MailPass(string mail1, int pass1)

        {
            email = mail1;
            password = pass1;

            if (mail1 == "cavid@code.edu.az" && pass1 == password)
            {
                Console.WriteLine("Girish olundu");
            }
            else
            {
                Console.WriteLine("Gmail ve ya password sehvdir");
            }
        }
    }
}
