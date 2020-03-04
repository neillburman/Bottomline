using System;

namespace ScheduleCalculator
{
    public class CalculatorService : ICalculatorService
    {
        private readonly double _TotalPayment;
        private readonly double _Schedule;


        /// <summary>
        /// This class is instantiate with two validated parameters. As this Service is located in a separate project, other client
        /// technologies could be used to call this service
        /// </summary>
        /// <param name="TotalPayment"></param>
        /// <param name="Schedule"></param>
        public CalculatorService(double TotalPayment, double Schedule)
        {
            _TotalPayment = TotalPayment;
            _Schedule = Schedule;
        }

        /// <summary>
        /// This method works with two parameters, which have been validated, by the calling program
        /// </summary>
        /// <param name="TotalPayment"></param>
        /// <param name="Schedule"></param>
        public double CalculateRegularMonthlyPayment()
        {

            var paymentPerMonth = this._TotalPayment / this._Schedule;
            return paymentPerMonth;
        }

        public double CalculateLastMonthlyPayment()
        {

            var paymentPerMonth = Math.Round((_TotalPayment / _Schedule),2);

            var outstanding = Math.Round(_TotalPayment - (paymentPerMonth * _Schedule), 2);

            return paymentPerMonth + outstanding;
        }


    }
}
