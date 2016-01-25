using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Factory;
using TemperatureReporter.Contracts.Reporting;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Implementation.Reporting
{
    public class TemperatureReportExecutor: IReportExecutor
    {
        public string ReportName { get; set; }
        private IEnumerable<IReportingMetricCalculator> Calculators { get; set; } 
        public IEnumerable<KeyValuePair<string,string>> ExecuteReport(IEnumerable<Tuple<ITyreTemperature,ITyreTemperature>> tyreTemperatures)
        {
            var metricValues = new List<KeyValuePair<string, string>>();
            foreach (var reportingMetricCalculator in Calculators)
            {
                var value = reportingMetricCalculator.CalculateValue(tyreTemperatures);
                metricValues.Add(new KeyValuePair<string, string>(reportingMetricCalculator.MetricName,String.Format("{0} {1}",value.Item1,value.Item2)));
            }
            return metricValues;
        }

        public TemperatureReportExecutor(IReportCalculatorFactory calculatorFactory)
        {
            this.ReportName = "Temperature Report Executor";
            this.Calculators = calculatorFactory.GetAllCalculators();
        }
    }
}
