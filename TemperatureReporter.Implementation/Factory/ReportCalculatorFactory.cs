using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Factory;
using TemperatureReporter.Contracts.Reporting;
using TemperatureReporter.Implementation.Reporting.Calculators;

namespace TemperatureReporter.Implementation.Factory
{
    public class ReportCalculatorFactory: IReportCalculatorFactory
    {
        public IEnumerable<IReportingMetricCalculator> GetAllCalculators()
        {
            return new List<IReportingMetricCalculator>()
            {
                new AmbientTemperatureCalculator(),
                new AverageTemperatureCalculator(),
                new MaxTyreTemperatureCalculator()
            };
        }
    }
}
