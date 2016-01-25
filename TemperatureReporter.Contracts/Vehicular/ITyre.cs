namespace TemperatureReporter.Contracts.Vehicular
{
    /// <summary>
    /// This interface will hold various data properties 
    /// for the tyre. For this particular problem, we might only
    /// need the Temperature
    /// </summary>
    public interface ITyre
    {
        ITyreTemperature TyreTyreTemperature { get; set; }
    }
}
