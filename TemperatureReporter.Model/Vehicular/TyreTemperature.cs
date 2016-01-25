
using TemperatureReporter.Contracts.Enums;
using TemperatureReporter.Contracts.Vehicular;

namespace TemperatureReporter.Model.Vehicular
{
     public class TyreTemperature : ITyreTemperature
    {

        /// <summary>
        /// Initializes a new instance of the TyreTemperature class.
        /// </summary>
        public TyreTemperature(double input)
        {
            this.Value = input;
            this.UnitOfTemperature = TemperatureUnit.Celsius;
            

        }

         public TyreTemperature(double input, TemperatureUnit unitofTemperature)
         {
             this.Value = input;
             this.UnitOfTemperature = unitofTemperature;
         }

         public double Value { get; set; }
         public TemperatureUnit UnitOfTemperature { get; private set; }
    }
}