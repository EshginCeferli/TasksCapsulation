using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Factorial
    {
        public int n = 5;

        public int Faktorial(int num)
        {
            int fakt = 1;
            for (int i = 1; i <= num; i++)
                fakt *= i;
            return fakt;

        }
    }
}
