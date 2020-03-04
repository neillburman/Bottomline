using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSchedule
{
    public class ConsoleValidator
    {

        /// <summary>
        /// This method controls both inputs, only progressing to the second input, on the first is valid
        /// </summary>
        public ConsoleValidatorData GetInputData()
        {
            bool validInput = false;
            bool input1 = false;
            bool input2 = false;
            ConsoleValidatorResponse validData;   

            do
            {

                validData = ValidateAllInput(input1, input2);
                if (validData.validTotalPayment == true && validData.validPaymentSchedule == true)
                    validInput = true;
                else
                {
                    input1 = validData.validTotalPayment;
                    input2 = validData.validPaymentSchedule;
                }

            } while (!validInput);


            Console.WriteLine("All input is valid");
            var consoleValidatorData = new ConsoleValidatorData()
            {
                TotalPayment        = validData.TotalPayment,
                PaymentSchedule     = validData.PaymentSchedule
            };

            return consoleValidatorData;
        }
        private ConsoleValidatorResponse ValidateAllInput(bool validTotalPayment, bool validPaymentSchedule)
        {

            double TotalPayment = 0;
            double PaymentSchedule = 0;  

            /* Call ValdiateInput when validTotalPayment is false */
            if (validTotalPayment == false)
                validTotalPayment = ValdiateInput("Total Payment value", false, out TotalPayment);
            //double PaymentSchedule;
            /* Call ValdiateInput when PaymentSchedule is false and validTotalPayment is true */
            if ((validPaymentSchedule == false) && (validTotalPayment == true))
                validPaymentSchedule = ValdiateInput("Number of Payments", false, out PaymentSchedule);

            var consoleValidatorResponse = new ConsoleValidatorResponse()
            {
               validTotalPayment    = validTotalPayment,
               TotalPayment         = TotalPayment,
               validPaymentSchedule = validPaymentSchedule,
               PaymentSchedule      = PaymentSchedule
            };
            return consoleValidatorResponse;
        }

        private  bool ValdiateInput(string consoleMessage, bool valid, out double entryValue)
        {
            bool _valid = valid;
            Console.WriteLine(consoleMessage);
            string inputTotalPayment = Console.ReadLine();
            if (inputTotalPayment == "q")
                System.Environment.Exit(0);
            if (!Double.TryParse(inputTotalPayment, out entryValue))
                Console.WriteLine("Invalid input, please re - enter");
            else
                _valid = true;

            return _valid;
        }
    }
}
