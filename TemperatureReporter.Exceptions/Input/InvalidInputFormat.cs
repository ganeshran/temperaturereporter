using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureReporter.Exceptions.Input
{
    public class InvalidInputFormat: BaseF1Exception
    {
        public string InvalidInput { get; set; }
        public InvalidInputFormat(string inputFormat) : base("The input recieved was not in a right format")
        {
            this.InvalidInput = inputFormat;
        }
    }
}
