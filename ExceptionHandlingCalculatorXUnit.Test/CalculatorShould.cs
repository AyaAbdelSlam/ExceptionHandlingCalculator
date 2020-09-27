using ExceptionHandlingCalculator;
using System;
using Xunit;

namespace ExceptionHandlingCalculatorXUnit.Test
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenUnSupportedOperation()
        {
            var calc = new Calculator();

            Assert.Throws<CalculationOperationNotSupportedException>(() => calc.Calculate(1, 1, "+"));
        }
    }
}
