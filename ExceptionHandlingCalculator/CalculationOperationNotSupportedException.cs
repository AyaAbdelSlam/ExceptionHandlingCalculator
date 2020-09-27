using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingCalculator
{
    public class CalculationOperationNotSupportedException:CalculatorException
    {
        public string Operation { get; set; }

        public CalculationOperationNotSupportedException():base("Specified operation was out of range of valid values.")
        {
        }

        public CalculationOperationNotSupportedException(string operation):this()
        {
            Operation = operation;
        }
    }
}
