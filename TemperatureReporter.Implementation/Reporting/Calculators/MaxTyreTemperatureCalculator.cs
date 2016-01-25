using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Reporting;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Implementation.Reporting.Calculators
{
    public class MaxTyreTemperatureCalculator:
         IReportingMetricCalculator
    {
        public MaxTyreTemperatureCalculator()
        {
            this.MetricName = "Max Tyre Temperature";
        }
        public string MetricName { get; set; }
        public Tuple<double,double> CalculateValue(IEnumerable<ITyreTemperature> tyreTemperatures)
        {
            throw new NotImplementedException();
        }
    }
}
