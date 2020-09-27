using ExceptionHandlingCalculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlerCalculator.Test
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnSupportedOperation()
        {
            //Act
            var calc = new Calculator();

            //Assert
            Assert.That(() => calc.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());

            Assert.That(() => calc.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>()
                .With.Property("Operation").EqualTo("+"));

            Assert.That(() => calc.Calculate(1, 1, "+"),
                Throws.InstanceOf<CalculatorException>());

        }
    }
}
