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
            this.MetricName = "Max Temperature";
        }
        public string MetricName { get; set; }
        public Tuple<double,double> CalculateValue(IEnumerable<Tuple<ITyreTemperature,ITyreTemperature>> tyreTemperatures)
        {
            var leftTyreTemperature = tyreTemperatures.Select(x => x.Item1.Value);
            var rightTyreTemperature = tyreTemperatures.Select(x => x.Item2.Value);
            return new Tuple<double, double>(leftTyreTemperature.Max(),rightTyreTemperature.Max());

        }
    }
}
