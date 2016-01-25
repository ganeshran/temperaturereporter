using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Reporting;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Implementation.Reporting.Calculators
{
    public class AmbientTemperatureCalculator: IReportingMetricCalculator
    {
        public AmbientTemperatureCalculator()
        {
            this.MetricName = "Ambient Temperature";
        }
        public string MetricName { get; set; }
        public Tuple<double,double> CalculateValue(IEnumerable<Tuple<ITyreTemperature,ITyreTemperature>> tyreTemperatures)
        {
            var leftTyreTemperatures = tyreTemperatures.Select(x => x.Item1.Value);
            var rightTyreTemperatures = tyreTemperatures.Select(x => x.Item2.Value);
            return new Tuple<double, double>(Math.Round(leftTyreTemperatures.Average(),2),Math.Round(rightTyreTemperatures.Average(),2));
        }
    }
}
