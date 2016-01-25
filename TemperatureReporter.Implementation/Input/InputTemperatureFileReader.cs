using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureReporter.Contracts.Input;
using TemperatureReporter.Contracts.Vehicular;
using TemperatureReporter.Exceptions.Input;
using TemperatureReporter.Model.Vehicular;

namespace TemperatureReporter.Implementation.Input
{
    public class InputTemperatureFileReader : IInputTemperatureFileReader
    {
        public IEnumerable<Tuple<ITyreTemperature, ITyreTemperature>> ReadTyreTemperatures(string filePath)
        {
            if (!File.Exists(filePath))
                throw new InputFileNotFoundException(filePath);

            var allTemperatures = new List<Tuple<ITyreTemperature, ITyreTemperature>>();
            foreach (var line in File.ReadAllLines(filePath))
            {
                if (IsLineValid(line))
                {
                    var lineValues = line.Split(' ');
                    allTemperatures.Add(new Tuple<ITyreTemperature, ITyreTemperature>(new TyreTemperature(Convert.ToDouble(lineValues[0])),new TyreTemperature(Convert.ToDouble(lineValues[1])) ));
                }
            }
            return allTemperatures;
        }

        private bool IsLineValid(string line)
        {
            if (String.IsNullOrWhiteSpace(line) && !line.Contains(" "))
                return false;

            var inputValues = line.Split(' ');

            return inputValues.Length == 2;
        }
    }
}
    