using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Input;
using TemperatureReporter.Contracts.Vehicular;
using TemperatureReporter.Exceptions.Input;

namespace TemperatureReporter.Implementation.Input
{
    public class InputTemperatureFileReader: IInputTemperatureFileReader 
    {
        public IEnumerable<ITyreTemperature> ReadTyreTemperatures(string filePath)
        {
            if(!File.Exists(filePath))
                throw new InputFileNotFoundException(filePath);

            foreach (var line in File.ReadAllLines(filePath))
            {
                
            }
            return null;
        }

        bool IsLineValid(string line)
        {
            if (String.IsNullOrWhiteSpace(line) && !line.Contains(" "))
                return false;

            var inputValues = line.Split(' ');

            return inputValues.Length == 2;
        }
    }
}
