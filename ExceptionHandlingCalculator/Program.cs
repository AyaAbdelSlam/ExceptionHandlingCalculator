using System;

namespace ExceptionHandlingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            Console.WriteLine("Please enter the first number.");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("PLease enter operation");

            //try
            //{
            //    var result = calculator.Calculate(number1, number2, Console.ReadLine().ToUpperInvariant());
            //    Console.WriteLine($"Result{result}");
            //}
            ////Catching all exception
            //catch 
            //{
            //    Console.WriteLine("Sorry, Something went wrong.");
                
            //}

            try
            {
                var result = calculator.Calculate(number1, number2, null);
                Console.WriteLine($"Result{result}");
            }
            //Catching all exception and displaying it 
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, Something went wrong, {ex.Message}");

            }
        }


    }
}
