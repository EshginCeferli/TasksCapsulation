using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Test
    {
        private string _test;

        public string Test1
        {
            get
            {
                if (_test == "man")
                {
                    Console.WriteLine("Duzdur");               
                }
                return _test;
            }   

            set
            {
                _test = value;
            }


        }
    }
}
