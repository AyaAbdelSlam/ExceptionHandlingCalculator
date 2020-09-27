using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingCalculator
{
    public class CalculatorException : Exception
    {
        public static readonly string DefaultExceptionMessage = "An Error Occured during calculation.";
        public CalculatorException():base(DefaultExceptionMessage)
        {
        }

        public CalculatorException(string message):base(message)
        {
        }

        public CalculatorException(Exception innerException):base(DefaultExceptionMessage, innerException)
        {

        }

        public CalculatorException(string message, Exception innerException):base(message,innerException)
        {

        }
    }
}
