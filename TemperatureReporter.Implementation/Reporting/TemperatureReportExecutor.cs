using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Reporting;

namespace TemperatureReporter.Implementation.Reporting
{
    public class TemperatureReportExecutor: IReportExecutor
    {
        public string ReportName { get; set; }
        public IEnumerable<IReportingMetricCalculator> Calculators { get; set; }
    }
}
