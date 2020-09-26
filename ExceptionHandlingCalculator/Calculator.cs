using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingCalculator
{
    public class Calculator
    {
        public int Calculate(int num1, int num2, string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));

            //if(operation == null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            if (nonNullOperation == "/")
            {
                return this.Divide(num1, num2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation),
                    "The operation you entered is not supported");
            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
