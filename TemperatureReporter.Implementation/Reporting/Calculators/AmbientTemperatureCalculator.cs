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
            this.MetricName = "Ambient Temperature Calculator";
        }
        public string MetricName { get; set; }
        public Tuple<double,double> CalculateValue(IEnumerable<ITyreTemperature> tyreTemperatures)
        {
            throw new NotImplementedException();
        }
    }
}
