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
            tyreTemperatures = tyreTemperatures.Where(x => x.Item1.Value == x.Item2.Value);
            var leftTyreTemperatures = tyreTemperatures.Select(x => x.Item1.Value);
            var rightTyreTemperatures = tyreTemperatures.Select(x => x.Item2.Value);
            var largestSub =
                LongestContiguousIncreasingSubsequence(leftTyreTemperatures.Select(x => Convert.ToInt32(x)).ToArray());
            return new Tuple<double, double>(largestSub, largestSub);
        }

        int LongestContiguousIncreasingSubsequence(int[] a)
        {
            int ambientTemp = 0;
            int maxLength = 1, currentLength = 1;
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (a[i + 1] > a[i])
                    currentLength++;
                else
                {
                    if (currentLength > maxLength)
                    {
                        ambientTemp = a[i];
                        maxLength = currentLength;
                    }
                    currentLength = 1;
                }
            }

            return ambientTemp;
        }
    }
}
