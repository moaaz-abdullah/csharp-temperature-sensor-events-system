using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureSensor
{
    internal class TemperatureArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
