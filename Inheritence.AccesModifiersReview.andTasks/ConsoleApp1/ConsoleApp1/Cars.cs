using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public string brand;
        private int _horsePower;

        public int HorsePower
        {
            get
            {
                if (_horsePower < 100)
                {
                    Console.WriteLine("Cant drive");
                    return -1;
                }
                return _horsePower;
            }

            set
            {
                if (value < 100)
                {
                    Console.WriteLine("Please set correct correct power");
                    return;
                }
                _horsePower = value;
            }
        }
    }
}
