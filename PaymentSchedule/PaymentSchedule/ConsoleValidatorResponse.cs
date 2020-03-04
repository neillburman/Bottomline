using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSchedule
{
    /// <summary>
    /// Class used to control console input validation and return valid values
    /// </summary>
    public class ConsoleValidatorResponse
    {
        public bool validTotalPayment { get; set; }
        public  double TotalPayment{ get; set; }
      
        public bool validPaymentSchedule { get; set; }
        public double PaymentSchedule  { get; set; }

    }
}
