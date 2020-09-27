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
                try
                {
                    return this.Divide(num1, num2);
                }
                catch (ArithmeticException ex)
                {
                    // if we do this we will lose the stacktrace 
                    //Log.Error(ex);
                    //throw ex;
                    // we just have to throw the exception without 
                    // referencing it it will keep the stacktrace
                    //throw;
                    //wrapping an exception in a new one 
                    // this will wrap the exception without info about the inner exception.
                    //throw new ArithmeticException();
                    // this will wrap the exception and will have an information of the inner expception.
                    //throw new ArithmeticException("An error happened when calculation.", ex);

                    //Using Custom Exceptions
                    throw new CalculatorException(ex);
                }
            }
            else
            {
                //throw new ArgumentOutOfRangeException(nameof(operation),
                //    "The operation you entered is not supported");

                //Using Custom Exceptions
                throw new CalculationOperationNotSupportedException(operation);

            }
        }

        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
