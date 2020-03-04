using ScheduleCalculator;
using System;

namespace PaymentSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the Payment Schedule Calculator....Press q to quit, otherwise enter to continue");

            Console.ForegroundColor = ConsoleColor.Green;
               
            string rsp = Console.ReadLine();

            if (rsp == "q")
                System.Environment.Exit(0);

            // Create a ConsoleValidator instance
            var validator = new ConsoleValidator();

            // Use ConsoleValidator instance to validate the data
            var consoleValidatorData  =  validator.GetInputData();

            // Createa an instance of Use CalculatorService to calcular the Regular and final payment
            var calculatorService = new CalculatorService(consoleValidatorData.TotalPayment, consoleValidatorData.PaymentSchedule);

            var RegularMonthlyPayment = calculatorService.CalculateRegularMonthlyPayment();

            var LastMonthlyPayment = calculatorService.CalculateLastMonthlyPayment();

            var consoleSummary = new ConsoleSummary(consoleValidatorData.TotalPayment, consoleValidatorData.PaymentSchedule, RegularMonthlyPayment, LastMonthlyPayment);

            consoleSummary.DisplaySummary();
      
        }
    }
}
 