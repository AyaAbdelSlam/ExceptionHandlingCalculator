using System;

namespace ExceptionHandlingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

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
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine($"Operation was not Provided. {ex}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An Argument was null. {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operation is not Provided. {ex}");
            }
            //Catching all exception and displaying it 
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, Something went wrong, {ex.Message}");
            }
            finally
            {
                Console.WriteLine("..........Finally...........");
            }
        }

        public static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry there was a problem and we need to close. Details {e.ExceptionObject}");
        }
    }
}
