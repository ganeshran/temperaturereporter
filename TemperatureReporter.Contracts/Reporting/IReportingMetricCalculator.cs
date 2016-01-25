using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Contracts.Reporting
{
    /// <summary>
    /// This interface encapsulates the calculating logic 
    /// for each metric. Since time is limited, I am only
    /// assuming one type of report. However this data structure
    /// should ideally be the base class for multiple reports
    /// </summary>
    public interface IReportingMetricCalculator
    {
        string MetricName { get; set; }

        double CalculateValue(IEnumerable<ITyreTemperature> tyreTemperatures);
    }
}
