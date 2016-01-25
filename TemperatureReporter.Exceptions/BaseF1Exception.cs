using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureReporter.Exceptions
{
    /// <summary>
    /// This is the base exception which will be the base class
    /// for all our custom exceptions. Any common logic would be pulled
    /// into this layer
    /// </summary>
    public class BaseF1Exception: Exception
    {
        public BaseF1Exception(string message) : base(message)
        {
            
        }
    }
}
