using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Factory;
using TemperatureReporter.Contracts.Reporting;

namespace TemperatureReporter.Implementation.Reporting
{
    public class TemperatureReportExecutor: IReportExecutor
    {
        public string ReportName { get; set; }
        public IEnumerable<KeyValuePair<string, double>> MetricValues { get; set; }
        private IEnumerable<IReportingMetricCalculator> Calculators { get; set; } 
        public void ExecuteReport()
        {
            throw new NotImplementedException();
        }

        public TemperatureReportExecutor(IReportCalculatorFactory calculatorFactory)
        {
            this.ReportName = "Temperature Report Executor";
            this.Calculators = calculatorFactory.GetAllCalculators();
        }
    }
}
