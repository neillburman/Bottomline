using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleCalculator
{
    /// <summary>
    /// This interface has been added, so the service can be tested with NUnit, and allow for the service to be
    /// injected into a class, such as a controller, for Dependency Injection
    /// </summary>
    public interface ICalculatorService
    {
        double CalculateRegularMonthlyPayment();

        double CalculateLastMonthlyPayment();

    }
}
