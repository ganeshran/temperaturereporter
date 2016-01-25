using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Reporting;

namespace TemperatureReporter.Contracts.Factory
{
    public interface IReportCalculatorFactory
    {
        IEnumerable<IReportingMetricCalculator> GetAllCalculators();
    }
}
