using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSchedule
{
    public class ConsoleSummary
    {
        private readonly double _TotalPayment;
        private readonly double _PaymentSchedule;
        private readonly double _RegularMonthlyPayment;
        private readonly double _LastMonthlyPayment;



        public ConsoleSummary(double TotalPayment, double  PaymentSchedule, double RegularMonthlyPayment, double LastMonthlyPayment)
        {
            _TotalPayment = TotalPayment;
            _PaymentSchedule = PaymentSchedule;
            _RegularMonthlyPayment = RegularMonthlyPayment;
            _LastMonthlyPayment = LastMonthlyPayment;
        }

        public void DisplaySummary()
        {
            string strtotalPayment = _TotalPayment.ToString("f2");
            string strRegularMonthlyPayment = _RegularMonthlyPayment.ToString("f2");
            string strLastMonthlyPayment = _LastMonthlyPayment.ToString("f2");

            if (strLastMonthlyPayment == strRegularMonthlyPayment)
            {
                Console.WriteLine($"For a total of £{strtotalPayment} over {_PaymentSchedule}  payments, : The Regular Amount £{strRegularMonthlyPayment}" );
            }
            else
            {
                Console.WriteLine($"For a total of £{strtotalPayment} over {_PaymentSchedule}  payments, : The Regular Amount £{strRegularMonthlyPayment} and Last Payment of £{strLastMonthlyPayment}");
            }
        }


    }
}
