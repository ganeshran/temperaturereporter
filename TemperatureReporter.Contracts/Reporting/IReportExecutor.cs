using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TemperatureReporter.Contracts.Reporting
{
    /// <summary>
    /// This contract encapsulates all kind of report executions
    /// Our particular report would only be Temperature,but basically
    /// each report would implement one instance of this interface
    /// </summary>
    public interface IReportExecutor
    {
        string ReportName { get; set; }
        IEnumerable<KeyValuePair<string,double>> MetricValues { get; set; }
        void ExecuteReport();

    }
}
