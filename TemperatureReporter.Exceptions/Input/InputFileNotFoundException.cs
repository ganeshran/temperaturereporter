using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureReporter.Exceptions.Input
{
    public class InputFileNotFoundException: BaseF1Exception
    {
        public string FilePath { get; set; }

        public InputFileNotFoundException(string filepath) : base("The input log file is not found")
        {
            this.FilePath = filepath;
        }
    }
}
