using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureSensor
{
    internal class Display
    {
        public void ShowTemperature(object? obj, TemperatureArgs args)
        {
            Console.WriteLine($"The current temperature value: {args.Temperature}");
        }
    }
}
