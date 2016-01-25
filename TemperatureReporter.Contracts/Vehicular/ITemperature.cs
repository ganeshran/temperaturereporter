using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Enums;

namespace TemperatureReporter.Contracts.Vehicular
{
    /// <summary>
    /// This interfaces stores the temperature of a particular tyre. All Conversion Logic should
    /// be buried inside this
    /// </summary>
    public interface ITemperature
    {
        double Value { get; set; }

        TemperatureUnit UnitOfTemperature { get; }

    }
}
