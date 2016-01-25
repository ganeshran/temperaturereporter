using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Contracts.Input
{
    /// <summary>
    /// This interface is responsible for reading the Temperature from the log file and
    /// returning a list of the ITyre Temperature objects. This is to accomodate more than just the
    /// left or right tyre
    /// </summary>
    public interface IInputTemperatureFileReader
    {
        IEnumerable<ITyreTemperature> ReadTyreTemperatures(string filePath);
    }
}
