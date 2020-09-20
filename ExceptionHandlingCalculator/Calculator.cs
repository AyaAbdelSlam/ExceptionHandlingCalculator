using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingCalculator
{
    public class Calculator
    {
        public int Calculate(int num1, int num2, string operation)
        {
            if (operation == "/")
            {
                return this.Divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Unknown Operation");
                return 0;
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
